
// This file has been generated by the GUI designer. Do not modify.
namespace VotingMultiChain
{
	public partial class MainStationWindow
	{
		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget VotingMultiChain.MainStationWindow
			this.Name = "VotingMultiChain.MainStationWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("MainStationWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(10));
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		}
	}
}
