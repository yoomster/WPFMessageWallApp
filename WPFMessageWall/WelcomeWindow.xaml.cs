using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPFMessageWallLibrary;

namespace WPFMessageWall
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public WelcomeWindow()
        {
            InitializeComponent();
            addressesList.ItemsSource= addresses;
        }


        private void savePersonButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameText.Text) || string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                MessageBox.Show($"incorrect enty, plz fill both names");
            }
            else
            {
                MessageBox.Show($"Hi {firstNameText.Text} {lastNameText.Text}");

                MainWindow form2 = new();
                form2.Show();
            }
        }

        private void addAddressButton_Click(object sender, RoutedEventArgs e)
        {
            AddAddressForm form3 = new AddAddressForm(this);
            form3.Show();
        }

        public void SaveAddres(AddressModel address)
        {
            addresses.Add(address);
        }
    }

}