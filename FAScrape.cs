using System;
using HtmlAgilityPack;

namespace FurScrape
{
    class FAScrape
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.furaffinity.net/journals/rudragon/");

            var htmlNodes = doc.DocumentNode.SelectNodes("//*[@class='maintable page-journals-list']");

            foreach (var node in htmlNodes)
            {
                Console.WriteLine("Writing to scrape.txt");
                System.IO.File.WriteAllText("scrape.txt", node.InnerText);
                Console.WriteLine("scrape.txt has been written to.");
            }
        }
    }
}
