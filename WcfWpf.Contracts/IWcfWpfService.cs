using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfWpf.Contracts
{
	[ServiceContract]
	public interface IWcfWpfService
	{
		[OperationContract]
		string[] GetTitles(int countOfMostRecentArticles);

		[OperationContract]
		Article GetArticle(int number);
	}

	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfWpf.Contracts.ContractType".
	[DataContract]
	public class Article
	{
		string title = "Hello ";
		string teaser = "Hello word message";

		[DataMember]
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		[DataMember]
		public string Teaser
		{
			get { return teaser; }
			set { teaser = value; }
		}
	}
}
