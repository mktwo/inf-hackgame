
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action saveAction;
	
	private global::Gtk.Action quitAction;
	
	private global::Gtk.Action CredentialsAction;
	
	private global::Gtk.Action refreshAction;
	
	private global::Gtk.Action CryptoAction;
	
	private global::Gtk.Action executeAction;
	
	private global::Gtk.Action executeAction1;
	
	private global::Gtk.Action newAction;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.MenuBar menubar2;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.Entry entry2;
	
	private global::Gtk.Entry entry3;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView textview1;
	
	private global::Gtk.HSeparator hseparator1;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Label label3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
		w1.Add (this.saveAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction, null);
		this.CredentialsAction = new global::Gtk.Action ("CredentialsAction", global::Mono.Unix.Catalog.GetString ("Credentials"), null, null);
		this.CredentialsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Credentials");
		w1.Add (this.CredentialsAction, null);
		this.refreshAction = new global::Gtk.Action ("refreshAction", global::Mono.Unix.Catalog.GetString ("Regenerate"), null, "gtk-refresh");
		this.refreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Regenerate");
		w1.Add (this.refreshAction, null);
		this.CryptoAction = new global::Gtk.Action ("CryptoAction", global::Mono.Unix.Catalog.GetString ("Crypto"), null, null);
		this.CryptoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Crypto");
		w1.Add (this.CryptoAction, null);
		this.executeAction = new global::Gtk.Action ("executeAction", global::Mono.Unix.Catalog.GetString ("RC4"), null, "gtk-execute");
		this.executeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("RC4");
		w1.Add (this.executeAction, null);
		this.executeAction1 = new global::Gtk.Action ("executeAction1", global::Mono.Unix.Catalog.GetString ("Rot13"), null, "gtk-execute");
		this.executeAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Rot13");
		w1.Add (this.executeAction1, null);
		this.newAction = new global::Gtk.Action ("newAction", global::Mono.Unix.Catalog.GetString ("Set profile name"), null, "gtk-new");
		this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Set profile name");
		w1.Add (this.newAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.CanDefault = true;
		this.CanFocus = true;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 720;
		this.DefaultHeight = 480;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 4;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar2'><menu name='FileAction' action='FileAction'><menuitem name='saveAction' action='saveAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='CredentialsAction' action='CredentialsAction'><menuitem name='refreshAction' action='refreshAction'/><menuitem name='newAction' action='newAction'/></menu><menu name='CryptoAction' action='CryptoAction'><menuitem name='executeAction' action='executeAction'/><menuitem name='executeAction1' action='executeAction1'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox2.Add (this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
		this.table1.HeightRequest = 292;
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(12));
		this.table1.BorderWidth = ((uint)(8));
		// Container child table1.Gtk.Table+TableChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.entry2.IsEditable = true;
		this.entry2.MaxLength = 16;
		this.entry2.InvisibleChar = '●';
		this.table1.Add (this.entry2);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry2]));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.entry3.IsEditable = true;
		this.entry3.MaxLength = 16;
		this.entry3.InvisibleChar = '●';
		this.table1.Add (this.entry3);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry3]));
		w4.TopAttach = ((uint)(1));
		w4.BottomAttach = ((uint)(2));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.Buffer.Text = "Enter text here and use a Crypto function!";
		this.textview1.WidthRequest = 200;
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.WrapMode = ((global::Gtk.WrapMode)(2));
		this.GtkScrolledWindow.Add (this.textview1);
		this.table1.Add (this.GtkScrolledWindow);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow]));
		w6.TopAttach = ((uint)(3));
		w6.BottomAttach = ((uint)(4));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		// Container child table1.Gtk.Table+TableChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.table1.Add (this.hseparator1);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator1]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("IP Address");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Password");
		this.table1.Add (this.label3);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox2.Add (this.table1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table1]));
		w10.Position = 1;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.saveAction.Activated += new global::System.EventHandler (this.OnSaveActionActivated);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.refreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
		this.executeAction.Activated += new global::System.EventHandler (this.OnRC4ActionActivated);
		this.executeAction1.Activated += new global::System.EventHandler (this.OnRot13ActionActivated);
		this.newAction.Activated += new global::System.EventHandler (this.OnNewActionActivated);
		this.entry3.Changed += new global::System.EventHandler (this.OnTextChanged);
		this.entry2.Changed += new global::System.EventHandler (this.OnTextChanged);
	}
}
