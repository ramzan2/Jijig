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
    /// Логика взаимодействия для ListReaderPage1.xaml
    /// </summary>
    public partial class ListReaderPage1 : Page
    {
        public ListReaderPage1()
        {
            InitializeComponent();
            ListReaderLB.ItemsSource = DBEntities.GetContext().Reader.ToList()
                .OrderBy(c => c.IdReader);
        }

        private void Ref()
        {
            ListReaderLB.ItemsSource = DBEntities.GetContext().City.ToList()
                .OrderBy(c => c.IdCity);
            ListReaderLB.ItemsSource = DBEntities.GetContext().Street.ToList()
                .OrderBy(c => c.IdStreet);
            ListReaderLB.ItemsSource = DBEntities.GetContext().Region.ToList()
                .OrderBy(c => c.IdRegion);
        }

        private void SeechTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListReaderLB.ItemsSource = DBEntities.GetContext()
               .Reader.Where(u => u.LastNameReader
               .StartsWith(SeechTb.Text))
               .ToList().OrderBy(u => u.LastNameReader);
            if (ListReaderLB.Items.Count <= 0)
            {
                MBClass.ErrorMB("Данные не найдены");
            }
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            if (ListReaderLB.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите " +
                    "пользователя для редактирования");

            }
            else
            {
                Reader reader = ListReaderLB.SelectedItem as Reader;
                VariableClass.ReaderId = reader.IdReader;
                this.NavigationService.Navigate(new EditReaderPage(ListReaderLB.SelectedItem as Reader));
                Ref();
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            Reader reader = ListReaderLB.SelectedItem as Reader;
            if (ListReaderLB.SelectedItem == null)
            {
                MBClass.ErrorMB("");
            }
            else
            {
                if (MBClass.QuestionMB("Удалить " +
                    $"пользователя с логином " +
                    $"{reader.LastNameReader}?"))
                {
                    DBEntities.GetContext().Reader
                        .Remove(ListReaderLB.SelectedItem as Reader);
                    DBEntities.GetContext().SaveChanges();

                    MBClass.InfoMB("Пользователя удален");
                    ListReaderLB.ItemsSource = DBEntities.GetContext()
                        .Reader.ToList().OrderBy(u => u.LastNameReader);
                }
            }
        }

        private void ListReaderLB_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PageFolder.StaffFolder.AddCardPage());
        }
    }
}
