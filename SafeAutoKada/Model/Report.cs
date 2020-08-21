using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeAutoKada.Model
{
    public class Report
    {
        public string Name { get; set; }
        public double Miles { get; set; }
        public double MinutesDriven { get; set; }

        public double MilesPerHour { get; set; }
    }
}
