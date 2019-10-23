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

namespace AccessData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            AccessData.AdventureWorks2017DataSet adventureWorks2017DataSet = ((AccessData.AdventureWorks2017DataSet)(this.FindResource("adventureWorks2017DataSet")));
            // Load data into the table Product. You can modify this code as needed.
            AccessData.AdventureWorks2017DataSetTableAdapters.ProductTableAdapter adventureWorks2017DataSetProductTableAdapter = new AccessData.AdventureWorks2017DataSetTableAdapters.ProductTableAdapter();
            adventureWorks2017DataSetProductTableAdapter.Fill(adventureWorks2017DataSet.Product);
            System.Windows.Data.CollectionViewSource productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }
    }
}
