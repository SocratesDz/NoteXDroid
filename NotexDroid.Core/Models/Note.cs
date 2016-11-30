using System;
namespace NotexDroid.Core
{
	public class Note
	{
		public int Id
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public string Content
		{
			get;
			set;
		}

		public string Author
		{
			get;
			set;
		}

		public DateTime CreatedTime
		{
			get;
			set;
		}

		public DateTime ModifiedTime
		{
			get;
			set;
		}
	}
}
