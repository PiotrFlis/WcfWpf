using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfWpf.Contracts;

namespace WcfWpf.Data
{
    public interface IRepository
    {
		List<Article> GetAllArticles();
    }
}
