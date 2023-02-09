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

namespace MollaevYaroshevski.PageFolder.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для ListUserPage.xaml
    /// </summary>
    public partial class ListUserPage : Page
    {
        public ListUserPage()
        {
            InitializeComponent();
            ListUserDG.ItemsSource = DBEntities.GetContext().User.ToList()
                .OrderBy(c => c.IdUser);
        }

        private void Ref()
        {
            ListUserDG.ItemsSource = DBEntities.GetContext().Role.ToList()
                .OrderBy(c => c.IdRole);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListUserDG.ItemsSource=DBEntities.GetContext()
                .User.Where(u=>u.Login
                .StartsWith(SearchTb.Text))
                .ToList().OrderBy(u=>u.Login);
            if (ListUserDG.Items.Count<=0)
            {
                MBClass.ErrorMB("Данные не найдены");
            }
        }

        private void ListBookDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            if (ListUserDG.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите " +
                    "пользователя для редактирования");

            }
            else
            {
                User user = ListUserDG.SelectedItem as User;
                VariableClass.UserId = user.IdUser;
                this.NavigationService.Navigate(new EditUserPage(ListUserDG.SelectedItem as User));
                Ref();
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            User user=ListUserDG.SelectedItem as User;
            if (ListUserDG.SelectedItem == null)
            {
                MBClass.ErrorMB("");
            }
            else
            {
                if (MBClass.QuestionMB("Удалить " +
                    $"пользователя с логином " +
                    $"{user.Login}?"))
                {
                    DBEntities.GetContext().User
                        .Remove(ListUserDG.SelectedItem as User);
                    DBEntities.GetContext().SaveChanges();

                    MBClass.InfoMB("Пользователя удален");
                    ListUserDG.ItemsSource=DBEntities.GetContext()
                        .User.ToList().OrderBy(u=>u.Login);
                }
            }
        }
    }
}
