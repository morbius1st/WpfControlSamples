#region using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#endregion


// projname: $projectname$
// itemname: Messages
// username: jeffs
// created:  4/21/2023 6:53:51 PM

namespace WpfControlSamples.Windows.Support
{
	public class Messages 
	{
	#region private fields

		private static readonly Lazy<Messages> instance =
			new Lazy<Messages>(() => new Messages());

		private IMsgWin msgWin;

	#endregion

	#region ctor

		private Messages()
		{

		}

	#endregion

	#region public properties

		public static Messages Instance => instance.Value;

		public IMsgWin Win
		{
			get => msgWin;
			set => msgWin = value;
		}


	#endregion

	#region private properties

	#endregion

	#region public methods

	#endregion

	#region private methods

	#endregion

	#region event consuming

	#endregion

	#region event publishing

	#endregion

	#region system overrides

		public override string ToString()
		{
			return $"this is {nameof(Messages)}";
		}

	#endregion
	}
}