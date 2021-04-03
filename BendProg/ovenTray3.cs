using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendProg
{
    class ovenTray3 : ovenTray
    {
        public ovenTray3() : base()
        {

        }
        public override double reamerA_Calculation(double kfactor)
        {
            return base.reamerA_Calculation(kfactor);
        }

        public override double reamerB_Calculation(double kfactor)
        {
            return base.reamerB_Calculation(kfactor);
        }
    }
}
