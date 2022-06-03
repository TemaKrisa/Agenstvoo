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
    /// Interação lógica para UserControlCreate.xam
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        public Frame mainFrame;
     
        agentstvoEntities dc = new agentstvoEntities();
     
             
        public UserControlCreate()
        {
            InitializeComponent();

            agentstvoEntities db = new agentstvoEntities();
            DGridAgenstvo.ItemsSource = db.Meneger.ToList();
            //framesotr.Navigate(new pages.sotr());
            //DataContext = new GridMain ();

            Updater();
        }

        public void Updater()
        {
            DGridAgenstvo.ItemsSource = dc.Meneger.ToList();
        }


        private void addUserControl(dobavitsotr userControl)
        {
            
            GridMain.Children.Clear();
            GridMain.Children.Add(userControl);


        }




        private void BtnEditSotryd_Click(object sender, RoutedEventArgs e)
        {
            //var dobavitsotr = new dobavitsotr();
            //dobavitsotr.Show();

            //sotrydniki_dob us = new sotrydniki_dob();
            //addUserControl(us);


        }

        private void AddMen_Click(object sender, RoutedEventArgs e)
        {
            pages.sotr page = new pages.sotr() { mainFrame = this.mainFrame };
            mainFrame.Navigate(page);

        }

        private void DelateMen_Click(object sender, RoutedEventArgs e)
        {
            //var agenstvoForRemoving = DGridAgenstvo.SelectedItems.Cast<Meneger>().ToList();
            ////int a = dataGrid

            //if (MessageBox.Show($"Вы точно хотите удалить следующее {agenstvoForRemoving.Count()} элементов?", "Внимание"
            //    , MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    try
            //    {

            //    }

            //    catch (Exception ex)
            //    {

            //    }
            //}

            agentstvoEntities db = new agentstvoEntities();



            if (DGridAgenstvo.SelectedItem != null)
            {
                NavigationDrawerPopUpMenu2.Meneger m1 = (Meneger)DGridAgenstvo.SelectedItem;
                var mm = db.Meneger.SingleOrDefault(u => u.IdMeneger == m1.IdMeneger);
                if (mm != null)
                {
                    db.Meneger.Remove(mm);
                    db.SaveChanges();
                    Updater();
                }
            }


        }

        private void BtnDeleteMen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteMen_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
