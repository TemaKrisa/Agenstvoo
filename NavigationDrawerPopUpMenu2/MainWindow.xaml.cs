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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myclass.Connect.conOdb = new agentstvoEntities();
            frmMain.Navigate(new UserControlHome() { mainFrame = frmMain });
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ItemHome_Selected(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new UserControlHome());
        }

        private void Otdels_Selected(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new UserControlotdels());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new UserControlZadachi() { mainFrame = frmMain } );
        }

        private void yprSotr_Click(object sender, RoutedEventArgs e)
        {
            //frmMain.Navigate(new pages.sotr());
        }

        private void Zadachi_Selected(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new UserControletaps());
        }

        private void ItemCreate_Selected(object sender, RoutedEventArgs e)
        {
            UserControlCreate userControl = new UserControlCreate() {
                mainFrame = frmMain
            };

            frmMain.Navigate(userControl);
           
        }

        private void Etaps_Selected(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new UserControlZadachi());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myclass.frameobj.frmMain = frmMain;
        }
    }
}
