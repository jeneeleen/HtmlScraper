using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WebScraper.Model;

namespace WebScraper
{
    public class Commands
    {
        public static RoutedCommand GenerateHtmlSource = new RoutedCommand("GenerateHtmlSource", typeof(Button));
    }
}
