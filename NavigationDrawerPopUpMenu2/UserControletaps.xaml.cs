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
    /// Логика взаимодействия для UserControletaps.xaml
    /// </summary>
    public partial class UserControletaps : UserControl
    {
        agentstvoEntities ds = new agentstvoEntities();

        public UserControletaps()
        {
            InitializeComponent();
            agentstvoEntities db = new agentstvoEntities();
            DGridAgenstvo.ItemsSource = db.Etap.ToList();
            Updater();
        }

        public void Updater()
        {
            DGridAgenstvo.ItemsSource = ds.Etap.ToList();
        }
        private void BtnEditEtaps_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddEtaps_Click(object sender, RoutedEventArgs e)
        {
            myclass.frameobj.frmMain.Navigate(new pagesMain.EtapsDobavit());
        }

        private void DelateEtaps_Click(object sender, RoutedEventArgs e)
        {
            agentstvoEntities db = new agentstvoEntities();

            if (DGridAgenstvo.SelectedItem != null)
            {
                NavigationDrawerPopUpMenu2.Etap e1 = (Etap)DGridAgenstvo.SelectedItem;
                var ee = db.Etap.SingleOrDefault(u => u.IdEtap == e1.IdEtap);
                if (ee != null)
                {
                    db.Etap.Remove(ee);
                    db.SaveChanges();
                    Updater();
                }
            }
        }
    }
}
