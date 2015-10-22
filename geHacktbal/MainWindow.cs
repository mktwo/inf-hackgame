using System;
using Gtk;
using geHacktbal;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnTextChanged (object sender, EventArgs e)
	{
		int iNum1 = geHacktbal.Sanitizers.DigitsOnly(entry2.Text.ToString());
		int iNum2 = geHacktbal.Sanitizers.DigitsOnly(entry3.Text.ToString());
		int iResult = iNum1 + iNum2;
		entry5.Text = geHacktbal.Sanitizers.DisplayableCurrency(iResult.ToString());
	}

	protected void OnKeyPressEvent (object sender, KeyPressEventArgs e)
	{
		
		Title = "Terminal IP: " + Generators.GenerateIP ();
	}
}
