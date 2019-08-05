using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
	class SuperPerson : Person
	{
		public SuperPerson(string FirstName, string LastName) :
			base(FirstName, LastName)
		{

		}

		public void Fly()
		{
			Console.WriteLine("fhwipfhwipfhwipfhwipfhwip..");
		}
	}
}
