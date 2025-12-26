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
        private readonly SchulteTableManager tableManager = new SchulteTableManager();

        public SchultePage2()
        {
            InitializeComponent();
            tableManager.CurrentLabel = currentLabel;
            tableManager.OnGameCompleted += OnGameCompleted;
        }

        private void SchultePage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
            tableManager.InitializeButtons(this);
            tableManager.ResetGame();
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            this.Controls.Remove((Button)sender);
            tableManager.StartGame();
        }

        private void OnGameCompleted(string result)
        {
            tableManager.ResetGame();
            startButton.Enabled = true;
            startButton.Text = "Старт";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.Show();
        }
    }
}
