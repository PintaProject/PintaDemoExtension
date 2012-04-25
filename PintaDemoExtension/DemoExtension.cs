using System;
using Pinta.Core;

namespace PintaDemoExtension
{
	[Mono.Addins.Extension]
	public class DemoExtension : IExtension
	{
		#region IExtension Members
		public void Initialize ()
		{
			Console.WriteLine ("Initialising demo extension");
		}

		public void Uninitialize ()
		{
			Console.WriteLine ("Deinitialising demo extension");
			// Currently not showing up when deactivating in Pinta...
		}
		#endregion
	}
}

