using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
	class Person
	{

		public string FirstName { get; set; }
		public string LastName { get; set; }

		//private string _first;
		//private string _last;

		public Person(string f, string l)
		{
			FirstName = f;
			LastName = l;
		}

		public void Sleep()
		{
			Console.WriteLine("...zzz..");
		}

		public void Eat()
		{
			Console.WriteLine("..nom nom nom..");
		}

		public void Walk()
		{
			Console.WriteLine("..clip clop clip clop..");
		}

	}
}
