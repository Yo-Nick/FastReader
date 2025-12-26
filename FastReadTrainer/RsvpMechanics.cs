using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace FastReadTrainer
{
    // Отдельный класс для механик RSVP
    public class RsvpMechanics
    {
        public string[] WordsArray { get; private set; }
        public int CurrentWordIndex { get; private set; }
        public int Interval { get; private set; } = 2000;
        public bool IsStarted { get; private set; }
        public Timer WordTimer { get; private set; }

        public event Action<string> WordChanged;
        public event Action<bool> StartStateChanged;
        public event Action<string> SpeedChanged;

        public RsvpMechanics()
        {
        }

        public void LoadFile(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                char[] separators = { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':' };
                WordsArray = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (WordsArray.Length > 0)
                {
                    CurrentWordIndex = 0;
                    OnWordChanged(WordsArray[0]);
                }
                else
                {
                    OnWordChanged("Файл пустой");
                }
            }
            catch (Exception ex)
            {
                OnWordChanged($"Ошибка: {ex.Message}");
            }
        }

        public void ToggleStart()
        {
            IsStarted = !IsStarted;
            SetupWordTimer();
            OnStartStateChanged(IsStarted);
        }

        private void SetupWordTimer()
        {
            if (IsStarted)
            {
                WordTimer = new Timer();
                WordTimer.Interval = Interval;
                WordTimer.Tick += (s, e) => WordTimer_Tick();
                WordTimer.Start();
            }
            else if (WordTimer != null)
            {
                WordTimer.Stop();
                WordTimer.Dispose();
                WordTimer = null;
            }
        }

        private void WordTimer_Tick()
        {
            if (WordsArray != null && WordsArray.Length > 0)
            {
                CurrentWordIndex++;
                if (CurrentWordIndex >= WordsArray.Length)
                    CurrentWordIndex = 0;

                OnWordChanged(WordsArray[CurrentWordIndex]);

            }
        }

        public void SpeedDown()
        {
            if ((60 * 1000 / Interval) < 600)
            {
                Interval -= 100;
                OnSpeedChanged($"Текущая скорость: {60 * 1000 / Interval} слов/мин");
            }
        }

        public void SpeedUp()
        {
            if ((60 * 1000 / Interval) > 30)
            {
                Interval += 100;
                OnSpeedChanged($"Текущая скорость: {60 * 1000 / Interval} слов/мин");
            }
        }

        protected virtual void OnWordChanged(string word)
        {
            WordChanged?.Invoke(word);
        }

        protected virtual void OnStartStateChanged(bool started)
        {
            StartStateChanged?.Invoke(started);
        }

        protected virtual void OnSpeedChanged(string speedText)
        {
            SpeedChanged?.Invoke(speedText);
        }

    }
}
