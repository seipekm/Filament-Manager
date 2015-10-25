using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filament_Manager.Class
{
    public class JogX
    {
        public string command { get; set; }
        public double x { get; set; }

    }

    public class JogY
    {
        public string command { get; set; }
        public double y { get; set; }

    }

    public class JogZ
    {
        public string command { get; set; }
        public double z { get; set; }

    }

    public class Command
    {
        public string command { get; set; }
    }
}
