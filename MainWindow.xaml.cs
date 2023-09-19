using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Otopark_Otomasyonu
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click+=Button_Click1;
            btn1.Click+=Btn1_Click;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool renkk = true;
            if (renkk==true)
            {
                btn1.Background = new SolidColorBrush(Color.FromRgb(8, 151, 46));
                renkk=false;
            }
            else if (renkk==false)
            {
                btn1.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
