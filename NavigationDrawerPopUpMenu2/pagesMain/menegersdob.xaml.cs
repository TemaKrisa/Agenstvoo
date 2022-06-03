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

namespace NavigationDrawerPopUpMenu2.pagesMain
{
    /// <summary>
    /// Логика взаимодействия для menegersdob.xaml
    /// </summary>
    public partial class menegersdob : Page
    {
        public Frame mainFrame;

        public menegersdob()
        {
            InitializeComponent();
            myclass.Connect.conOdb = new agentstvoEntities();
        }

        private void sohrMenegers_Click(object sender, RoutedEventArgs e)
        {
            using (agentstvoEntities db = new agentstvoEntities())
            {
                Meneger meneger = new Meneger()
                {
                    Imya = ImMen.Text,
                    Familya = FamMen.Text,
                    Otchestvo = OtchMen.Text
                };
                db.Meneger.Add(meneger);
                db.SaveChanges();

            }

           mainFrame.GoBack();
        }

        private void OtchMen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FamMen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ImMen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
