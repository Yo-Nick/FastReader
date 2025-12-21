namespace FastReader
{
    partial class SchultePage2
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
            groupBox2 = new GroupBox();
            startButton = new Button();
            currentLabel = new Label();
            btnReturn = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(startButton);
            groupBox2.Controls.Add(currentLabel);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(847, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 491);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startButton.Location = new Point(12, 383);
            startButton.Name = "startButton";
            startButton.Size = new Size(317, 78);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click_1;
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Location = new Point(12, 35);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(50, 20);
            currentLabel.TabIndex = 0;
            currentLabel.Text = "label1";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(151, 29);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "В главное меню";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // SchultePage2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 491);
            Controls.Add(btnReturn);
            Controls.Add(groupBox2);
            Name = "SchultePage2";
            Text = "SchultePage";
            Load += SchultePage_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button startButton;
        private Label currentLabel;
        private Button btnReturn;
    }
}