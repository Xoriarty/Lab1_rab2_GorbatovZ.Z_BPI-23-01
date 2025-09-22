using System;
namespace Lab1_rab2_GorbatovZ.Z_BPI_23_01.Classes
{
    public class Parallelepiped : Figure
    {
        private double _length;
        private double _width;
        private double _height;

        public Parallelepiped(double length, double width, double height)
            : base("Параллелепипед") 
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длина должна быть положительным числом");
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ширина должна быть положительным числом");
                _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Высота должна быть положительным числом");
                _height = value;
            }
        }

        public override double CalculateArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        public override double CalculatePerimeter()
        {
            return 4 * (Length + Width + Height);
        }



        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размеры: {Length} x {Width} x {Height}");
            Console.WriteLine($"Площадь поверхности: {CalculateArea():F2}");
            Console.WriteLine($"Сумма длин ребер: {CalculatePerimeter():F2}");
        }
    }
}
