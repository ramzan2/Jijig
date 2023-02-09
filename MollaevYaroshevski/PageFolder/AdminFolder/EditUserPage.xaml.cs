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
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        public EditUserPage(User user)
        {
            InitializeComponent();
            DataContext = user;
            RoleCb.ItemsSource = DBEntities.GetContext()
              .Role.ToList();
        }
        private void EditBtn_Click_1(object sender, RoutedEventArgs e)
        {
            User user = DBEntities.GetContext().User.
               FirstOrDefault(s => s.IdUser == VariableClass.UserId);
            user.IdRole = Int32.Parse(RoleCb.SelectedValue.ToString());
            user.Login = LoginTb.Text;
            user.Password = PasswordTb.Text;
            DBEntities.GetContext().SaveChanges();
            MBClass.InfoMB("Поользователь успешно отредактирован");
            NavigationService.Navigate(new ListUserPage());
        }
    }
}
