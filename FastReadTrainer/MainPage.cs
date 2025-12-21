using FastReader;

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
            this.TopMost = true;
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

        }
    }
}
