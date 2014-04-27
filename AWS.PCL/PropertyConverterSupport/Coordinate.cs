using System;

namespace Amazon.DynamoDBv2.DataModel
{
	public class Coordinate
	{
		public double Latitude { get; private set; }

		public double Longitude { get; private set; }

		public double AccuracyInMeters { get; private set; }

		public DateTime? TimeStamp { get; private set; }

		public Coordinate (double latitude, double longitude, double accuracy, DateTime? timeStamp = null)
		{
			Latitude = latitude;
			Longitude = longitude;
			AccuracyInMeters = accuracy;
			TimeStamp = timeStamp;
		}

		public int AccuracyInFeet {
			get {
				return (int)Math.Ceiling (AccuracyInMeters / 0.304800610);
			}
		}

		public object Clone ()
		{
			return (Coordinate)this.MemberwiseClone ();
		}
	}
}

