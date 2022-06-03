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

namespace NavigationDrawerPopUpMenu2.pages
{
    /// <summary>
    /// Логика взаимодействия для sotr.xaml
    /// </summary>
    public partial class sotr : Page
    {

        public Frame mainFrame;

        public sotr()
        {
            InitializeComponent();
            myclass.Connect.conOdb = new agentstvoEntities();
        }

        private void ImSotrp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FamSotrp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OtchSotrp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SotrRed_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void ImSotrpa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FamSotrpa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OtchSotrpa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (agentstvoEntities db = new agentstvoEntities())
            {
                Sotrydniki sotrydniki = new Sotrydniki()
                {
                    Imya = ImSotrpa.Text,
                    Familia = FamSotrpa.Text,
                    Otchestvo = OtchSotrpa.Text
                };
                db.Sotrydniki.Add(sotrydniki);
                db.SaveChanges();

               
            }

            mainFrame.GoBack();
        }
    }
}
