using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace NotexDroid.Core.Droid
{
	[Activity(Label = "NotexDroid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		NotesAdapter adapter;
		ListView listView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var service = new MockNoteService();
			adapter = new NotesAdapter(this, service.Notes());

			listView = (ListView) FindViewById(Resource.Id.noteList);
			listView.Adapter = adapter;
		}
	}
}

