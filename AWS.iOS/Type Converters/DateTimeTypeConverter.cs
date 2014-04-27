using System;
using System.Globalization;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class DateTimeTypeConverter : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			DateTime? dt = value as DateTime?;
			return DateTimeToString (dt);

		}

		public object FromEntry (DynamoDBEntry entry)
		{
			Primitive p = entry as Primitive;
			return StringToDateTime (p.AsString ());
		}

		public static string DateTimeToString (DateTime? dt)
		{
			if (dt.HasValue) {
				return dt.Value.ToUniversalTime ().ToString (FormatISO8601);
			} else {
				return "";
			}

		}

		public static DateTime? StringToDateTime (string value)
		{
			if (string.IsNullOrWhiteSpace (value) == false) {
				return DateTime.ParseExact (value, FormatISO8601, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
			} else {
				return null;
			}
		}

		private const string FormatISO8601 = "yyyy-MM-ddTHH:mm:ssZ";

	}
}

