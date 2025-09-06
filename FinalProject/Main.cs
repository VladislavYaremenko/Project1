namespace FinalProject
{
    using System.Text.Json;
    public partial class Main : Form
    {
        private Config config;
        public Main()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var Settings = new Settings();
            Settings.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists("config.json"))
            {
                MessageBox.Show("�������� ���������� �� ������i�� ���������!");
                return;
            }

            config = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));

            if (!config.EnableStatistics && !config.EnableModeration)
            {
                MessageBox.Show("����i�� ����� 1 ���������.");
                return;
            }

            if (string.IsNullOrWhiteSpace(config.ReportPath))
            {
                MessageBox.Show("������ ���� �� �����.");
                return;
            }

            MessageBox.Show("������� ����� ��������!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
