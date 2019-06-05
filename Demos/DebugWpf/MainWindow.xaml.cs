using System.Windows;

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

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			FastListBox.ItemsSource = null;
			SlowListBox.ItemsSource = null;
		}
	}
}
