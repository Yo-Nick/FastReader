namespace WinFormsApp1
{
    partial class RunWord
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
            components = new System.ComponentModel.Container();
            labelWord = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnReturn = new Button();
            SuspendLayout();
            // 
            // labelWord
            // 
            labelWord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWord.AutoSize = true;
            labelWord.Font = new Font("Arciform", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWord.ForeColor = Color.Teal;
            labelWord.Location = new Point(730, 329);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(390, 147);
            labelWord.TabIndex = 0;
            labelWord.Text = "Слово";
            labelWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Arciform", 36F);
            button1.ForeColor = Color.AntiqueWhite;
            button1.Location = new Point(601, 887);
            button1.Name = "button1";
            button1.Size = new Size(628, 107);
            button1.TabIndex = 1;
            button1.Text = "Начать тренировку";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(1461, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.LightGreen;
            button2.Font = new Font("Arciform", 12F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(1773, 223);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Ответ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Arciform", 24F);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(1453, 25);
            label12.Name = "label12";
            label12.Size = new Size(359, 49);
            label12.TabIndex = 5;
            label12.Text = "Текущая скорость:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Font = new Font("Arciform", 22F);
            label13.ForeColor = Color.Salmon;
            label13.Location = new Point(1453, 84);
            label13.Name = "label13";
            label13.Size = new Size(359, 49);
            label13.TabIndex = 6;
            label13.Text = "много слов/мин";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Arciform", 20F);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(1453, 171);
            label14.Name = "label14";
            label14.Size = new Size(414, 42);
            label14.TabIndex = 7;
            label14.Text = "Введите последнее слово:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Teal;
            btnReturn.Font = new Font("Arciform", 14F);
            btnReturn.ForeColor = Color.AntiqueWhite;
            btnReturn.Location = new Point(12, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(159, 88);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "В главное меню";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // RunWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1902, 1033);
            Controls.Add(labelWord);
            Controls.Add(btnReturn);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "RunWord";
            Text = "Exercise_1";
            Load += RunWord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label labelWord;
        private TextBox textBox1;
        private Button button2;
        private Label label12;
        private Label label13;
        private Label label14;
        private System.Windows.Forms.Timer timer1;
        private Button btnReturn;
    }
}