using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
    /// Interaction logic for AddAddressForm.xaml
    /// </summary>
    public partial class AddAddressForm : Window
    {
        ISaveAddress _parent;
        public AddAddressForm(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;   
        }

        private void addAdressButon_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(streetNameText.Text) || string.IsNullOrWhiteSpace(houseNrText.Text) || string.IsNullOrWhiteSpace(postcodeText.Text) || string.IsNullOrWhiteSpace(cityText.Text) || string.IsNullOrWhiteSpace(countryText.Text))
            {
                MessageBox.Show("Incorrect entry, plz enter both names",
                                    "Blank Name Field", MessageBoxButton.OK);
            }
            else
            {
                AddressModel address = new AddressModel
                {
                    StreetName = streetNameText.Text,
                    HouseNr = houseNrText.Text,
                    PostCode = postcodeText.Text,
                    City = cityText.Text,
                    Country = countryText.Text
                };

                _parent.SaveAddres(address);

                this.Close();
            }
        }
    }
}
