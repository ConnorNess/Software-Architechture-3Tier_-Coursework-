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
using System.IO;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for Finance.xaml
    /// </summary>
    public partial class Finance : Window
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            string line;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            
            var file = new System.IO.StreamReader(projectDirectory + "..\\..\\Data\\Finances.txt");
            while ((line = file.ReadLine()) != null)
            {
                ListFinances.Items.Add(line);
            }
        }

        private void btnApprove_Click(object sender, RoutedEventArgs e)
        {
            while (ListFinances.SelectedItems.Count > 0)
            {
                ListFinances.Items.Remove(ListFinances.SelectedItems[0]);
                try { Console.WriteLine(ListFinances.SelectedIndex); }
                catch { MessageBox.Show("error, file not sent"); }
                
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            while (ListFinances.SelectedItems.Count > 0)
            {
                ListFinances.Items.Remove(ListFinances.SelectedItems[0]);
            }
        }
    }
}
