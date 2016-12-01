using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace NotexDroid.Core.Droid
{
	public class NotesAdapter : BaseAdapter<Note>
	{
		List<Note> data;
		Activity context;

		public NotesAdapter(Activity context)
		{
			this.data = new List<Note>();
			this.context = context;
		}

		public NotesAdapter(Activity context, IEnumerable<Note> notesData)
		{
			this.data = new List<Note>(notesData);
			this.context = context;
		}

		public override Note this[int position]
		{
			get
			{
				return data[position];
			}
		}

		public override int Count
		{
			get
			{
				return data.Count;
			}
		}

		public override long GetItemId(int position)
		{
			return 0;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			Note note = data[position];
			View view = convertView;
			if (view == null)
				view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
			view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = note.Title;

			view.Click += delegate {
				Intent detailIntent = new Intent(context, typeof(NoteDetailActivity));
				detailIntent.PutExtra(Constants.NOTE_DETAIL_INTENT, note.Id);
				context.StartActivity(detailIntent);
			};

			return view;
		}
	}
}
