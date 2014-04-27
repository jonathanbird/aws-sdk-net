using System;
using System.Globalization;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class TicksDateTimeTypeConverter : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			DateTime? dt = value as DateTime?;
			return DateTimeToLong (dt);

		}

		public object FromEntry (DynamoDBEntry entry)
		{
			Primitive p = entry as Primitive;
			return LongToDateTime (p.AsLong ());
		}

		public static long? DateTimeToLong (DateTime? dt)
		{
			if (dt.HasValue) {
				return dt.Value.ToUniversalTime ().Ticks;
			} else {
				return null;
			}

		}

		public static DateTime? LongToDateTime (long? value)
		{
			if (value.HasValue) {
				return new DateTime (value.Value, DateTimeKind.Utc);
			} else {
				return null;
			}
		}
	}
}

