namespace FinalProject
{
    partial class Settings
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
            chkStatistics = new CheckBox();
            txtPath = new TextBox();
            btnBrowse = new Button();
            chkModeration = new CheckBox();
            gbWords = new GroupBox();
            btnAddWord = new Button();
            btnRemoveWord = new Button();
            txtWord = new TextBox();
            lstWords = new ListBox();
            lstApps = new ListBox();
            txtApp = new TextBox();
            btnRemoveApp = new Button();
            btnAddApp = new Button();
            gbApps = new GroupBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // chkStatistics
            // 
            chkStatistics.AutoSize = true;
            chkStatistics.Location = new Point(44, 79);
            chkStatistics.Name = "chkStatistics";
            chkStatistics.Size = new Size(87, 19);
            chkStatistics.TabIndex = 0;
            chkStatistics.Text = "Статистика";
            chkStatistics.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(44, 29);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(181, 23);
            txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(231, 28);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Шлях";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkModeration
            // 
            chkModeration.AutoSize = true;
            chkModeration.Location = new Point(44, 104);
            chkModeration.Name = "chkModeration";
            chkModeration.Size = new Size(101, 19);
            chkModeration.TabIndex = 3;
            chkModeration.Text = "Модерування";
            chkModeration.UseVisualStyleBackColor = true;
            // 
            // gbWords
            // 
            gbWords.Location = new Point(44, 176);
            gbWords.Name = "gbWords";
            gbWords.Size = new Size(159, 107);
            gbWords.TabIndex = 4;
            gbWords.TabStop = false;
            gbWords.Text = "Заборонені слова";
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(44, 289);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(75, 23);
            btnAddWord.TabIndex = 5;
            btnAddWord.Text = "додати";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // btnRemoveWord
            // 
            btnRemoveWord.Location = new Point(128, 289);
            btnRemoveWord.Name = "btnRemoveWord";
            btnRemoveWord.Size = new Size(75, 23);
            btnRemoveWord.TabIndex = 6;
            btnRemoveWord.Text = "видалити";
            btnRemoveWord.UseVisualStyleBackColor = true;
            btnRemoveWord.Click += btnRemoveWord_Click;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(45, 147);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(100, 23);
            txtWord.TabIndex = 7;
            // 
            // lstWords
            // 
            lstWords.FormattingEnabled = true;
            lstWords.ItemHeight = 15;
            lstWords.Location = new Point(221, 189);
            lstWords.Name = "lstWords";
            lstWords.Size = new Size(120, 94);
            lstWords.TabIndex = 8;
            // 
            // lstApps
            // 
            lstApps.FormattingEnabled = true;
            lstApps.ItemHeight = 15;
            lstApps.Location = new Point(222, 386);
            lstApps.Name = "lstApps";
            lstApps.Size = new Size(120, 94);
            lstApps.TabIndex = 13;
            // 
            // txtApp
            // 
            txtApp.Location = new Point(45, 344);
            txtApp.Name = "txtApp";
            txtApp.Size = new Size(100, 23);
            txtApp.TabIndex = 12;
            // 
            // btnRemoveApp
            // 
            btnRemoveApp.Location = new Point(129, 486);
            btnRemoveApp.Name = "btnRemoveApp";
            btnRemoveApp.Size = new Size(75, 23);
            btnRemoveApp.TabIndex = 11;
            btnRemoveApp.Text = "видалити";
            btnRemoveApp.UseVisualStyleBackColor = true;
            btnRemoveApp.Click += btnRemoveApp_Click;
            // 
            // btnAddApp
            // 
            btnAddApp.Location = new Point(45, 486);
            btnAddApp.Name = "btnAddApp";
            btnAddApp.Size = new Size(75, 23);
            btnAddApp.TabIndex = 10;
            btnAddApp.Text = "додати";
            btnAddApp.UseVisualStyleBackColor = true;
            btnAddApp.Click += btnAddApp_Click;
            // 
            // gbApps
            // 
            gbApps.Location = new Point(45, 373);
            gbApps.Name = "gbApps";
            gbApps.Size = new Size(159, 107);
            gbApps.TabIndex = 9;
            gbApps.TabStop = false;
            gbApps.Text = "Заборонені програми";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(554, 489);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 532);
            Controls.Add(btnSave);
            Controls.Add(lstApps);
            Controls.Add(txtApp);
            Controls.Add(btnRemoveApp);
            Controls.Add(btnAddApp);
            Controls.Add(gbApps);
            Controls.Add(lstWords);
            Controls.Add(txtWord);
            Controls.Add(btnRemoveWord);
            Controls.Add(btnAddWord);
            Controls.Add(gbWords);
            Controls.Add(chkModeration);
            Controls.Add(btnBrowse);
            Controls.Add(txtPath);
            Controls.Add(chkStatistics);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkStatistics;
        private TextBox txtPath;
        private Button btnBrowse;
        private CheckBox chkModeration;
        private GroupBox gbWords;
        private Button btnAddWord;
        private Button btnRemoveWord;
        private TextBox txtWord;
        private ListBox lstWords;
        private ListBox lstApps;
        private TextBox txtApp;
        private Button btnRemoveApp;
        private Button btnAddApp;
        private GroupBox gbApps;
        private Button btnSave;
    }
}