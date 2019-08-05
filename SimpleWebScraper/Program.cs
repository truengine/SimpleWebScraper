using SimpleWebScraper.Builders;
using SimpleWebScraper.Data;
using SimpleWebScraper.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
	class Program
	{
		private const string Method = "search";

		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter city: ");
				var city = Console.ReadLine() ?? string.Empty;

				Console.WriteLine("Enter category: ");
				var category = Console.ReadLine() ?? string.Empty;

				using (WebClient client = new WebClient())
				{
					string content = client.DownloadString($"http://{city.Replace(" ", string.Empty)}.craigslist.org/{Method}/{category}");
					ScrapeCriteria scrapeCriteria = new ScrapeCriteriaBuilder()
						.WithData(content)
						.WithRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"">(.*?)</a>")
						.WithRegexOption(RegexOptions.ExplicitCapture)
						.WithPart(new ScrapeCriteriaPartBuilder()
							.WithRegex(@">(.*?)</a>")
							.WithRegexOption(RegexOptions.Singleline)
							.Build())
						.WithPart(new ScrapeCriteriaPartBuilder()
							.WithRegex(@"href=\""(.*?)\""")
							.WithRegexOption(RegexOptions.Singleline)
							.Build())
						.Build();
					Scraper scraper = new Scraper();

					var scrapedElements = scraper.Scrape(scrapeCriteria);

					if (scrapedElements.Any())
					{
						foreach (var scrapedElement in scrapedElements)
						{
							Console.WriteLine(scrapedElement);
						}
					}
					else
					{
						Console.WriteLine("No matches found");
					}
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			

		}
	}
}
