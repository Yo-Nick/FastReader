namespace FastReadTrainer
{
    partial class RsvpPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnStart = new Button();
            TextLabel = new Label();
            BtnFile = new Button();
            BtnSpeedUp = new Button();
            BtnSpeedDown = new Button();
            SpeedLabel = new Label();
            FileLabel = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Anchor = AnchorStyles.Bottom;
            BtnStart.Font = new Font("Arciform", 48F);
            BtnStart.ForeColor = Color.Teal;
            BtnStart.Location = new Point(871, 894);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(262, 127);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // TextLabel
            // 
            TextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextLabel.Font = new Font("Arciform", 48F);
            TextLabel.ForeColor = Color.Teal;
            TextLabel.Location = new Point(653, 412);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(698, 293);
            TextLabel.TabIndex = 1;
            TextLabel.Text = "Текущее слово";
            TextLabel.TextAlign = ContentAlignment.MiddleCenter;
            TextLabel.Click += TextLabel_Click;
            // 
            // BtnFile
            // 
            BtnFile.BackColor = Color.Teal;
            BtnFile.Font = new Font("Arciform", 14F);
            BtnFile.ForeColor = Color.Honeydew;
            BtnFile.Location = new Point(230, 14);
            BtnFile.Name = "BtnFile";
            BtnFile.Size = new Size(212, 58);
            BtnFile.TabIndex = 2;
            BtnFile.Text = "Открыть файл";
            BtnFile.UseVisualStyleBackColor = false;
            BtnFile.Click += BtnFile_Click;
            // 
            // BtnSpeedUp
            // 
            BtnSpeedUp.Anchor = AnchorStyles.Bottom;
            BtnSpeedUp.BackColor = Color.Salmon;
            BtnSpeedUp.Font = new Font("Arciform", 18F);
            BtnSpeedUp.ForeColor = Color.Honeydew;
            BtnSpeedUp.Location = new Point(653, 923);
            BtnSpeedUp.Name = "BtnSpeedUp";
            BtnSpeedUp.Size = new Size(212, 98);
            BtnSpeedUp.TabIndex = 3;
            BtnSpeedUp.Text = "Уменьшить скорость";
            BtnSpeedUp.UseVisualStyleBackColor = false;
            BtnSpeedUp.Click += BtnSpeedUp_Click;
            // 
            // BtnSpeedDown
            // 
            BtnSpeedDown.Anchor = AnchorStyles.Bottom;
            BtnSpeedDown.BackColor = Color.LightGreen;
            BtnSpeedDown.Font = new Font("Arciform", 18F);
            BtnSpeedDown.ForeColor = Color.Honeydew;
            BtnSpeedDown.Location = new Point(1139, 923);
            BtnSpeedDown.Name = "BtnSpeedDown";
            BtnSpeedDown.Size = new Size(212, 98);
            BtnSpeedDown.TabIndex = 4;
            BtnSpeedDown.Text = "Увеличить скорость";
            BtnSpeedDown.UseVisualStyleBackColor = false;
            BtnSpeedDown.Click += BtnSpeedDown_Click;
            // 
            // SpeedLabel
            // 
            SpeedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SpeedLabel.AutoSize = true;
            SpeedLabel.Font = new Font("Arciform", 24F);
            SpeedLabel.ForeColor = Color.Teal;
            SpeedLabel.Location = new Point(1388, 9);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(359, 49);
            SpeedLabel.TabIndex = 5;
            SpeedLabel.Text = "Текущая скорость:";
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.Font = new Font("Arciform", 18F);
            FileLabel.ForeColor = Color.Teal;
            FileLabel.Location = new Point(12, 73);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(317, 37);
            FileLabel.TabIndex = 6;
            FileLabel.Text = "Сейчас открыт файл:";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Teal;
            btnReturn.Font = new Font("Arciform", 14F);
            btnReturn.ForeColor = Color.Honeydew;
            btnReturn.Location = new Point(12, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(212, 58);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "В главное меню";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // RsvpPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1902, 1033);
            Controls.Add(TextLabel);
            Controls.Add(btnReturn);
            Controls.Add(FileLabel);
            Controls.Add(SpeedLabel);
            Controls.Add(BtnSpeedDown);
            Controls.Add(BtnSpeedUp);
            Controls.Add(BtnFile);
            Controls.Add(BtnStart);
            Name = "RsvpPage";
            Text = "RsvpPage";
            Load += RsvpPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private Label TextLabel;
        private Button BtnFile;
        private Button BtnSpeedUp;
        private Button BtnSpeedDown;
        private Label SpeedLabel;
        private Label FileLabel;
        private Button btnReturn;
    }
}