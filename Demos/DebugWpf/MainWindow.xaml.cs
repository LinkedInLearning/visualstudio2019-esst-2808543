using System;
using System.Collections.Generic;
using System.Windows;

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
		private void dataTipsButton_Click(object sender, RoutedEventArgs e)
		{
			ExampleMethod();

		}

		private void ExampleMethod()
		{
			// another way to add a breakpoint within code
			if (System.Diagnostics.Debugger.IsAttached)
			{
				System.Diagnostics.Debugger.Break();
			}
			
			// C# primitive variable type (float, double, short, int, long etc..)

			string sentence = "One word after another.";
			double taxRate = 7.8;


			// types with more properties
			var book = new Book { Title = "How to build better Lambdas ", Price = "12.50M" };
			var birthDate = DateTime.Parse("5/5/1992");


			var sortedNames = new SortedDictionary<string, int>();
			sortedNames.Add("Henry", 45);
			sortedNames.Add("Betsy", 23);
			sortedNames.Add("Wayne", 62);
			sortedNames.Add("Freddie", 38);
			sortedNames.Add("Martin", 55);
			sortedNames.Add("Ralph", 28);

			#region Message
			messageTextBlock.Text = sentence;
			messageTextBlock.Text = taxRate.ToString();

			#endregion
		}

	}

	public class Book
	{
		public string Title { get; set; }
		public string Price { get; set; }
	}
}
