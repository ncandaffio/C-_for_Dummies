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

namespace OrientControls
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

        private void cmdOrientation_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Content.ToString() == "Set Vertical")
            {
                pnlStack.Orientation = Orientation.Vertical;
                button.Content = "Set Horizontal";
                Title = "Stack Panel - Vertical";
            }
            else
            {
                pnlStack.Orientation = Orientation.Horizontal;
                button.Content = "Set Vertical";
                Title = "Stack Panel - Horizontal";
            }
        }
    }
}
