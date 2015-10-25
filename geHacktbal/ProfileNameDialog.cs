using System;

namespace geHacktbal
{
	public partial class ProfileNameDialog : Gtk.Dialog
	{
		public bool hasResponded;
		public string newName;

		public ProfileNameDialog (string currName)
		{
			this.Build ();
			entry1.Text = currName;
			hasResponded = false;
		}

		protected void OnButtonOkPressed (object sender, EventArgs e)
		{
			newName = entry1.Text.ToString ();
			this.Respond (Gtk.ResponseType.Ok);
			this.Destroy ();
		}
	}
}

