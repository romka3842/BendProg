using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendProg
{
    class ovenTray
    {
        protected double _sideNumber { get; set; }
        protected double _sideA { get; set; }
        protected double _sideB { get; set; }
        protected double _board { get; set; }
        protected double _kink { get; set; }
        protected double _angle { get; set; }
        protected double _rad { get; set; }
        protected double _s { get; set; }
        protected double _kfactor { get; set; }
        public double _BA { get; set; }
        protected double _reamerA { get; set; }
        protected double _reamerB { get; set; }
        protected double _cutout { get; set; }        

        public ovenTray(double sideNumber, double sideA, double sideB, double board, double kink, double rad, double s, double angle)
        {
            _sideNumber = sideNumber;
            _sideA = sideA;
            _sideB = sideB;
            _board = board;
            _kink = kink;
            _rad = rad;
            _s = s;
            _angle = angle;
        }

        public ovenTray()
        {
        }

        public double K_factorCalculation()
        {
            double kfactor;
            kfactor = (Math.Log10(_rad / _s) * 0.5) + 0.65;
            return kfactor;
        }
        public double BA_calculation_before90(double kfactor)
        {
            double BA90;
            BA90 = (Math.PI * ((180 - _angle) / 180) * (_rad + ((_s * kfactor) / 2))) - (2 * (_rad + _s));
            return BA90;
        }
        public double BA_calculation_after90(double kfactor)
        {
            double BAaft90;
            BAaft90 = (Math.PI * ((180 - _angle) / 180) * (_rad + ((_s * kfactor) / 2))) - ((2 * (_rad + _s)) * Math.Tan(((180 - _angle) / 2) * Math.PI / 180));
            return BAaft90;
        }

        public virtual double reamerA_Calculation(double kfactor)
        {
            if (_angle <= 90)
            {
                _BA = BA_calculation_before90(kfactor);
            }
            if (_angle > 90 && _angle < 180)
            {
                _BA = BA_calculation_after90(kfactor);
            }

            _reamerA = _sideA - (2 * _s) + (2 * _board) + (2 * _kink) + (2 * _BA);
            return _reamerA;
        }
        public virtual double reamerB_Calculation(double kfactor)
        {
            if (_angle <= 90)
            {
                _BA = BA_calculation_before90(kfactor);
            }
            if (_angle > 90 && _angle < 180)
            {
                _BA = BA_calculation_after90(kfactor);
            }

            _reamerB = _sideB - (2 * _s) + (2 * _board) + (2 * _kink) + (2 * _BA);
            return _reamerB;
        }
        public double cutout_Calculation()
        {
            _cutout = _kink + _board - _s;
            return _cutout;
        }

    }
}
