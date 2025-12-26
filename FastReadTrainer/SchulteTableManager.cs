using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastReadTrainer
{
    // Класс для логики таблицы Шульте
    public class SchulteTableManager
    {
        private readonly int[,] table = new int[5, 5];
        private int currentNumber = 1;
        private int errors = 0;
        private Stopwatch stopwatch = new Stopwatch();
        private Random random = new Random();
        public Button[,] Buttons { get; private set; } = new Button[5, 5];
        public Label CurrentLabel { get; set; }
        public event Action<string> OnGameCompleted;

        public void InitializeButtons(Form parentForm)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Buttons[row, col] = new Button();
                    Buttons[row, col].Size = new Size(120, 120);
                    Buttons[row, col].Location = new Point(500 + col * 150, 150 + row * 150);
                    Buttons[row, col].Font = new Font("Arciform", 18);
                    Buttons[row, col].ForeColor = Color.Honeydew;
                    Buttons[row, col].BackColor = Color.AntiqueWhite;
                    Buttons[row, col].Tag = new Point(row, col);
                    Buttons[row, col].Click += Button_Click;
                    parentForm.Controls.Add(Buttons[row, col]);
                }
            }
        }

        public void StartGame()
        {
            GenerateTable();
            currentNumber = 1;
            errors = 0;
            stopwatch.Reset();
            stopwatch.Start();
            UpdateCurrentLabel();
        }

        public void ResetGame()
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (Buttons[row, col] != null)
                    {
                        Buttons[row, col].ForeColor = Color.Honeydew;
                        Buttons[row, col].Text = "";
                        Buttons[row, col].BackColor = Color.Teal;
                        Buttons[row, col].Enabled = false;
                    }
                }
            }
            currentNumber = 1;
            errors = 0;
            stopwatch.Reset();
            if (CurrentLabel != null)
                CurrentLabel.Text = "Нажмите Старт";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point position = (Point)clickedButton.Tag;
            int clickedValue = table[position.X, position.Y];

            if (clickedValue == currentNumber)
            {
                clickedButton.BackColor = Color.LightGreen;
                clickedButton.ForeColor = Color.Honeydew;
                clickedButton.Enabled = false;
                currentNumber++;

                if (currentNumber > 25)
                {
                    stopwatch.Stop();
                    ShowResult();
                }
                else
                {
                    UpdateCurrentLabel();
                }
            }
            else
            {
                errors++;
                clickedButton.BackColor = Color.Salmon;
                clickedButton.ForeColor = Color.Honeydew;

            }
        }

        private void GenerateTable()
        {
            int[] numbers = Enumerable.Range(1, 25).ToArray();
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            int index = 0;
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    table[row, col] = numbers[index++];
                    Buttons[row, col].ForeColor = Color.Honeydew;
                    Buttons[row, col].Text = table[row, col].ToString();
                    Buttons[row, col].BackColor = Color.Teal;
                    Buttons[row, col].Enabled = true;
                }
            }
        }

        private void UpdateCurrentLabel()
        {
            if (CurrentLabel != null)
                CurrentLabel.Text = $"Следующая цифра:\n{currentNumber}";
        }

        private void ShowResult()
        {
            TimeSpan time = stopwatch.Elapsed;
            string message = $"Игра завершена!\n" +
                           $"Время: {time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds / 10:00}\n" +
                           $"Ошибок: {errors}";
            MessageBox.Show(message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OnGameCompleted?.Invoke(message);
        }
    }

}
