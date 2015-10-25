using System;
using Gtk;
using geHacktbal;
using System.IO;

public partial class MainWindow: Gtk.Window
{
	private string testinfo = "Super secret!";
	private string testkey = "cipheriffic";
	private static string profilePath = System.IO.Path.Combine (Directory.GetCurrentDirectory (), "sav"); 
	private string[] availableProfiles;
	public static string[] currentProfile;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		availableProfiles = Directory.GetFiles(profilePath);

		// Savegame check or creation
		if (availableProfiles.Length > 0) {
			Console.Write ("Profile detected!");
			string[] s = File.ReadAllLines (availableProfiles[0]);
			currentProfile = s;
			UpdateTitle ();
		} else {
			Console.Write ("No profile detected!");
			string[] newProfile = new string[3];
			ProfileNameDialog namedialog = new ProfileNameDialog ("Please enter a name...");
			namedialog.Response += (object o, ResponseArgs args) => {
				if (args.ResponseId == ResponseType.Ok) {
					newProfile[0] = Generators.GenerateIP ();
					newProfile[1] = Generators.GeneratePassword (8);
					newProfile[2] = namedialog.newName;
					currentProfile = newProfile;
					//SaveProfile ();
					UpdateTitle ();
				}
			};

		}
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
		Title = "Name: " + currentProfile[2] + " Terminal IP: " + currentProfile [0] + " - Password: " + currentProfile [1];

		entry2.Text = currentProfile [0];
		entry3.Text = currentProfile [1];
	}

	protected void SaveProfile()
	{
		UpdateTitle ();
		Directory.CreateDirectory ("sav");
		File.WriteAllLines (System.IO.Path.Combine(profilePath, "profile_" + currentProfile[2] + ".txt"), currentProfile);
	}

	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		currentProfile [0] = Generators.GenerateIP ();
		currentProfile [1] = Generators.GeneratePassword (8);
		ProfileNameDialog namedialog = new ProfileNameDialog (currentProfile[2]);
		namedialog.Response += (object o, ResponseArgs args) => {
			if (args.ResponseId == ResponseType.Ok) {
				currentProfile[2] = namedialog.newName;
				//SaveProfile ();
				UpdateTitle ();
			}
		};
	}


	protected void OnQuitActionActivated (object sender, EventArgs e)
	{
		Application.Quit ();
	}


	protected void OnSaveActionActivated (object sender, EventArgs e)
	{
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
	protected void OnNewActionActivated (object sender, EventArgs e)
	{
		ProfileNameDialog namedialog = new ProfileNameDialog (currentProfile [2]);
		namedialog.Response += (object o, ResponseArgs args) => {
			if (args.ResponseId == ResponseType.Ok) {
				currentProfile[2] = namedialog.newName;
				//SaveProfile ();
				UpdateTitle ();
			}
		};
	}
}