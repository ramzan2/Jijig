using Microsoft.Win32;
using MollaevYaroshevski.ClassFolder;
using MollaevYaroshevski.DataFolder;
using MollaevYaroshevski.PageFolder.AdminFolder;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для AddReaderPage.xaml
    /// </summary>
    public partial class AddReaderPage : Page
    {
        Address address = new Address();
        Reader reader=new Reader();

        string selectedFileName = "";
        public AddReaderPage()
        {
            InitializeComponent();
            CityCb.ItemsSource = DBEntities.GetContext()
             .City.ToList();
            StreetCb.ItemsSource = DBEntities.GetContext()
              .Street.ToList();
            RegionCb.ItemsSource = DBEntities.GetContext()
              .Region.ToList();
        }
        private void AddressAdd()
        {
            var addressAdd = new Address()
            {
                IdRegion = Int32.Parse(RegionCb.SelectedValue.ToString()),
                IdCity = Int32.Parse(CityCb.SelectedValue.ToString()),
                IdStreet = Int32.Parse(StreetCb.SelectedValue.ToString()),
                House = Int32.Parse(HouseTb.Text),
                Housing = HousingTb.Text,
                Flat = Int32.Parse(FlatTb.Text),
            };
            DBEntities.GetContext().Address.Add(addressAdd);
            DBEntities.GetContext().SaveChanges();
            address.IdAddress = addressAdd.IdAddress;
        }
        private void ReaderAdd()
        {
            var readerAdd = new Reader()
            {
                UniqueNumberReaderCard = UniqueNumberReaderCardTb.Text,
                LastNameReader = LastNameReaderTb.Text,
                FirstNameReader = FirstNameReaderTb.Text,
                MiddleNameReader = MiddleNameReaderTb.Text,
                NumberPhone = NumberPhoneTb.Text,
                HomePhone = HomePhoneTb.Text,
                DateOfBirth = DateTime.Parse(DateOfBirthDP.Text),
                IdAddress = address.IdAddress,
                PhotoReader = ImageClass.ConvertImageToByteArray(selectedFileName)
            };
            DBEntities.GetContext().Reader.Add(readerAdd);
            DBEntities.GetContext().SaveChanges();
        }
        private void AddPhoto1()
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.InitialDirectory = "";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png| " +
                    "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg| " +
                    "Portable Network Graphic (*.png)|*.png";
                if (op.ShowDialog() == true)
                {
                    selectedFileName = op.FileName;
                    reader.PhotoReader = ImageClass.ConvertImageToByteArray(selectedFileName);
                    PhotoIM.Source = ImageClass.ConvertByteArrayToImage(reader.PhotoReader);
                }
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
        }

        private void PhotoIM_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void AddPhoto_Click(object sender, RoutedEventArgs e)
        {
           AddPhoto1();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddressAdd();
                ReaderAdd();

                MBClass.InfoMB("Читатель добавлен");
                NavigationService.Navigate(new ListReaderPage1());
            }
            catch (DbEntityValidationException ex)
            {
                MBClass.ErrorMB(ex);
            }
        }
    }
}
