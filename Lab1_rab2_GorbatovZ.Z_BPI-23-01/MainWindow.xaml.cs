using Lab1_rab2_GorbatovZ.Z_BPI_23_01.Classes;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab1_rab2_GorbatovZ.Z_BPI_23_01
{

    public partial class MainWindow : Window
    {
        private int figure;
        public MainWindow()
        {
            InitializeComponent();
            figure = 0;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            e.Handled = !regex.IsMatch(e.Text);
        }


        private void Rhombus_Checked(object sender, RoutedEventArgs e)
        {
            lbl3.Visibility = Visibility.Visible;
            textBox3.Visibility = Visibility.Visible;
            lbl1.Content = "Первая диагональ ромба:";
            lbl2.Content = "Вторая диагональ ромба:";
            lbl3.Content = "Сторона ромба:";
            GetInfo.Visibility = Visibility.Visible;
            figure = 0;
        }

        private void Parallelepiped_Checked(object sender, RoutedEventArgs e)
        {
            lbl3.Visibility = Visibility.Visible;
            textBox3.Visibility = Visibility.Visible;
            lbl1.Content = "Длина параллелепипеда:";
            lbl2.Content = "Ширина параллелепипеда:";
            lbl3.Content = "Высота параллелепипеда:";
            GetInfo.Visibility = Visibility.Visible;
            figure = 1;
        }

        private void Ellipse_Checked(object sender, RoutedEventArgs e)
        {
            lbl3.Visibility = Visibility.Collapsed;
            textBox3.Visibility = Visibility.Collapsed;
            lbl1.Content = "Малая полуось эллипса:";
            lbl2.Content = "Большая полуось эллипса:";
            GetInfo.Visibility = Visibility.Visible;
            figure = 2;

        }

        private void GetInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string info = "";
                string title = "";

                switch (figure)
                {
                    case 0:
                        double diagonal1 = double.Parse(textBox1.Text);
                        double diagonal2 = double.Parse(textBox2.Text);
                        double side = double.Parse(textBox3.Text);

                        Rhombus rhombus = new Rhombus(side, diagonal1, diagonal2);
                        title = "Информация о ромбе";
                        info = $"Сторона: {side:F2}\n" +
                               $"Диагонали: {diagonal1:F2} и {diagonal2:F2}\n" +
                               $"Площадь: {rhombus.CalculateArea():F2}\n" +
                               $"Периметр: {rhombus.CalculatePerimeter():F2}";
                        break;

                    case 1: 
                        double length = double.Parse(textBox1.Text);
                        double width = double.Parse(textBox2.Text);
                        double height = double.Parse(textBox3.Text);

                        Parallelepiped parallelepiped = new Parallelepiped(length, width, height);
                        title = "Информация о параллелепипеде";
                        info = $"Размеры: {length:F2} × {width:F2} × {height:F2}\n" +
                               $"Площадь поверхности: {parallelepiped.CalculateArea():F2}\n" +
                               $"Сумма длин рёбер: {parallelepiped.CalculatePerimeter():F2}\n";
                        break;

                    case 2: 
                        double semiMinor = double.Parse(textBox1.Text);
                        double semiMajor = double.Parse(textBox2.Text);

                        Ellipse ellipse = new Ellipse(semiMajor, semiMinor);
                        title = "Информация об эллипсе";
                        info = $"Полуоси: {semiMinor:F2} (малая) и {semiMajor:F2} (большая)\n" +
                               $"Площадь: {ellipse.CalculateArea():F2}\n" +
                               $"Периметр (приближённо): {ellipse.CalculatePerimeter():F2}";
                        break;
                }

                InfoWindow infoWindow = new InfoWindow();
                infoWindow.SetInfo(title, info);
                infoWindow.Owner = this;
                infoWindow.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
