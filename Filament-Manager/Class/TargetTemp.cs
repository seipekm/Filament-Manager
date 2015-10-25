using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filament_Manager.Class
{
    public class TargetTemp
    {
        public string command { get; set; }
        public targets targets { get; set; }
    }

    public class targets
    {
        public int tool0 { get; set; }
    }
}
