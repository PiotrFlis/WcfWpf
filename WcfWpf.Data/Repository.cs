using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfWpf.Contracts;

namespace WcfWpf.Data
{
	public class Repository : IRepository
	{
		private List<Article> articles;
		public Repository()
		{
			Initialize();
		}

		private void Initialize()
		{
			articles = new List<Article>();
			articles.Add(new Article()
			{
				Title = "Article 1",
				Teaser = "Article 1 teaser"
			});
			articles.Add(new Article()
			{
				Title = "Article 2",
				Teaser = "Article 2 teaser"
			});
			articles.Add(new Article());
		}

		public List<Article> GetAllArticles()
		{
			return articles;
		}
	}
}
