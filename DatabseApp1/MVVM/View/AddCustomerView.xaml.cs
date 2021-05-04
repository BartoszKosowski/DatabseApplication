using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using DatabaseApplication.Database;

namespace DatabaseApplication.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy AddCustomerView.xaml
    /// </summary>
    public partial class AddCustomerView : UserControl
    {
        public AddCustomerView()
        {
            InitializeComponent();
        }

        private void GetCustomerDetails(out string[] addressDetails, out string[] customerDetails)
        {
            addressDetails = new string[4];
            customerDetails = new string[3];

            addressDetails[0] = streetTextBox.Text;
            addressDetails[1] = houseNumberTextBox.Text;
            addressDetails[2] = zipCodeTextBox.Text;
            addressDetails[3] = cityTextBox.Text;

            customerDetails[0] = firstNameTextBox.Text;
            customerDetails[1] = lastNameTextBox.Text;
            customerDetails[2] = phoneNumberTextBox.Text;
        }

        private void ClearTextBoxes()
        {
            streetTextBox.Text = string.Empty;
            houseNumberTextBox.Text = string.Empty;
            zipCodeTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;

            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
        }

        private void clearButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ClearTextBoxes();
        }

        private void addButton_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            string[] addressDetails = new string[4];
            string[] customerDetails = new string[3];

            if (DetailsVerification())
            {
                GetCustomerDetails(out addressDetails, out customerDetails);

                Connection connection = new Connection("ConnectionFile.xml");
                AddCustomerSql addCustomer = new AddCustomerSql(connection.EstablishSqlConnection(), addressDetails, customerDetails);
                addCustomer.AddCustomer();
                MessageBox.Show("New customer has been added");
                ClearTextBoxes();
            }else
            {
                MessageBox.Show("Please fulfill data corrrectly");
            }
            
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
