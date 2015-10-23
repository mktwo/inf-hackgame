using System;
using Gtk;
using geHacktbal;
using System.IO;

public partial class MainWindow: Gtk.Window
{
	private string testinfo = "Super secret!";
	private string testkey = "cipheriffic";
	public string[] currentProfile;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		// Savegame check or creation
		if (File.Exists ("sav/profile_1.txt")) {
			string[] s = File.ReadAllLines ("sav/profile_1.txt");
			currentProfile = s;
		} else {
			string[] newProfile = new string[2];
			newProfile.SetValue(Generators.GenerateIP (), 0);
			newProfile.SetValue(Generators.GeneratePassword (8), 1);

			currentProfile = newProfile;
			SaveProfile ();
		}

		UpdateTitle ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnTextChanged (object sender, EventArgs e)
	{
		
	}

	protected void UpdateTitle ()
	{
		Title = "Terminal IP: " + currentProfile [0] + " - Password: " + currentProfile [1];

		entry2.Text = currentProfile [0];
		entry3.Text = currentProfile [1];
	}

	protected void SaveProfile()
	{
		UpdateTitle ();
		File.WriteAllLines ("sav/profile_1.txt", currentProfile);
	}

	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		currentProfile [0] = Generators.GenerateIP ();
		currentProfile [1] = Generators.GeneratePassword (8);
		UpdateTitle ();
	}


	protected void OnQuitActionActivated (object sender, EventArgs e)
	{
		Application.Quit ();
	}


	protected void OnSaveActionActivated (object sender, EventArgs e)
	{
		currentProfile [0] = entry2.Text.ToString ();
		currentProfile [1] = entry3.Text.ToString ();
		SaveProfile();
	}

	protected void OnRC4ActionActivated (object sender, EventArgs e)
	{
		testinfo = textview1.Buffer.Text.ToString ();
		textview1.Buffer.Text = Crypto.RC4(testinfo, testkey);
	}


	protected void OnRot13ActionActivated (object sender, EventArgs e)
	{
		testinfo = textview1.Buffer.Text.ToString ();
		textview1.Buffer.Text = Crypto.Rot13 (testinfo);
	}
}