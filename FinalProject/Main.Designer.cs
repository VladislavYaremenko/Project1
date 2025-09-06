namespace FinalProject
{
    partial class Main
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
            btnStart = new Button();
            btnExit = new Button();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnStart.Location = new Point(162, 114);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(157, 49);
            btnStart.TabIndex = 0;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnExit.Location = new Point(162, 276);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(157, 49);
            btnExit.TabIndex = 1;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSettings.Location = new Point(162, 195);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(157, 49);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Налаштування";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 526);
            Controls.Add(btnSettings);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Font = new Font("Segoe UI", 9F);
            Name = "Main";
            Text = "Project";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnExit;
        private Button btnSettings;
    }
}
