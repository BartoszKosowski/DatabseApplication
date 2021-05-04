using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DatabaseApplication.Database;

namespace DatabaseApplication.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy OrdersView.xaml
    /// </summary>
    public partial class OrdersView : UserControl
    {
        private int _orderId;
        public OrdersView()
        {
            InitializeComponent();
            Connection connection = new Connection("ConnectionFile.xml");
            OrdersSql ordersSql = new OrdersSql(connection.EstablishSqlConnection(), nameTextBox.Text);
            ordersDataGrid.ItemsSource = ordersSql.GetAllOrders().DefaultView;
        }

        private void searchBuuton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Connection connection = new Connection("ConnectionFile.xml");

            if (idTextBox.Text.Length > 0)
            {
                OrdersSql ordersSql = new OrdersSql(connection.EstablishSqlConnection(), Int32.Parse(idTextBox.Text));
                ordersDataGrid.ItemsSource = ordersSql.GetOrdersById().DefaultView;
            }
            else
            {
                OrdersSql ordersSql = new OrdersSql(connection.EstablishSqlConnection(), nameTextBox.Text);
                ordersDataGrid.ItemsSource = ordersSql.GetOrdersByName().DefaultView;
            }
                
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (OrderVerification())
            {
                EditOrder editOrder = new EditOrder(_orderId);
                editOrder.Show();
            }
            else
            {
                MessageBox.Show("Please, select the order"); 
            }
            
        }

        private void ordersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell rowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string cellValue = ((TextBlock)rowColumn.Content).Text;
            Int32.TryParse(cellValue, out _orderId);
        }

        private bool OrderVerification()
        {
            if (double.IsNaN(_orderId))
            {
                return false;
            }
            return true;
        }
    }
}
