using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ReportsForm : Form
    {
        private string reportPath;

        public ReportsForm(string reportPath)
        {
            InitializeComponent();
            this.reportPath = reportPath;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(reportPath, "keystrokes.log")))
                File.WriteAllText(Path.Combine(reportPath, "keystrokes.log"), "");

            if (File.Exists(Path.Combine(reportPath, "processes.log")))
                File.WriteAllText(Path.Combine(reportPath, "processes.log"), "");

            if (File.Exists(Path.Combine(reportPath, "moderation.log")))
                File.WriteAllText(Path.Combine(reportPath, "moderation.log"), "");

            LoadReports();
        }

        private void LoadReports()
        {
            string keyLogPath = Path.Combine(reportPath, "keystrokes.log");
            string procLogPath = Path.Combine(reportPath, "processes.log");
            string modLogPath = Path.Combine(reportPath, "moderation.log");

            txtKeys.Text = File.Exists(keyLogPath) ? File.ReadAllText(keyLogPath) : "Немає даних.";
            txtProcesses.Text = File.Exists(procLogPath) ? File.ReadAllText(procLogPath) : "Немає даних.";
            txtModeration.Text = File.Exists(modLogPath) ? File.ReadAllText(modLogPath) : "Немає даних.";
        }
    }
}

