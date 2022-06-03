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
    /// Логика взаимодействия для OtdelsDobavit.xaml
    /// </summary>
    public partial class OtdelsDobavit : Page
    {
        public OtdelsDobavit()
        {
            InitializeComponent();
        }

        private void ImOt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (agentstvoEntities db = new agentstvoEntities())
            {

                SotrVibr.ItemsSource = db.Sotrydniki.ToList();

                MenVibr.ItemsSource = db.Meneger.ToList();

                naimZadach.ItemsSource = db.Zadacha.ToList();
            }
        }

        private void sohrOtdel_Click(object sender, RoutedEventArgs e)
        {
            using (agentstvoEntities db = new agentstvoEntities())
            {
                Zadacha otd = db.Zadacha.Where(a => a.naimenovanie == naimZadach.Text).FirstOrDefault();
                Meneger otds = db.Meneger.Where(a => a.Familya == MenVibr.Text).FirstOrDefault();
                Sotrydniki otdm = db.Sotrydniki.Where(a => a.Familia == SotrVibr.Text).FirstOrDefault();
                Otdel otdel = new Otdel()
                {
                    naimenovanie = ImOt.Text,
                    SotrydnikiId = otdm.IdSotr,
                    menegerid = otds.IdMeneger,
                    ZadachaID = otd.Idzadacha
                };
                db.Otdel.Add(otdel);
                db.SaveChanges();

            }

            myclass.frameobj.frmMain.GoBack();
        }
    }
}
