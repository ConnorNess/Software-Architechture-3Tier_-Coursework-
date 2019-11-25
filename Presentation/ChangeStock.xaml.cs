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
using Business_Objects;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for ChangeStock.xaml
    /// </summary>
    public partial class ChangeStock : Window
    {
        private Stock changeStock;
        private StockList stockstore = StockList.getCurrent();
        private int searchStock;

        public ChangeStock()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try { searchStock = Int32.Parse(txtID.Text); }
            catch { MessageBox.Show("invalid"); }

            if (stockstore.find(searchStock) != null)
            {
                changeStock = stockstore.find(searchStock);
                txtName.Text = changeStock.StockItem;
                txtPrice.Text = changeStock.StockPrice;
                txtQuantity.Text = changeStock.StockQuantity;
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                {
                    int stockCheck = Convert.ToInt32(txtQuantity.Text);

                    changeStock.StockItem = txtName.Text;
                    changeStock.StockPrice = txtPrice.Text;
                    changeStock.StockQuantity = txtQuantity.Text;
                        if (stockCheck > 0 && stockCheck < 5) { MessageBox.Show("Please order new stock, quantity is low"); }
                        if (stockCheck == 0)
                        {
                            MessageBox.Show("Stock is empty, ordering 10 more stock");
                            changeStock.StockQuantity = "10";
                            Console.WriteLine("Order 10 of " + changeStock.StockItem);
                        }
                    MessageBox.Show("updated");
                }
            }
            catch
            {
                MessageBox.Show("error, no changes made");
            }
        }
    }
}
