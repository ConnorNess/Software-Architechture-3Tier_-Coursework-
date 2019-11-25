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
    /// Interaction logic for NewStock.xaml
    /// </summary>
    public partial class NewStock : Window
    {
        private StockList stockstore = StockList.getCurrent();
        public NewStock()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Stock aStock = new Stock();
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Error, please enter data");
            }
            else
            {
                aStock.StockItem = txtName.Text;
                aStock.StockQuantity = txtQuantity.Text;
                aStock.StockPrice = txtPrice.Text;
                aStock.RefNo = aStock.refNoCounter;
                aStock.refNoIncrement();
                stockstore.add(aStock);

                MessageBox.Show("Stock added, reference: " + aStock.RefNo);

                this.Close();
                StockChanges Window = new StockChanges();
                Window.ShowDialog();
            }
        }
    }
}
