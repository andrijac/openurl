using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenUrl
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			#region Help

			if (args.Length == 0)
			{
				Help();
				DebuggerStop();
				return;
			}

			#endregion Help

			string url = args[0];

			url = FixUrl(url);

			try
			{
				System.Diagnostics.Process.Start(url);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			DebuggerStop();
		}

		private static string FixUrl(string url)
		{
			string[] schemes = { "http:", "https:", "ftp:", "file:" };

			var query = schemes.Where(s => url.StartsWith(s));

			if (query.Count() == 0)
			{
				return string.Concat("http://", url);
			}

			return url;
		}

		private static void DebuggerStop()
		{
			if (Debugger.IsAttached)
			{
				Console.ReadLine();
			}
		}

		private static void Help()
		{
			Console.WriteLine("openurl [url]");
		}
	}
}