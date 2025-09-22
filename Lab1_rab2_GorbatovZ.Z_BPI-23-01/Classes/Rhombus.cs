using System;

namespace Lab1_rab2_GorbatovZ.Z_BPI_23_01.Classes
{
    public class Rhombus : Figure
    {
        private double _side;
        private double _diagonal1;
        private double _diagonal2;

        public Rhombus(double side, double diagonal1, double diagonal2)
            : base("Ромб")
        {
            Side = side;
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public double Side
        {
            get { return _side; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона должна быть положительным числом");
                _side = value;
            }
        }

        public double Diagonal1
        {
            get { return _diagonal1; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Диагональ должна быть положительным числом");
                _diagonal1 = value;
            }
        }

        public double Diagonal2
        {
            get { return _diagonal2; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Диагональ должна быть положительным числом");
                _diagonal2 = value;
            }
        }

  
        public override double CalculateArea()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }

        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Сторона: {Side}, Диагонали: {Diagonal1} и {Diagonal2}");
            Console.WriteLine($"Площадь: {CalculateArea():F2}");
            Console.WriteLine($"Периметр: {CalculatePerimeter():F2}");
        }
    }
}
