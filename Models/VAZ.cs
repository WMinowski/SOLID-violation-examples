using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_violation
{
    public class VAZ : Car
    {
        public VAZ(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }

        public override string Sound
        {
            get
            {
                return "I can`t start";
            }
        }

        public override int CalculatePower()
        {
            return 65;
        }
    }
}
