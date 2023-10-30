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

namespace WPFMessageWall
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(lastNameText.Text) || string.IsNullOrWhiteSpace(firstNameText.Text))
        //    {
        //        MessageBox.Show($"incorrect enty, plz fill both names");
        //    }
        //    else
        //    {
        //        //PersonModel person = new()
        //        //{
        //        //    FirstName = firstNameText.ToString(),
        //        //    LastName = lastNameText.ToString()
        //        //};

        //        MessageBox.Show($"Hi {firstNameText.Text} {lastNameText.Text}");

        //        MainWindow form2 = new();
        //        form2.Show();
        //    }


        //}

        private void addNamesButton_Click(object sender, RoutedEventArgs e)
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

        public class PersonModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }

}