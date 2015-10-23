using System;

namespace geHacktbal
{

	// ===============================================================================//
	// This class holds functions with which the game can generate any data it may need,
	// such as non-defined IP addresses, names, and passwords.
	// ==============================================================================//

	public class Generators
	{
		private static Random rnd = new Random();
		private const string pwchars = "AaBbCcDdEeFfGgHhJjKkMmNnPpQqRrSsTtUuVvWwXxYyZz23456789"; //avoiding highly similar characters like 'l, 1, I' altogether.

		public Generators ()
		{
		}
	
		// ================
		// This IP Generator creates randomized IPv4 addresses and returns them as a formatted string.
		// ================
		public static string GenerateIP()
		{
			int iIPSec1;
			int iIPSec2;
			int iIPSec3;
			int iIPSec4;

			iIPSec1 = rnd.Next (1, 255);
			iIPSec2 = rnd.Next (0, 255);
			iIPSec3 = rnd.Next (0, 255);
			iIPSec4 = rnd.Next (0, 255);

			string sIP = "";
			sIP += iIPSec1.ToString() + ".";
			sIP += iIPSec2.ToString() + ".";
			sIP += iIPSec3.ToString() + ".";
			sIP += iIPSec4.ToString() + "";

			return sIP;
		}


		// ================
		// This Password Generator creates a randomized string using characters as defined in pwchars, length of the password is supplied by integer 'difficulty'
		// ================
		public static string GeneratePassword(int difficulty)
		{
			char[] buffer = new char[difficulty];

			for (int i = 0; i < difficulty; i++) {
				buffer [i] = pwchars [rnd.Next (pwchars.Length)];
			}

			return new string(buffer);
		}
	}
}

