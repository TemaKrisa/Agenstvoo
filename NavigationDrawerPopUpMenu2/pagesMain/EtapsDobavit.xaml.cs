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
    /// Логика взаимодействия для EtapsDobavit.xaml
    /// </summary>
    public partial class EtapsDobavit : Page
    {
        public EtapsDobavit()
        {
            InitializeComponent();
            myclass.Connect.conOdb = new agentstvoEntities();
        }

        private void sohrEtap_Click(object sender, RoutedEventArgs e)
        {
            using (agentstvoEntities db = new agentstvoEntities())
            {

                Sotrydniki otdm = db.Sotrydniki.Where(a => a.Familia == SotrVibrOtd.Text).FirstOrDefault();
                Zadacha otd = db.Zadacha.Where(a => a.naimenovanie == naimZadachOt.Text).FirstOrDefault();
                Etap etap = new Etap()
                {
                    naimenovanieEtap = ImOt.Text,
                    DataNachala = DataNachalaOt.SelectedDate,
                    Vajnost = vajnost.Text,
                    StepenGotovnosti = Convert.ToInt32(stepengot.Text),
                    ObimRabot = ObmRabot.Text,
                    Otvetstvenniy = otdm.IdSotr,
                    zadacha =  otd.Idzadacha
                };
                db.Etap.Add(etap);
                db.SaveChanges();

            }

            myclass.frameobj.frmMain.GoBack();
        }

        private void ImOt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (agentstvoEntities db = new agentstvoEntities())
            {
                naimZadachOt.ItemsSource = db.Zadacha.ToList();
                SotrVibrOtd.ItemsSource = db.Sotrydniki.ToList();

            }

        }
    }
}
