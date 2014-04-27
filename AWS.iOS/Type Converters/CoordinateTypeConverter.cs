using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class CoordinateTypeConverter : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			Coordinate cord = value as Coordinate;
			var pList = new PrimitiveList (DynamoDBEntryType.Numeric);
			if (cord != null) {
				pList.Add (cord.Latitude);
				pList.Add (cord.Longitude);
				pList.Add (cord.AccuracyInMeters);
			}
			return pList;
		}

		public object FromEntry (DynamoDBEntry entry)
		{
			PrimitiveList pList = entry as PrimitiveList;

			if (pList != null) {
				double lat = 0, lon = 0, accuracy = 0;
				for (int i = 0; i < pList.Entries.Count; i++) {
					switch (i) {
					case 0:
						lat = pList [i].AsDouble ();
						break;
					case 1:
						lon = pList [i].AsDouble ();
						break;
					case 2:
						accuracy = pList [i].AsDouble ();
						break;
					default:
						break;
					}
				}
				return new Coordinate (lat, lon, accuracy);
			} else {
				return null;
			}
		}
	}
}

