using System;

namespace geHacktbal
{
	public class Generators
	{
		public Generators ()
		{
		}

		public static string GenerateIP()
		{
			int iIPSec1;
			int iIPSec2;
			int iIPSec3;
			int iIPSec4;

			iIPSec1 = new Random ().Next (0, 255);
			iIPSec2 = new Random (iIPSec1).Next (0, 255);
			iIPSec3 = new Random (iIPSec2).Next (0, 255);
			iIPSec4 = new Random (iIPSec3).Next (0, 255);

			string sIP = "";
			sIP += iIPSec1.ToString() + ".";
			sIP += iIPSec2.ToString() + ".";
			sIP += iIPSec3.ToString() + ".";
			sIP += iIPSec4.ToString() + "";

			return sIP;
		}
	}
}

