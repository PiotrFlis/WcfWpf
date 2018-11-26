using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfWpf.Contracts;
using WcfWpf.Data;

namespace WcfWpf.Service
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class WcfWpfService : IWcfWpfService
	{
		private readonly IRepository repository;

		private List<Article> articles { get { return repository.GetAllArticles(); } }

		public WcfWpfService(IRepository repository)
		{
			this.repository = repository;
		}

		public string[] GetTitles(int countOfMostRecentArticles)
		{
			return articles.AsEnumerable().Skip(articles.Count - countOfMostRecentArticles).Reverse().Select(a => a.Title).ToArray();
		}

		public Article GetArticle(int number)
		{
			int articlesCount = articles.Count;

			if (articlesCount <= number)
			{
				throw new ArgumentOutOfRangeException($"number >= {articlesCount}");
			}
			return articles.ElementAt(articlesCount - number - 1);
		}
	}
}
