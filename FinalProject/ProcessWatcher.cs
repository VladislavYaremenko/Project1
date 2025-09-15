using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;
using System.Diagnostics;

namespace FinalProject
{
    public class ProcessWatcher
    {
        private readonly string logPath;
        private readonly bool enableModeration;
        private readonly string[] forbiddenProcesses;
        private ManagementEventWatcher watcher;

        public event EventHandler<string> ProcessLogged;

        public ProcessWatcher(string logPath, bool enableModeration, string[] forbiddenProcesses)
        {
            this.logPath = logPath;
            this.enableModeration = enableModeration;
            this.forbiddenProcesses = forbiddenProcesses ?? Array.Empty<string>();
        }

        public void Start()
        {
            WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace");
            watcher = new ManagementEventWatcher(query);
            watcher.EventArrived += OnProcessStarted;
            watcher.Start();
        }

        public void Stop()
        {
            watcher?.Stop();
            watcher?.Dispose();
        }

        private void OnProcessStarted(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            DateTime startTime = DateTime.Now;

            string logEntry = $"{startTime:yyyy-MM-dd HH:mm:ss} - {processName}";
            File.AppendAllText(logPath, logEntry + Environment.NewLine);

            
            string moderationLogPath = Path.Combine(Path.GetDirectoryName(logPath), "moderation.log");

            if (enableModeration && IsForbidden(processName))
            {
                try
                {
                    foreach (var proc in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(processName)))
                    {
                        proc.Kill();
                    }

                    string blockEntry = $"{startTime:yyyy-MM-dd HH:mm:ss} - BLOCKED {processName}";

                    
                    File.AppendAllText(logPath, blockEntry + Environment.NewLine);

                    File.AppendAllText(moderationLogPath, blockEntry + Environment.NewLine);

                    ProcessLogged?.Invoke(this, blockEntry);
                }
                catch (Exception ex)
                {
                    File.AppendAllText(logPath, $"Error blocking {processName}: {ex.Message}" + Environment.NewLine);
                }
            }
        }

        private bool IsForbidden(string processName)
        {
            foreach (var forbidden in forbiddenProcesses)
            {
                if (string.Equals(processName, forbidden, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }



    }
}

