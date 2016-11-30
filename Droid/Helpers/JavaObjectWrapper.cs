using System;
namespace NotexDroid.Core.Droid
{
	public class JavaObjectWrapper<T> : Java.Lang.Object
	{
		public T Obj { get; set; }
	}
}
