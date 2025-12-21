using FastReadTrainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReader
{
    public partial class SchultePage2 : Form
    {

        private int[,] table = new int[5, 5];
        private int currentNumber = 1;
        private int errors = 0;
        private Stopwatch stopwatch = new Stopwatch();
        private Random random = new Random();
        private Button[,] buttons = new Button[5, 5];
        public SchultePage2()
        {
            InitializeComponent();
            InitializeTable();
        }

        private void SchultePage_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeTable()
        {
            this.Size = new System.Drawing.Size(400, 450);
            this.Text = "Таблица Шульте 5x5";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Создаем кнопки 5x5
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    buttons[row, col] = new Button();
                    buttons[row, col].Size = new System.Drawing.Size(120, 120);
                    buttons[row, col].Location = new System.Drawing.Point(500 + col * 150, 150 + row * 150);
                    buttons[row, col].Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
                    buttons[row, col].BackColor = System.Drawing.Color.White;
                    buttons[row, col].Tag = new Point(row, col);
                    buttons[row, col].Click += Button_Click;
                    this.Controls.Add(buttons[row, col]);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point position = (Point)clickedButton.Tag;
            int clickedValue = table[position.X, position.Y];

            if (clickedValue == currentNumber)
            {
                // Правильный выбор
                clickedButton.BackColor = System.Drawing.Color.Green;
                clickedButton.Enabled = false;
                currentNumber++;

                Label currentLabel = this.Controls.Find("currentLabel", true).FirstOrDefault() as Label;
                if (currentLabel != null)
                {
                    if (currentNumber > 25)
                    {
                        stopwatch.Stop();
                        ShowResult();
                    }
                    else
                    {
                        currentLabel.Text = $"Следующая цифра: {currentNumber}";
                    }
                }
            }
            else
            {
                // Ошибка
                errors++;
                clickedButton.BackColor = System.Drawing.Color.Orange;
            }
        }

        private void GenerateTable()
        {
            // Создаем массив чисел 1-25
            int[] numbers = Enumerable.Range(1, 25).ToArray();

            // Перемешиваем
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            // Заполняем таблицу
            int index = 0;
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    table[row, col] = numbers[index++];
                    buttons[row, col].Text = table[row, col].ToString();
                    buttons[row, col].BackColor = System.Drawing.Color.White;
                    buttons[row, col].Enabled = true;
                }
            }
        }
        private void ResetTable()
        {
            // Очищаем только таблицу при инициализации
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (buttons[row, col] != null)
                    {
                        buttons[row, col].Text = "";
                        buttons[row, col].BackColor = Color.White;
                        buttons[row, col].Enabled = false;
                    }
                }
            }
            currentLabel.Text = "Нажмите Старт";
            startButton.Enabled = true;
            startButton.Text = "Старт";
            stopwatch.Reset();
        }
        private void ShowResult()
        {
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            string message = $"Игра завершена!\n" +
                            $"Время: {time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds / 10:00}\n" +
                            $"Ошибок: {errors}";
            MessageBox.Show(message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Перезапуск
            ResetTable();
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            GenerateTable();
            currentNumber = 1;
            errors = 0;
            stopwatch.Reset();
            stopwatch.Start();

            // Убираем кнопку Старт
            this.Controls.Remove((Button)sender);

            // Лейбл с текущим числом
            currentLabel.Text = $"Следующая цифра: {currentNumber}";
            currentLabel.Size = new System.Drawing.Size(100, 30);
            currentLabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.Show();
        }
    }
}
