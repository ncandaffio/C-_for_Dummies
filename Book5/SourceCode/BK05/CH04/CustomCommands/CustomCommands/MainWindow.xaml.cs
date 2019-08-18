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

namespace CustomCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Clipboard.Clear();
        }

        private void CommandBinding_Executed(object sender, 
            ExecutedRoutedEventArgs e)
        {
            String Name = ((RoutedCommand)e.Command).Name;

            if (Name == "Copy")
            {
                Clipboard.SetText(Source.Text);
            }
            else if (Name == "Paste")
            {
                Destination.Text = Destination.Text + Clipboard.GetText();
            }
        }

        private void CommandBinding_CanExecute(object sender, 
            CanExecuteRoutedEventArgs e)
        {
            string Name = ((RoutedCommand)e.Command).Name;

            if (Name == "Copy")
            {
                if (Source == null)
                {
                    e.CanExecute = false;
                    return;
                }

                if (Source.SelectedText.Length > 0)
                    e.CanExecute = true;
                else
                    e.CanExecute = false;
            }
            else if (Name == "Paste")
            {
                if (Clipboard.ContainsText() == true)
                {
                    e.CanExecute = true;
                }
                else
                {
                    e.CanExecute = false;
                }
            }
        }
    }
}
