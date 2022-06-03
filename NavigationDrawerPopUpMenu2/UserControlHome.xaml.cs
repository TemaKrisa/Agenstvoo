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
using System.Data.Entity;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Interação lógica para UserControlHome.xam
    /// </summary>
    public partial class UserControlHome : UserControl
    {
        public Frame mainFrame;
        agentstvoEntities db = new agentstvoEntities();

        public UserControlHome()
        {
            InitializeComponent();
            Updater();
                }

        public void Updater() 
        {
            DGridAgenstvo.ItemsSource = db.Sotrydniki.ToList();
        }

        private void BtnEditMeneger_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGridAgenstvo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddSotr_Click(object sender, RoutedEventArgs e)
        {
            //pagesMain.menegersdob page = new pagesMain.menegersdob() { mainFrame = this.mainFrame };
            mainFrame.Navigate(new pagesMain.menegersdob() { mainFrame = mainFrame });
        }

        private void BtnDellMeneger_Click(object sender, RoutedEventArgs e)
        {
            //agentstvoEntities db = new agentstvoEntities();

            //if (DGridAgenstvo.SelectedItem != null)
            //{
            //    NavigationDrawerPopUpMenu2.Sotrydniki s1 = (Sotrydniki)DGridAgenstvo.SelectedItem;
            //    var ss = db.Sotrydniki.SingleOrDefault(u => u.IdSotr == s1.IdSotr);
            //    if (ss != null)
            //    {
            //        db.Sotrydniki.Remove(ss);
            //        db.SaveChanges();
            //        Updater();
            //    }
            //}
        }
        //    agentstvoEntities db = new agentstvoEntities();

        //    int r = DGridAgenstvo.SelectedIndex;
        //    string imya = null;
        //    string otch = null;
        //    string fam;

        //    for (int i = 0; i < 2;)
        //    {
        //        switch (i)
        //        {
        //            case 1:
        //                TextBlock itemr = DGridAgenstvo.Columns[i].GetCellContent(DGridAgenstvo.Items[r]) as TextBlock;
        //                otch = itemr.Text;
        //                break;

        //        }
        //        i++;
        //    }

        //    if (imya == null)
        //    {
        //        MessageBox.Show("безда");
        //    }


        //    Sotrydniki sotrydniki = db.Sotrydniki.Where(p => p.Otchestvo == otch).FirstOrDefault();
        //    if (sotrydniki == null)
        //    {
        //        MessageBox.Show("безда2");
        //    }
        //    db.Entry(sotrydniki).State = EntityState.Deleted;
        //    db.SaveChanges();

        //    if (MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes
        //        )
        //    {
        //        var sotryd = DGridAgenstvo.SelectedItem as Sotrydniki;

        //    }

        //}

        private void DGridAgenstvo_Loaded(object sender, RoutedEventArgs e)
        {


        }

        private void DelateSot_Click(object sender, RoutedEventArgs e)
        {
            agentstvoEntities db = new agentstvoEntities();

            if (DGridAgenstvo.SelectedItem != null)
            {
                NavigationDrawerPopUpMenu2.Sotrydniki s1 = (Sotrydniki)DGridAgenstvo.SelectedItem;
                var ss = db.Sotrydniki.SingleOrDefault(u => u.IdSotr == s1.IdSotr);
                if(ss != null)
                {
                    db.Sotrydniki.Remove(ss);
                    db.SaveChanges();
                    Updater();
                }
            }
        }
    }
}
