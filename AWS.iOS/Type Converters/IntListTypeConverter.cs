using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class IntListTypeConverter : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			var list = value as List<int>;
			var str = string.Join(",",list);
			return new Primitive(str);
		}

		public object FromEntry (DynamoDBEntry entry)
		{
			var str = entry.AsString();
			var list = string.IsNullOrWhiteSpace(str) ? new List<int>() : str.Split(',').Select(int.Parse).ToList();
			return list;
		}
	}
}

