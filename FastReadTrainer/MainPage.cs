using FastReader;
using WinFormsApp1;

namespace FastReadTrainer
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSchulte_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchultePage2 sp = new SchultePage2();
            sp.Show();
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            this.Hide();
            RsvpPage rp = new RsvpPage();
            rp.Show();
        }

        private void WhatIsSchBtn_Click(object sender, EventArgs e)
        {
            string infoText = "Таблицы Шульте\nИщите числа по порядку в таблице с разбросанными цифрами, постепенно увеличивая размер. Это расширяет поле зрения и улучшает сканирование текста";

            MessageBox.Show(infoText, "Информация об упражнении",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WhatIsRsvpBtn_Click(object sender, EventArgs e)
        {
            string infoText = "RSVP (быстрая последовательная визуальная презентация)\nпоказывает слова из выбранного файла (.txt) по одному на экране с заданной скоростью";

            MessageBox.Show(infoText, "Информация об упражнении",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RunWord runWord = new RunWord();
            runWord.Show();
        }

        private void BtnWhatIsRunWord_Click(object sender, EventArgs e)
        {
            string infoText = "Бегущие слова – перед игроком воспроизводятся слова с определенной скоростью.\nЗадача игрока состоит в том чтобы написать последнее воспроизведенное слово.\nЕсли всё верно,то скорость увеличится, и наоборот";

            MessageBox.Show(infoText, "Информация об упражнении",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string infoText = "Данный тренажер был сделан на Windows Forms в рамках курсовой работы\n\n\nНе исключено наличие багов :D";

            MessageBox.Show(infoText, "Информация о программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
