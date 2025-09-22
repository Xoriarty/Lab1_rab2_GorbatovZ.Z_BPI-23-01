using System;
namespace Lab1_rab2_GorbatovZ.Z_BPI_23_01.Classes
{
    public class Ellipse : Figure
    {
        private double _semiMajorAxis;
        private double _semiMinorAxis;
        public Ellipse(double semiMajorAxis, double semiMinorAxis)
            : base("Эллипс")
        {
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
        }

        public double SemiMajorAxis
        {
            get { return _semiMajorAxis; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Большая полуось должна быть положительным числом");
                _semiMajorAxis = value;
            }
        }

        public double SemiMinorAxis
        {
            get { return _semiMinorAxis; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Малая полуось должна быть положительным числом");
                _semiMinorAxis = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }

        public override double CalculatePerimeter()
        {
            double h = Math.Pow((SemiMajorAxis - SemiMinorAxis), 2) / Math.Pow((SemiMajorAxis + SemiMinorAxis), 2);
            return Math.PI * (SemiMajorAxis + SemiMinorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Полуоси: {SemiMajorAxis} и {SemiMinorAxis}");
            Console.WriteLine($"Площадь: {CalculateArea():F2}");
            Console.WriteLine($"Периметр (приближенно): {CalculatePerimeter():F2}");
        }
    }
}
