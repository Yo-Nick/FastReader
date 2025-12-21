namespace FastReadTrainer
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSchulte = new Button();
            btnRSVP = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSchulte
            // 
            btnSchulte.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSchulte.Location = new Point(23, 369);
            btnSchulte.Name = "btnSchulte";
            btnSchulte.Size = new Size(301, 97);
            btnSchulte.TabIndex = 0;
            btnSchulte.Text = "Таблица Шульте";
            btnSchulte.UseVisualStyleBackColor = true;
            btnSchulte.Click += btnSchulte_Click;
            // 
            // btnRSVP
            // 
            btnRSVP.Location = new Point(928, 383);
            btnRSVP.Name = "btnRSVP";
            btnRSVP.Size = new Size(301, 97);
            btnRSVP.TabIndex = 1;
            btnRSVP.Text = "RSVP";
            btnRSVP.UseVisualStyleBackColor = true;
            btnRSVP.Click += btnRSVP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 492);
            Controls.Add(label1);
            Controls.Add(btnRSVP);
            Controls.Add(btnSchulte);
            Name = "MainPage";
            Text = "Form1";
            Load += MainPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSchulte;
        private Button btnRSVP;
        private Label label1;
    }
}
