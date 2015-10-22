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
			win.Title = "Terminal IP: " + Generators.GenerateIP();
			win.Show ();
			Application.Run ();
		}
	}
}
