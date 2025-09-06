using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FinalProject
{
    public partial class Settings : Form
    {
        private Config config;
        public Settings()
        {
            InitializeComponent();

            if (File.Exists("config.json"))
            {
                config = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));
                chkStatistics.Checked = config.EnableStatistics;
                chkModeration.Checked = config.EnableModeration;
                txtPath.Text = config.ReportPath;

                lstWords.Items.AddRange(config.ForbiddenWords.ToArray());
                lstApps.Items.AddRange(config.ForbiddenApps.ToArray());
            }
            else
            {
                config = new Config();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWord.Text))
            {
                lstWords.Items.Add(txtWord.Text);
                txtWord.Clear();
            }
        }

        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            if (lstWords.SelectedItem != null)
                lstWords.Items.Remove(lstWords.SelectedItem);
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtApp.Text))
            {
                lstApps.Items.Add(txtApp.Text);
                txtApp.Clear();
            }
        }

        private void btnRemoveApp_Click(object sender, EventArgs e)
        {
            if (lstApps.SelectedItem != null)
                lstApps.Items.Remove(lstApps.SelectedItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            config.EnableStatistics = chkStatistics.Checked;
            config.EnableModeration = chkModeration.Checked;
            config.ReportPath = txtPath.Text;

            config.ForbiddenWords = new List<string>();
            foreach (var item in lstWords.Items)
                config.ForbiddenWords.Add(item.ToString());

            config.ForbiddenApps = new List<string>();
            foreach (var item in lstApps.Items)
                config.ForbiddenApps.Add(item.ToString());

            File.WriteAllText("config.json", JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true }));

            MessageBox.Show("Налаштування збереженi!");
            this.Close();
        }

    }
}
