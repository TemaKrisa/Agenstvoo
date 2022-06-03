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

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Логика взаимодействия для UserControlZadachi.xaml
    /// </summary>


    public partial class UserControlZadachi : UserControl
    {
        agentstvoEntities dc = new agentstvoEntities();

        public Frame mainFrame;

        public UserControlZadachi()
        {
            InitializeComponent();
            agentstvoEntities db = new agentstvoEntities();
            DGridAgenstvo.ItemsSource = db.Zadacha.ToList();
            Updater();
        }

        public void Updater()
        {
            DGridAgenstvo.ItemsSource = dc.Zadacha.ToList();
        }

        private void BtnEditZadachi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddZadachi_Click(object sender, RoutedEventArgs e)
        {
            myclass.frameobj.frmMain.Navigate(new pagesMain.zadachidob());
        }

        private void DelateZadachi_Click(object sender, RoutedEventArgs e)
        {
            agentstvoEntities db = new agentstvoEntities();

            if (DGridAgenstvo.SelectedItem != null)
            {
                NavigationDrawerPopUpMenu2.Zadacha e1 = (Zadacha)DGridAgenstvo.SelectedItem;
                var ee = db.Zadacha.SingleOrDefault(u => u.Idzadacha == e1.Idzadacha);
                if (ee != null)
                {
                    db.Zadacha.Remove(ee);
                    db.SaveChanges();
                    Updater();
                }
            }
        }
    }
}
