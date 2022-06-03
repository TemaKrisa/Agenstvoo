using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Логика взаимодействия для UserControlotdels.xaml
    /// </summary>
    public partial class UserControlotdels : UserControl
    {
        agentstvoEntities dc = new agentstvoEntities();

        public UserControlotdels()
        {
            InitializeComponent();
            agentstvoEntities db = new agentstvoEntities();
            DGridAgenstvo.ItemsSource = db.Otdel.ToList();
            Updater();
        }
        public void Updater()
        {
            DGridAgenstvo.ItemsSource = dc.Otdel.ToList();
        }
        private void BtnEditOtdel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myclass.frameobj.frmMain.Navigate(new pagesMain.OtdelsDobavit());
        }

        private void DGridAgenstvo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DelateSot_Click(object sender, RoutedEventArgs e)
        {
            agentstvoEntities db = new agentstvoEntities();

            if (DGridAgenstvo.SelectedItem != null)
            {
                NavigationDrawerPopUpMenu2.Otdel e1 = (Otdel)DGridAgenstvo.SelectedItem;
                var ee = db.Otdel.SingleOrDefault(u => u.IdOtdel == e1.IdOtdel);
                if (ee != null)
                {
                    db.Otdel.Remove(ee);
                    db.SaveChanges();
                    Updater();
                }
            }
        }
    }
}
