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
using System.Windows.Shapes;

namespace DersDeneme
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            t1.Text = App.net1.Tnet.ToString();
            t2.Text = App.net1.Snet.ToString();
            t3.Text = App.net1.Mnet.ToString();
            t4.Text = App.net1.Fnet.ToString();
        }
    }
}
