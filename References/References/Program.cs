using Scrape;
using System;

namespace References
{
    class Program
    {
        static void Main(string[] args)
        {
            ScrapeLib myScrapper = new ScrapeLib();
            string page =  myScrapper.ScrapeWebPage("http://videopoint.pl");
            Console.WriteLine(page);
        }


    }
}
