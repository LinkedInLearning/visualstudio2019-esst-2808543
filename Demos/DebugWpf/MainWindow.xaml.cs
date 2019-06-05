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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void GetNameButton_Click(object sender, RoutedEventArgs e)
		{
			var gen = new RobotNameGenerator.NameGenerator();
			var robotName = gen.GetRobotName();

			outputTextblock.Text = robotName;
		}

		public const int NAME_COUNT = 9;

		private void AllNamesButton_Click(object sender, RoutedEventArgs e)
		{
			var gen = new RobotNameGenerator.NameGenerator();
			var allNames = gen.GetRobotNames(NAME_COUNT);

			AllNamesListBox.ItemsSource = allNames;

			
		}
	}
}
