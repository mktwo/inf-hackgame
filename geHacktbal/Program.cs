using System;
using Gtk;

namespace geHacktbal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Title = "Terminal IP: " + Generators.GenerateIP() + " Password: " + Generators.GeneratePassword(8);
			win.Show ();
			Application.Run ();
		}
	}
}
