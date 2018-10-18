using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Model
{
    public class HtmlOutput : INotifyPropertyChanged
    {
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }


        private string html;

        public string Html
        {
            get
            {
                return html;
            }
            set
            {
                if (html != value)
                {
                    html = value;
                    OnPropertyChanged("Html");
                }
            }
        }

        public HtmlOutput()
        {

        }

        public void GenerateHtmlSource(string url)
        {
            this.url = url;
            Html = Utils.GenerateHtml(url);
        }


        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
