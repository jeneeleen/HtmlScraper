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
using WebScraper.Model;

namespace WebScraper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HtmlOutput _htmlOutput = new HtmlOutput();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.CommandBindings.Add(new CommandBinding(Commands.GenerateHtmlSource, GenerateCommandExecute));
            this.DataContext = _htmlOutput;
        }

        private void GenerateCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                _htmlOutput.GenerateHtmlSource(txtUrl.Text);
            }
            catch (Exception ex)
            {
                // Log errors
            }
        }
    }
}
