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
                MessageBox.Show("Спочатку налаштуйте та збережiть параметри!");
                return;
            }

            config = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));

            if (!config.EnableStatistics && !config.EnableModeration)
            {
                MessageBox.Show("Оберiть хочаб 1 режим (Статистика или Модерацiя).");
                return;
            }

            if (string.IsNullOrWhiteSpace(config.ReportPath))
            {
                MessageBox.Show("Вкажіть шлях до файлів.");
                return;
            }

            MessageBox.Show("Фоновий режим запущено! (здесь будет логика слежения)");
            // TODO: добавить запуск фоновых задач
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
