using System;


namespace Lab1_rab2_GorbatovZ.Z_BPI_23_01.Classes
{
    public abstract class Figure
    {
        private string _name;
        public Figure(string name)
        {
            Name = name;
            Console.WriteLine($"Создана фигура: {name}");
        }
        public string Name
        {
            get { return _name; }
            set
            { _name = value; }
        }

        public virtual double CalculateArea()
        {
            Console.WriteLine("Вычисление площади в базовом классе");
            return 0;
        }

        public virtual double CalculatePerimeter()
        {
            Console.WriteLine("Вычисление периметра в базовом классе");
            return 0;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
    }
}
