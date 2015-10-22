using System;
using System.Text.RegularExpressions;

namespace geHacktbal
{
	// ===============================================================================//
	// This class holds functions with which the game can transform data to fit
	// display expectations, such as removing any non-numeric characters from a string
	// ==============================================================================//

	public class Sanitizers
	{
		private static Regex digitsOnly = new Regex(@"[^\d]");

		public Sanitizers ()
		{
		}

		public static int DigitsOnly(string s)
		{
			int iParseSuccess;
			int.TryParse(digitsOnly.Replace(s, ""), out iParseSuccess);

			if (iParseSuccess != 0) {
				return iParseSuccess;
			} else {
				return 0;
			}
		}

		public static string DisplayableCurrency(string s)
		{
			string sCurrency = s.Insert (0, "₵");
			return sCurrency;
		}
	}
}