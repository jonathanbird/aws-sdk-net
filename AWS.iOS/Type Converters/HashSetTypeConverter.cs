using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
	public class HashSetTypeConverter : IPropertyConverter
	{
		public DynamoDBEntry ToEntry (object value)
		{
			HashSet<string> hashset = value as HashSet<string>;
			if (hashset == null)
				throw new ArgumentOutOfRangeException ();

			if (hashset.Count > 0) {
//				var newPrimitiveList = new PrimitiveList();
//				foreach (var item in hashset) {
//					newPrimitiveList.Add(new Primitive(item));
//				}
//				return newPrimitiveList;
				return hashset.ToList ();
			} else {
				return null;
			}
		}

		public object FromEntry (DynamoDBEntry entry)
		{
			PrimitiveList pList = entry as PrimitiveList;
			if (pList == null)
				throw new ArgumentOutOfRangeException ();

			var sList = pList.AsListOfString ();
			var hashSet = new HashSet<string> ();
			foreach (var item in sList) {
				hashSet.Add (item);
			}
			return hashSet;
		}
	}
}

