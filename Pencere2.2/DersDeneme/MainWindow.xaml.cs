using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace DersDeneme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Sadece sayısal giriş yapılabilmesi için textbox elementine atanaccak event
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        float turk=0, mat=0, sos=0, fen=0;


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 yeni = new Window1();
            Net dnm =new Net();

            if (t_yanlis.Text != "" && m_yanlis.Text != "" && s_yanlis.Text != "" && f_yanlis.Text != "")
            {

                //Netlerin hesaplanması ve pencereye yönlendirilmesi
                turk = Convert.ToSingle(t_yanlis.Text) / 4;
                turk = Convert.ToSingle(t_dogru.Text) - turk;
                dnm.Tnet = turk;

                sos = Convert.ToSingle(s_yanlis.Text) / 4;
                sos = Convert.ToSingle(s_dogru.Text) - sos;
                dnm.Snet = sos;

                mat = Convert.ToSingle(m_yanlis.Text) / 4;
                mat = Convert.ToSingle(m_dogru.Text) - mat;
                dnm.Mnet = mat;

                fen = Convert.ToSingle(f_yanlis.Text) / 4;
                fen = Convert.ToSingle(f_dogru.Text) - fen;
                dnm.Fnet = fen;

                App.net1 = dnm;
                yeni.Show();

            }

            else MessageBox.Show("Alanların hepsini doldurunuz");

        }
    }
}
