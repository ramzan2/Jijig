using MollaevYaroshevski.ClassFolder;
using MollaevYaroshevski.DataFolder;
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
    /// Логика взаимодействия для ListInstancePage.xaml
    /// </summary>
    public partial class ListInstancePage : Page
    {
        public ListInstancePage()
        {
            InitializeComponent();
            ListUserDG.ItemsSource = DBEntities.GetContext().Instance.ToList()
               .OrderBy(c => c.IdInstance);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListUserDG.ItemsSource = DBEntities.GetContext()
              .Instance.Where(u => u.UniqueChipher
              .StartsWith(SearchTb.Text))
              .ToList().OrderBy(u => u.UniqueChipher);
            if (ListUserDG.Items.Count <= 0)
            {
                MBClass.ErrorMB("Данные не найдены");
            }
        }

        private void ListUserDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
