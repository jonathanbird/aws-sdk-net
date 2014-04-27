using System;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class BoolTypeConverter  : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			if ((bool)value) {
				return true;
			} else {
				return null;
			}
		}

		public object FromEntry (DynamoDBEntry entry)
		{
			Primitive p = entry as Primitive;
			return p != null;
		}
	}
}

