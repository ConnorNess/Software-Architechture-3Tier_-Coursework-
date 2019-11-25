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

namespace Presentation
{
    /// <summary>
    /// Interaction logic for Loyalty.xaml
    /// </summary>
    public partial class Loyalty : Window
    {
        public Loyalty()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRule_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(txtOffer.Text);
            MessageBox.Show("Offer added");
            txtOffer.Text = null;
        }
    }
}
