using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DebugWpf
{
	/// <summary>
	/// Interaction logicc for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			FastProgressBar.IsIndeterminate = true;
			SlowProgressBar.IsIndeterminate = true;
			var nameGen = new RobotNameGenerator.NameGenerator();

			var roboNames = await nameGen.GetRobotNames(12);
			FastListBox.ItemsSource = roboNames;
			FastProgressBar.IsIndeterminate = false;
			var slowNames = await nameGen.GetRobotNamesSlow(12);

			
			SlowListBox.ItemsSource = slowNames;
			SlowProgressBar.IsIndeterminate = false;
		}
	}
}
