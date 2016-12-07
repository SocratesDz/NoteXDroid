using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace NotexDroid.Core
{
	public class AzureNotesService
	{
		private const string SERVICE_URL = "http://notex.azurewebsites.net/";
		private IMobileServiceClient _client;
		private IMobileServiceTable<Note> _table;

		public AzureNotesService()
		{
			_client = new MobileServiceClient(SERVICE_URL);

			_table = _client.GetTable<Note>();
		}

		public Task<List<Note>> GetNotes()
		{
			return _table.ToListAsync();
		}
	}
}
