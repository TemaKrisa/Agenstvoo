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
using System.Windows.Shapes;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Логика взаимодействия для dobavitsotr.xaml
    /// </summary>
    public partial class dobavitsotr : Window
    {
        private agentstvoEntities agentstvo = null;
        public dobavitsotr()
        {
            InitializeComponent();
            myclass.Connect.conOdb = new agentstvoEntities();
        }

        private void ImSotr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FamSotr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OtchSotr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
