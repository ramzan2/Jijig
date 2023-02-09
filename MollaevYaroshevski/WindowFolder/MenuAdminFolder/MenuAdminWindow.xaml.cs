using MollaevYaroshevski.ClassFolder;
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
using System.Windows.Shapes;

namespace MollaevYaroshevski.WindowFolder.MenuAdminFolder
{
    /// <summary>
    /// Логика взаимодействия для MenuAdminWindow.xaml
    /// </summary>
    public partial class MenuAdminWindow : Window
    {
        public MenuAdminWindow()
        {
            InitializeComponent();
            MaiFrame.Navigate(new PageFolder.AdminFolder.AddUserPage());
            MaiFrame.Navigate(new PageFolder.AdminFolder.ListUserPage());

        }

        private void ListBookBtn_Click(object sender, RoutedEventArgs e)
        {
            MaiFrame.Navigate(new ListUserPage());
        }

        private void AddBookBtn_Click(object sender, RoutedEventArgs e)
        {
            MaiFrame.Navigate(new AddUserPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MBClass.ExitMB();
        }
    }
}
