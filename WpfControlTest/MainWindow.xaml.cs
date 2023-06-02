using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlTest
{
	public class info
	{
		public string info1 { get; set; }
		public string info2 { get; set; }
		public ObservableCollection<info> IC { get; set; }

		public info(string info1, string info2)
		{
			this.info1 = info1;
			this.info2 = info2;

			IC = new ObservableCollection<info>();
		}

		public override string ToString()
		{
			return $"1 is| {info1} | 2 is| {info2}";
		}
	}

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		private ObservableCollection<info> ix;

		public MainWindow()
		{
			InitializeComponent();

			ix = new ObservableCollection<info>();

			info i = new info("info 1a", "info 1b");
			i.IC.Add(new info("info 1a1a", "info 1a1b"));
			i.IC.Add(new info("info 1a2a", "info 1a2b"));
			i.IC.Add(new info("info 1a3a", "info 1a3b"));

			ix.Add(i);

			i = new info("info 2a", "info 2b");
			i.IC.Add(new info("info 2a1a", "info 2a1b"));
			i.IC.Add(new info("info 2a2a", "info 2a2b"));
			i.IC.Add(new info("info 2a3a", "info 2a3b"));

			ix.Add(i);

			
			i = new info("info 3a", "info 3b");
			i.IC.Add(new info("info 3a1a", "info 3a1b"));
			i.IC.Add(new info("info 3a2a", "info 3a2b"));
			i.IC.Add(new info("info 3a3a", "info 3a3b"));

			ix.Add(i);

			OnPropertyChanged(nameof(InfoCollection));
		}


		public string SampleText1 => "SampleText";

		public ObservableCollection<info> InfoCollection
		{
			get => ix;
			set
			{
				ix = value;
				OnPropertyChanged();
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string memberName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
		}

		private void BtnDebug_OnClick(object sender, RoutedEventArgs e)
		{
			ObservableCollection<info> iy = ix;

			int a = 1;
		}
	}
}
