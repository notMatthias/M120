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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M120_Kombinationsprojekt.Main
{
    /// <summary>
    /// Interaktionslogik für Customer.xaml
    /// </summary>
    public partial class Order : Page
    {
        public Order()
        {
            InitializeComponent();
        }
        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            var inventory = new InventoryDialog();
            inventory.ShowDialog();
        }
        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            var edit = new CustomerDialog();
            edit.ShowDialog();
        }
        private void Order_Click(object sender, RoutedEventArgs e)
        {
            var order = new OrderDialog();
            order.ShowDialog();
        }
    }
}
