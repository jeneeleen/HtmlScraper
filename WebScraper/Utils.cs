using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class Utils
    {
        public static string GenerateHtml(string url)
        {
            string pageSource = string.Empty;
            HttpWebRequest webRequest = WebRequest.Create(url) as HttpWebRequest;
            Stream stream = null;
            StreamReader reader = null;

            if (webRequest != null)
            {
                try
                {
                    using (HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse())
                    {
                        stream = response.GetResponseStream();

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            reader = (response.CharacterSet == null) ? new StreamReader(stream)
                                                                     : new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet));

                            pageSource = reader.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log exceptions here
                }
                finally
                {
                    reader.Close();
                    reader.Dispose();
                    stream.Close();
                    stream.Dispose();
                }
            }


            return pageSource;
        }
    }
}
