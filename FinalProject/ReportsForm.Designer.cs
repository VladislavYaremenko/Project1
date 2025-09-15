namespace FinalProject
{
    partial class ReportsForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtKeys = new TextBox();
            tabPage2 = new TabPage();
            txtProcesses = new TextBox();
            tabPage3 = new TabPage();
            txtModeration = new TextBox();
            btnRefresh = new Button();
            btnClear = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 391);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtKeys);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 363);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Клавiшi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtKeys
            // 
            txtKeys.Location = new Point(-4, 3);
            txtKeys.Multiline = true;
            txtKeys.Name = "txtKeys";
            txtKeys.ScrollBars = ScrollBars.Vertical;
            txtKeys.Size = new Size(772, 357);
            txtKeys.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtProcesses);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 363);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Процеси";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtProcesses
            // 
            txtProcesses.Location = new Point(0, 0);
            txtProcesses.Multiline = true;
            txtProcesses.Name = "txtProcesses";
            txtProcesses.ScrollBars = ScrollBars.Vertical;
            txtProcesses.Size = new Size(768, 363);
            txtProcesses.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtModeration);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 363);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Модерацiя";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtModeration
            // 
            txtModeration.Location = new Point(0, 3);
            txtModeration.Multiline = true;
            txtModeration.Name = "txtModeration";
            txtModeration.ScrollBars = ScrollBars.Vertical;
            txtModeration.Size = new Size(768, 360);
            txtModeration.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(16, 415);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 23);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Оновити звiт";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(160, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Очистити звiт";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnRefresh);
            Controls.Add(tabControl1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRefresh;
        private Button btnClear;
        private TabPage tabPage3;
        private TextBox txtKeys;
        private TextBox txtProcesses;
        private TextBox txtModeration;
    }
}