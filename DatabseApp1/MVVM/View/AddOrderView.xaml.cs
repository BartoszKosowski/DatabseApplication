using DatabaseApplication.Database;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;


namespace DatabaseApplication.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy AddOrderView.xaml
    /// </summary>
    public partial class AddOrderView : UserControl
    {
        int customerId;
        public AddOrderView()
        {
            InitializeComponent();
            Connection connection = new Connection("ConnectionFile.xml");
            CustomersSql customersSql = new CustomersSql(connection.EstablishSqlConnection(), nameTextBox.Text);
            customersDataGrid.ItemsSource = customersSql.GetAllCustomers().DefaultView;
        }

        private void searchButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Connection connection = new Connection("ConnectionFile.xml");
            CustomersSql customersSql = new CustomersSql(connection.EstablishSqlConnection(), nameTextBox.Text);
            customersDataGrid.ItemsSource = customersSql.GetSpecifiedCustomer().DefaultView;
        }

        private void clearButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Connection connection = new Connection("ConnectionFile.xml");
            CustomersSql customersSql = new CustomersSql(connection.EstablishSqlConnection(), "");
            customersDataGrid.ItemsSource = customersSql.GetSpecifiedCustomer().DefaultView;
            nameTextBox.Text = string.Empty;
            expireDate.SelectedDate = DateTime.Now;
            descriptionBox.Document.Blocks.Clear();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string desc = new TextRange(descriptionBox.Document.ContentStart, descriptionBox.Document.ContentEnd).Text;
            if (DetailsVerification())
            {
                Connection connection = new Connection("ConnectionFile.xml");
                AddOrderSql addOrderSql = new AddOrderSql(connection.EstablishSqlConnection(), customerId, serviceComboBox.SelectedItem.ToString(), desc, expireDate.SelectedDate.Value);
                addOrderSql.CreateOrder();
            }
            else
            {
                MessageBox.Show("Please fulfill details correctly");
            }
            
        }

        private void customersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell rowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string cellValue = ((TextBlock)rowColumn.Content).Text;
            Int32.TryParse(cellValue, out customerId);
        }

        private bool DetailsVerification()
        {
            var date = expireDate.SelectedDate.Value;
            if (double.IsNaN(customerId) || date == null || serviceComboBox.SelectedItem.ToString() == null)
            {
                return false;
            }
            return true;
        }
    }
}
