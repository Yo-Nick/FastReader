using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FastReadTrainer
{

    public partial class RsvpPage : Form
    {
        //Создаем экземпляр класса и переменную для пути файла
        private RsvpMechanics rsvpMechanics = new RsvpMechanics();
        private string currentFilePath;

        public RsvpPage()
        {
            InitializeComponent();
            //rsvpMechanics = new RsvpMechanics();

            // Подписываемся на события класса
            rsvpMechanics.WordChanged += OnWordChanged;
            rsvpMechanics.StartStateChanged += OnStartStateChanged;
            rsvpMechanics.SpeedChanged += OnSpeedChanged;

        }

        private void RsvpPage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;

            SpeedLabel.Text = $"Текущая скорость: {60 * 1000 / rsvpMechanics.Interval} слов/мин";
            TextLabel.Text = "Выберите файл и нажмите Старт";
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    rsvpMechanics.LoadFile(currentFilePath);
                    FileLabel.Text = $"Сейчас открыт файл: {currentFilePath}";
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            rsvpMechanics.ToggleStart();
        }

        private void BtnSpeedDown_Click(object sender, EventArgs e)
        {
            rsvpMechanics.SpeedDown();
        }

        private void BtnSpeedUp_Click(object sender, EventArgs e)
        {
            rsvpMechanics.SpeedUp();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.Show();
        }

        // Обработчики событий
        private void OnWordChanged(string word)
        {

            TextLabel.Text = word;
            TextLabel.Refresh();
        }

        private void OnStartStateChanged(bool started)
        {
            if (started)
            {
                BtnStart.Text = "Pause";
                BtnStart.BackColor = Color.Pink;
            }
            else
            {
                BtnStart.Text = "Start";
                BtnStart.BackColor = SystemColors.Control;
            }
        }

        private void OnSpeedChanged(string speedText)
        {
            SpeedLabel.Text = speedText;
        }

        private void TextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
