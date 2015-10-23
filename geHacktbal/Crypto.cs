using System;
using System.Text;
using System.Text.RegularExpressions;

namespace geHacktbal
{
	// ===============================================================================//
	// This class holds functions with which the game can encrypt and decrypt info.
	// ==============================================================================//

	public class Crypto
	{
		public Crypto ()
		{
		}

		// ================
		// This RC4 function tranforms the input string with the key string, works both ways.
		// Credit: http://www.fluxbytes.com/csharp/rc4-cypher-in-c/
		// ================
		public static string RC4(string input, string key)
		{
			StringBuilder result = new StringBuilder ();
			int x, y, j = 0;
			int[] box = new int[4]; //Keeping the size small for now, to not stray too deep into crazy symbols!

			for (int i = 0; i < box.Length; i++) {
				box [i] = i;
			}

			for (int i = 0; i < box.Length; i++) {
				j = (key [i % key.Length] + box [i] + j) % box.Length;
				x = box [i];
				box [i] = box [j];
				box [j] = x;
			}

			for (int i = 0; i < input.Length; i++) {
				y = i % box.Length;
				j = (box [y] + j) % box.Length;
				x = box [y];
				box [y] = box [j];
				box [j] = x;

				result.Append ((char)(input [i] ^ box [(box [y] + box [j]) % box.Length]));
			}

			return result.ToString ();
		}

		// ================
		// This Rot13 function tranforms the input string by transposing each character 13 letters.
		// Credit: http://www.fluxbytes.com/csharp/rot-13-cypher-in-c/
		// ================
		public static string Rot13(string input)
		{
			StringBuilder result = new StringBuilder ();
			Regex regex = new Regex ("[A-Za-z]");

			foreach (char c in input) {
				if (regex.IsMatch (c.ToString ())) {
					int charCode = ((c & 223) - 52) % 26 + (c & 32) + 65;
					result.Append ((char)charCode);
				} else {
					result.Append (c);
				}
			}

			return result.ToString ();
		}
	}
}

