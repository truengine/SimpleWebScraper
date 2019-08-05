using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person("John","Smith");
			person1.Sleep();

			SuperPerson pers = new SuperPerson("Rye", "Fos");
			pers.Sleep();
			pers.Fly();
		}
	}
}
