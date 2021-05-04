using DatabaseApplication.Database;
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

namespace DatabaseApplication
{
    /// <summary>
    /// Logika interakcji dla klasy EditOrder.xaml
    /// </summary>
    public partial class EditOrder : Window
    {
        private int _orderId;
        public EditOrder(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            FulfillDataBoxes();
        }

        private void closeButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void deleteButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Connection connection = new Connection("ConnectionFile.xml");
            EditOrderSql editOrderSql = new EditOrderSql(connection.EstablishSqlConnection(), _orderId);
            editOrderSql.GetValuesFromOrders();
            editOrderSql.DeleteOrder();
        }

        private void updateButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string service = serviceComboBox.SelectedItem.ToString();
            string status = statusComboBox.SelectedItem.ToString();
            string desc = new TextRange(descRichBox.Document.ContentStart, descRichBox.Document.ContentEnd).Text;

            Connection connection = new Connection("ConnectionFile.xml");
            EditOrderSql editOrderSql = new EditOrderSql(connection.EstablishSqlConnection(), _orderId, expireDate.SelectedDate.Value, service, status, desc);
            editOrderSql.UpdateOrder();

        }

        private void FulfillDataBoxes()
        {
            Connection connection = new Connection("ConnectionFile.xml");
            EditOrderSql editOrderSql = new EditOrderSql(connection.EstablishSqlConnection(), _orderId);
            editOrderSql.GetValuesFromOrders();

            string[] details;
            DateTime[] dates;
            editOrderSql.GetOrderDetails(out details, out dates);

            nameTextBox.Text = details[0];
            serviceComboBox.SelectedItem = details[1];
            orderDate.SelectedDate = dates[0];
            expireDate.SelectedDate = dates[1];
            statusComboBox.SelectedItem = details[2];
            descRichBox.Document.Blocks.Add(new Paragraph(new Run(details[3])));
            nameTextBox.IsReadOnly = true;
            orderDate.IsEnabled = false;
        }
    }
}
