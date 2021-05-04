using DatabaseApplication.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DatabaseApplication
{
    /// <summary>
    /// Logika interakcji dla klasy EditCustomer.xaml
    /// </summary>
    public partial class EditCustomer : Window
    {
        private int _customerId;
        public EditCustomer(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            FulfillTextBoxes();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void closeButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void updateButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string[] customerDetails = new string[3];
            string[] addressDetails = new string[4];

            if (DetailsVerification())
            {
                customerDetails[0] = firstNameTextBox.Text;
                customerDetails[1] = lastNameTextBox.Text;
                customerDetails[2] = phoneNumberTextBox.Text;
                addressDetails[0] = streetTextBox.Text;
                addressDetails[1] = houseNumberTextBox.Text;
                addressDetails[2] = zipCodeTextBox.Text;
                addressDetails[3] = cityTextBox.Text;

                Connection connection = new Connection("ConnectionFile.xml");
                EditCustomerSql editCustomerSql = new EditCustomerSql(connection.EstablishSqlConnection(), _customerId, addressDetails, customerDetails);
                editCustomerSql.UpdateAddress();
                editCustomerSql.UpdateCustomer();
                updateInfo.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Please fulfill data corrrectly");
            }
            
        }

        private void deleteButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Connection connection = new Connection("ConnectionFile.xml");
            EditCustomerSql editCustomerSql = new EditCustomerSql(connection.EstablishSqlConnection(), _customerId);
            editCustomerSql.GetValuesFromCustomers();
            editCustomerSql.DeleteCustomer();
        }

        private void FulfillTextBoxes()
        {
            Connection connection = new Connection("ConnectionFile.xml");
            EditCustomerSql editCustomerSql = new EditCustomerSql(connection.EstablishSqlConnection(), _customerId);
            editCustomerSql.GetValuesFromCustomers();
            string[] addressDetails = editCustomerSql.GetAddressDetails();
            string[] customerDetails = editCustomerSql.GetCustomerDetails();

            firstNameTextBox.Text = customerDetails[0];
            lastNameTextBox.Text = customerDetails[1];
            phoneNumberTextBox.Text = customerDetails[2];
            streetTextBox.Text = addressDetails[0];
            houseNumberTextBox.Text = addressDetails[1];
            zipCodeTextBox.Text = addressDetails[2];
            cityTextBox.Text = addressDetails[3];
        }

        private bool DetailsVerification()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(houseNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(zipCodeTextBox.Text) || string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                return false;
            }

            if (!Regex.IsMatch(phoneNumberTextBox.Text, @"[0-9+]+$"))
            {
                return false;
            }
            return true;

        }
    }
}
