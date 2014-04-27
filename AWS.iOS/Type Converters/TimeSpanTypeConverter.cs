using System;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class TimeSpanTypeConverter  : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			var ts = (TimeSpan)value;
			return ts.Ticks;
		}

		public object FromEntry (DynamoDBEntry entry)
		{
			Primitive p = entry as Primitive;
			return new TimeSpan (p.AsLong ());
		}
	}
}

