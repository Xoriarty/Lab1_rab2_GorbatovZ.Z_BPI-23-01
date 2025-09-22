using System.Windows;

namespace Lab1_rab2_GorbatovZ.Z_BPI_23_01
{
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }
        public void SetInfo(string title, string info)
        {
            TitleText.Text = title;
            InfoText.Text = info;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
