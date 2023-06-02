#region using

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WpfControlSamples.DataStructures;
using WpfControlSamples.Windows.Support;

#endregion

// projname: WpfControlSamples
// itemname: MainWindow
// username: jeffs
// created:  4/21/2023 6:26:37 PM

namespace WpfControlSamples.Windows
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged, IMsgWin
	{
		private string msg;
		private Messages M;

		private AssistDict ad;
		private DictDataItem di1;

		private SettingSample ss1;

	#region private fields

	#endregion

	#region ctor

		public MainWindow()
		{
			ss1 = new SettingSample();
			ad = new AssistDict();

			InitializeComponent();

			M = Messages.Instance;
			M.Win = this;

			OnPropertyChanged(nameof(SetgSample));
			OnPropertyChanged(nameof(SetgTree));

		}

	#endregion

	#region public properties

		public static List<HelpInfo> CtrlsDlgHelpInfo { get; set; } = new List<HelpInfo>();

		public SettingSampleData SetgSample => ss1.SetgSampleData;

		public SettingSampleTree SetgTree => ss1.SetgSampleTree;

		public Dictionary<string, DictDataItem> DictItems => DictionaryDataSample.SampleDictionary;

		public DictDataItem Di
		{
			get => di1;
			set
			{
				di1 = value;
				OnPropertyChanged();
			}
		}

		public string Msg
		{
			get => msg;
			set
			{
				msg += value;
				OnPropertyChanged();
			}
		}

		public string MsgLine
		{
			set
			{
				msg += value + "\n";
				OnPropertyChanged(nameof(Msg));
			}
		}

	#endregion

	#region private properties

	#endregion

	#region public methods

	#endregion

	#region private methods

	#endregion

	#region event consuming

		
		private void BtnDebug_OnClick(object sender, RoutedEventArgs e)
		{
			SettingSampleTree t = SetgTree;
			SettingSampleData d = SetgSample;
			List<ItemSample> l = SetgSample.ItemSampleList;

			int a = 1;

		}


		private void BtnShoDict1_OnClick(object sender, RoutedEventArgs e)
		{
			ad.ShowDict1(DictionaryDataSample.SampleDictionary);
		}

		private void BtnExit_OnClick(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

	#endregion

	#region event publishing

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string memberName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
		}

	#endregion

	#region system overrides

		public override string ToString()
		{
			return "this is MainWindow";
		}

	#endregion
	}
}