#region + Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

// user name: jeffs
// created:   4/21/2023 6:47:08 PM

namespace WpfControlSamples.Windows
{
	public interface IMsgWin
	{
		string Msg { get; set; }
		string MsgLine { set; }
	}
}
