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
    /// Логика взаимодействия для zadachidob.xaml
    /// </summary>
    public partial class zadachidob : Page
    {
        public Frame mainFrame;

        public zadachidob()
        {
            InitializeComponent();
            myclass.Connect.conOdb = new agentstvoEntities();
        }

        private void sohrZadach_Click(object sender, RoutedEventArgs e)
        {
            using (agentstvoEntities db = new agentstvoEntities())
            {
                Zadacha zadacha = new Zadacha()
                {
                    naimenovanie = namezadach.Text,
                    SrokVipl = SrokViplZadachi.SelectedDate,
                    DataPost = DataPostavkiZadachi.SelectedDate
                };
                db.Zadacha.Add(zadacha);
                db.SaveChanges();

            }

            myclass.frameobj.frmMain.GoBack();
        }

        private void namezadach_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
