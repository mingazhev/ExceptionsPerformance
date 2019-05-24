using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
	public static class MethodsUnderTest
	{
		private static readonly Dictionary<string, int> FieldsDictionary;
		
		private static readonly List<string> Keys;
		
		static MethodsUnderTest()
		{
			FieldsDictionary = Enumerable
				.Range(0, 200)
				.ToDictionary(k => $"name_{k}", v => v);

			Keys = FieldsDictionary.Keys.ToList();
		}
		
		public static bool ContainsValue_WithLoop(string fieldName)
		{
			for (int i = 0; i < FieldsDictionary.Count; i++)
			{
				if (Keys[i] == fieldName)
					return true;
			}

			return false;
		}
		
		public static bool ContainsField_WithException(string fieldName)
		{
			if (FieldsDictionary.TryGetValue(fieldName, out var val))
			{
				return true;
			}
			else
			{
				try
				{
					throw new IndexOutOfRangeException();
				}
				catch (Exception e)
				{
					return false;
				}
			}
		}
	}
}