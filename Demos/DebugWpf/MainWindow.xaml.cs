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
			List<ColorSample> colors = new List<ColorSample>();
			colors.Add(new ColorSample { ColorBrush = new SolidColorBrush(Colors.Blue), ColorName = "Blue" });
			colors.Add(new ColorSample { ColorBrush = new SolidColorBrush(Colors.Orange), ColorName = "Orange" });
			colors.Add(new ColorSample { ColorBrush = new SolidColorBrush(Colors.Yellow), ColorName = "Yellow" });
			this.DataContext = colors;
			this.Loaded += MainWindow_Loaded;
		}
		void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			ColorsListBox.SelectedIndex = 0;
		}
		private void ConditionalButton_Click(object sender, RoutedEventArgs e)
		{
			var currentColor = ColorsListBox.SelectedItem as ColorSample;
			ellipse1.Fill = currentColor.ColorBrush;
		}
		private async void HitCountButton_Click(object sender, RoutedEventArgs e)
		{
			progressTextBlock.Text = string.Empty;
			for (int counter = 1; counter <= 50; counter++)
			{

				progressTextBlock.Text += "ᚙ ";
				await System.Threading.Tasks.Task.Delay(20);

			}
		}

		private void FunctionButton_Click(object sender, RoutedEventArgs e)
		{
			int ticketCount;
			ticketCount = TicketGenerator.GetTicketCount();
			ticketCount = TicketGenerator.GetTicketCount(eventName: "Portland Bike Tour");
			ticketCount = 0;

			ticketCount = TicketGenerator.GetTicketCount(isLocal: true);

		}
		private void AnotherFunctionButton_Click(object sender, RoutedEventArgs e)
		{
			int ticketCount;
			ticketCount = TicketGenerator.GetTicketCount(eventName: "Portland Bike Tour");
		}
	}
}
