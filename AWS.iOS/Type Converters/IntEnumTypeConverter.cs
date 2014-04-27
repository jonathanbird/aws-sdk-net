using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class IntEnumTypeConverter : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			return (int?)value == 0 ? null : (int?)value;
		}

		public object FromEntry (DynamoDBEntry entry)
		{
			return entry == null ? 0 : entry.AsInt();
		}
	}
}

