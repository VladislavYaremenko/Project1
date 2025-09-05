using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Config
    {
        public bool EnableStatistics { get; set; }
        public bool EnableModeration { get; set; }
        public string ReportPath { get; set; }
        public List<string> ForbiddenWords { get; set; } = new List<string>();
        public List<string> ForbiddenApps { get; set; } = new List<string>();
    }
}
