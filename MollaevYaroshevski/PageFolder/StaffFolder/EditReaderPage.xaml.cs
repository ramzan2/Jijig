using MollaevYaroshevski.ClassFolder;
using MollaevYaroshevski.DataFolder;
using MollaevYaroshevski.PageFolder.AdminFolder;
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

namespace MollaevYaroshevski.PageFolder.StaffFolder
{
    /// <summary>
    /// Логика взаимодействия для EditReaderPage.xaml
    /// </summary>
    public partial class EditReaderPage : Page
    {
        public EditReaderPage(Reader reader)
        {
            InitializeComponent();
            DataContext = reader;
            CityCb.ItemsSource = DBEntities.GetContext()
              .City.ToList();
            StreetCb.ItemsSource = DBEntities.GetContext()
              .Street.ToList();
            RegionCb.ItemsSource = DBEntities.GetContext()
              .Region.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {



        }

        private void AddPhoto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
