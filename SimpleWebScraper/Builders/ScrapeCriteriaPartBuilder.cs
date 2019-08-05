﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleWebScraper.Data;

namespace SimpleWebScraper.Builders
{
	class ScrapeCriteriaPartBuilder
	{
		//	public string Regex { get; set; }
		//	public RegexOptions RegexOption { get; set; }

		private string _regex;
		private RegexOptions _regexOption;

		public ScrapeCriteriaPartBuilder()
		{
			SetDefaults();
		}

		private void SetDefaults()
		{
			_regex = string.Empty;
			_regexOption = RegexOptions.None;
		}

		public ScrapeCriteriaPartBuilder WithRegex(string regex)
		{
			_regex = regex;
			return this;
		}

		public ScrapeCriteriaPartBuilder WithRegexOption(RegexOptions regexOption)
		{
			_regexOption = regexOption;
			return this;
		}

		public ScrapeCriteriaPartBuilder Build()
		{
			ScrapeCriteriaPart scrapeCriteriaPart = new ScrapeCriteriaPart();
			scrapeCriteriaPart.Regex = _regex;
			scrapeCriteriaPart.RegexOption = _regexOption;
			return this;
		}
	}
}
