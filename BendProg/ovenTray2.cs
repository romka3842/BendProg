using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendProg
{
    class ovenTray2: ovenTray
    {
        public ovenTray2(double sideNumber, double sideA, double sideB, double board, double kink, double rad, double s, double angle) : base(sideNumber, sideA, sideB, board, kink, rad, s, angle)
        {

        }
        public override double reamerA_Calculation(double kfactor)
        {
            if (_angle <= 90)
            {
                _BA = BA_calculation_before90(kfactor);
            }
            if (_angle > 90 && _angle < 180)
            {
                _BA = BA_calculation_after90(kfactor);
            }

            _reamerA = _sideA; //- _s + _board + _kink + _BA;
            return _reamerA;
        }

        public override double reamerB_Calculation(double kfactor)
        {
            return base.reamerB_Calculation(kfactor);
        }
    }
}
