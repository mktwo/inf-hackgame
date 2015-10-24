using System;

namespace geHacktbal
{
	public partial class ProfileNameDialog : Gtk.Dialog
	{
		public string profileName = "";

		public ProfileNameDialog (string currName)
		{
			profileName = currName;
			this.Build ();
			this.Hide ();
		}

		protected void OnButtonOkPressed (object sender, EventArgs e)
		{
			profileName = entry1.Text.ToString ();
			this.Hide ();
		}

		protected void OnButtonCancelPressed (object sender, EventArgs e)
		{
			this.Hide ();
		}
	}
}

