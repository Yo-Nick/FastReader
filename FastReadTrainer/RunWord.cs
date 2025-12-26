using FastReadTrainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RunWord : Form
    {
        RunWords runw = new RunWords();
        public RunWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Random rnd = new Random();
            runw.stop = rnd.Next(3, 99);
            //label14.Text = runw.stop.ToString();
            label14.Text = "Введите последнее слово";
            timer1.Interval = runw.interval;
            label13.Text = $"{60 * 1000 / timer1.Interval} слов/мин";
            runw.currentIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled && runw.currentIndex < runw.stop)
            {
                // показываем следующее слово
                runw.lastWord = runw.words[runw.currentIndex];
                labelWord.Text = runw.lastWord;
                runw.currentIndex++;
            }
            else
            {
                labelWord.Text = "";
                timer1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string input = textBox1.Text.Trim();

            if (string.Equals(input, runw.lastWord, StringComparison.OrdinalIgnoreCase))
            {
                // правильный ответ - увеличиваем скорость (уменьшаем интервал)
                if (timer1.Interval > 200)
                    runw.interval -= 100;
                else if (timer1.Interval <= 200)
                    runw.interval -= 50;
                label13.Text = $"{60 * 1000 / timer1.Interval} слов/мин";
                MessageBox.Show("Верно! Скорость увеличивается.");
            }
            else
            {
                // неправильный ответ - уменьшаем скорость (увеличиваем интервал)
                if (timer1.Interval < 5000)
                    runw.interval += 100;
                label13.Text = $"{60 * 1000 / timer1.Interval} слов/мин";
                MessageBox.Show($"Неверно! Это было: {runw.lastWord}. Скорость уменьшается.");
            }

        }

        private void RunWord_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.Show();
        }
    }
}
