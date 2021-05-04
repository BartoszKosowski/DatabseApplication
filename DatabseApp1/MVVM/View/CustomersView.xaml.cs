using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DatabaseApplication.Database;

namespace DatabaseApplication.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        private int customerId;
        public CustomersView()
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

        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (CustomerVerification())
            {
                var editCustomer = new EditCustomer(customerId);
                editCustomer.Show();
            }
            else
            {
                MessageBox.Show("Please select the customer");
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

        private bool CustomerVerification()
        {
            if (double.IsNaN(customerId))
            {
                return false;
            }
            return true;
        }
    }
}
