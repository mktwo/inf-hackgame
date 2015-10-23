using System;
using Gtk;
using geHacktbal;

public partial class MainWindow: Gtk.Window
{
	private string testinfo = "Super secret!";
	private string testkey = "cipheriffic";

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
		// PageUp to regenerate IP and password
		if (e.Event.Key == Gdk.Key.Page_Up) {
			Title = "Terminal IP: " + Generators.GenerateIP () + " Password: " + Generators.GeneratePassword (8);
		}
			
		// PageDown to do crypto stuff..
		if (e.Event.Key == Gdk.Key.Page_Down) {
			testkey = Generators.GeneratePassword (8);
			Title = "RC4: " + Crypto.RC4(testinfo, testkey) + " === Rot13: " +   Crypto.Rot13(testinfo) + " === RC4 Key = " + testkey; 
		}

		if (e.Event.Key == Gdk.Key.Escape) {
			Application.Quit ();
		}
	}
}
