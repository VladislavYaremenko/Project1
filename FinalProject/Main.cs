namespace FinalProject
{
    using System.Text.Json;
    public partial class Main : Form
    {
        private Config config;
        private KeyLogger keyLogger;
        private ProcessWatcher processWatcher;
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
                MessageBox.Show("Спочатку налаштуйте та збережiть параметри!");
                return;
            }

            config = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));

            if (!config.EnableStatistics && !config.EnableModeration)
            {
                MessageBox.Show("Оберiть хочаб 1 прапорець.");
                return;
            }

            if (string.IsNullOrWhiteSpace(config.ReportPath))
            {
                MessageBox.Show("Вкажіть шлях до файлів.");
                return;
            }

            if (config.EnableStatistics)
            {
                string logPath = Path.Combine(config.ReportPath, "keystrokes.log");
                keyLogger = new KeyLogger(logPath);
                keyLogger.KeyLogged += (s, key) =>
                {
                    txtLog.Invoke((MethodInvoker)(() => txtLog.AppendText(key)));
                };
                keyLogger.Start();
            }

            if (config.EnableModeration)
            {
                if (!Directory.Exists(config.ReportPath))
                    Directory.CreateDirectory(config.ReportPath);

                string processLogPath = Path.Combine(config.ReportPath, "processes.log");
                processWatcher = new ProcessWatcher(processLogPath, config.EnableModeration, config.ForbiddenApps.ToArray());
                processWatcher.Start();
            }

            MessageBox.Show("Фоновий режим запущено!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e){}
    }
}
