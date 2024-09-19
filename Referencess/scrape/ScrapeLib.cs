using System;
using System.IO;
using System.Net;

namespace Scrape
{
    public class ScrapeLib
    {
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "To już wszystko na dzisiaj!";
            return content;
        }

        public string ScrapeWebPage (string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebPage(string url, string path)
        {
            string replay = GetWebPage(url);
            File.WriteAllText(path, replay);
            return replay;
        }
    }
}
