using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_violation
{
    public class BMW : Car
    {
        public BMW(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }

        public override string Sound
        {
            get
            {
                return "Wroom-wroom";
            }
        }

        public override int CalculatePower()
        {
            return 500;
        }
    }
}
