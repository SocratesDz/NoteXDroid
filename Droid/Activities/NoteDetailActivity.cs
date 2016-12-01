using System;
using Android.App;
using Android.Widget;

namespace NotexDroid.Core.Droid
{
	[Activity]
	public class NoteDetailActivity : Activity
	{
		Note note;
		EditText titleEdit;
		EditText contentEdit;
		MockNoteService service;

		public NoteDetailActivity()
		{
			note = new Note();
			service = new MockNoteService();
		}

		protected override void OnCreate(Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.NoteDetail);

			titleEdit = FindViewById<EditText>(Resource.Id.title_textview);
			contentEdit = FindViewById<EditText>(Resource.Id.content_textview);

			var idValue = Intent.GetIntExtra(Constants.NOTE_DETAIL_INTENT, Constants.INTENT_DEFAULT_VALUE);
			if (idValue != Constants.INTENT_DEFAULT_VALUE)
			{
				var notes = service.Notes();
				note = notes.Find(n => n.Id == idValue);
				titleEdit.Text = note.Title;
				contentEdit.Text = note.Content;
			}
		}
	}
}
