using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace NotexDroid.Core
{
	[DataTable("Notes")]
	public class Note
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("content")]
		public string Content { get; set; }

		[JsonProperty("author")]
		public string Author { get; set; }

		[JsonProperty("createdAt")]
		public DateTime CreatedTime { get; set; }

		[JsonProperty("updatedAt")]
		public DateTime ModifiedTime { get; set; }

		[Version]
		public string Version { get; set; }
	}
}
