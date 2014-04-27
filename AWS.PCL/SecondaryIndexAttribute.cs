using System;

namespace Amazon.DynamoDBv2.DataModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public class SecondaryIndexAttribute : System.Attribute 
	{
		public readonly string IndexName;

		public SecondaryIndexAttribute(string indexName)  // url is a positional parameter
		{
			this.IndexName = indexName;
		}
	}
}

