using MollaevYaroshevski.ClassFolder;
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

namespace MollaevYaroshevski.WindowFolder.MenuStaffFolder
{
    /// <summary>
    /// Логика взаимодействия для MainStaffWindow.xaml
    /// </summary>
    public partial class MainStaffWindow : Window
    {
        public MainStaffWindow()
        {
            InitializeComponent();
            MaiFrame.Navigate(new PageFolder.StaffFolder.AddReaderPage());
            MaiFrame.Navigate(new PageFolder.StaffFolder.ListReaderPage1());
        }

        private void ListBookBtn_Click(object sender, RoutedEventArgs e)
        {
            MaiFrame.Navigate(new PageFolder.StaffFolder.ListReaderPage1());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void AddReaderBtn_Click(object sender, RoutedEventArgs e)
        {
            MaiFrame.Navigate(new PageFolder.StaffFolder.AddReaderPage());
        }

 
        private void ListBooCBtn_Click(object sender, RoutedEventArgs e)
        {
            MaiFrame.Navigate(new PageFolder.StaffFolder.ListBookPage());
        }
    }
}
