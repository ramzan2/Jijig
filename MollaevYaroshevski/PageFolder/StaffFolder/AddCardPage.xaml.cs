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
    /// Логика взаимодействия для AddCardPage.xaml
    /// </summary>
    public partial class AddCardPage : Page
    {
        public AddCardPage()
        {
            InitializeComponent();
            ListUserDG.ItemsSource = DBEntities.GetContext().ReaderCardFile.ToList()
                .OrderBy(c => c.IdReader);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListUserDG.ItemsSource = DBEntities.GetContext()
                .ReaderCardFile.Where(u => u.IdReader.ToString()
                .StartsWith(SearchTb.Text))
                .ToList().OrderBy(u => u.IdReader);
            if (ListUserDG.Items.Count <= 0)
            {
                MBClass.ErrorMB("Данные не найдены");
            }
        }
    }
}
