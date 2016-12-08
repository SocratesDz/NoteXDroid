using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views;
using System.Threading.Tasks;
using Android.Content;

namespace NotexDroid.Core.Droid
{
	[Activity(Label = "NotexDroid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		NotesAdapter adapter;
		ListView listView;
		ProgressBar progressBar;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var service = new AzureNotesService();
			adapter = new NotesAdapter(this);

			listView = (ListView) FindViewById(Resource.Id.noteList);
			listView.Adapter = adapter;

			listView.Visibility = ViewStates.Gone;

			progressBar = FindViewById<ProgressBar>(Resource.Id.progressbar);
			progressBar.Indeterminate = true;


			RunOnUiThread(async () => { 
				var notes = await service.GetNotes();
				adapter.SetNotes(notes);

				progressBar.Indeterminate = false;
				progressBar.Visibility = ViewStates.Gone;
				listView.Visibility = ViewStates.Visible;
			});

		}

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.menu, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId) 
			{
				case Resource.Id.login_menu:
					// Login 

					break;
				case Resource.Id.add_menu:
					// Call NoteDetailActivity
					Intent intent = new Intent(this, typeof(NoteDetailActivity));
					StartActivity(intent);
					break;
			}

			return base.OnOptionsItemSelected(item);
		}
	}
}

