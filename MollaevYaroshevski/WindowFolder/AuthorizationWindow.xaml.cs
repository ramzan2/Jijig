using MollaevYaroshevski.ClassFolder;
using MollaevYaroshevski.DataFolder;
using MollaevYaroshevski.WindowFolder.MenuAdminFolder;
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

namespace MollaevYaroshevski.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTB.Text))
            {
                MBClass.ErrorMB("Введите логин");
                LoginTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PasswordPB.Password))
            {
                MBClass.ErrorMB("Введите пароль");
                PasswordPB.Focus();
            }
            else
            {
                try
                {
                    var user= DBEntities.GetContext()
                        .User.FirstOrDefault(u=>u.Login==LoginTB.Text);
                    if (user == null)
                    {
                        MBClass.ErrorMB("Пользователь не найден");
                        LoginTB.Focus();
                        return;
                    }
                    if (user.Password != PasswordPB.Password)
                    {
                        MBClass.ErrorMB("Введен неправильный пароль");
                        PasswordPB.Focus();
                        return;
                    }
                    else
                    {
                        switch (user.IdRole)
                        {
                            case 1:
                                MBClass.InfoMB("Администратор системы");
                                new MenuAdminWindow().ShowDialog();
                                break;
                                case 2:
                                MBClass.InfoMB("Сотрудник");
                                break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new RegistrationWindow().ShowDialog();
        }
    }
}
