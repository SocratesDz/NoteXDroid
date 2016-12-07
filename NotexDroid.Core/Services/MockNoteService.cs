using System;
using System.Collections.Generic;

namespace NotexDroid.Core
{
	public class MockNoteService
	{
		public MockNoteService()
		{
		}

		public List<Note> Notes()
		{
			List<Note> notes = new List<Note>();
			notes.Add(new Note { Id = "a", Author = "User Test", Title = "Test1", Content = "Test content", CreatedTime = DateTime.Now, ModifiedTime = DateTime.Now });
			notes.Add(new Note { Id = "a", Author = "User Test", Title = "Test2", Content = "Test content with 2", CreatedTime = DateTime.Now, ModifiedTime = DateTime.Now });
			notes.Add(new Note { Id = "a", Author = "User Test", Title = "Test3", Content = "Test content something", CreatedTime = DateTime.Now, ModifiedTime = DateTime.Now });
			notes.Add(new Note { Id = "a", Author = "User Test", Title = "Test42", Content = "Test no content", CreatedTime = DateTime.Now, ModifiedTime = DateTime.Now });

			return notes;
		}
	}
}
