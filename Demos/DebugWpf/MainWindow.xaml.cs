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
		private void DemoButton_Click(object sender, RoutedEventArgs e)
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
			var book = new Book { Title = "XML vs. JSON, the modern data dilemma", Price = 65.75M };
			var birthDate = DateTime.Parse("5/5/1992");


			var sortedNames = new SortedDictionary<string, int>();
			sortedNames.Add("Henry", 45);
			sortedNames.Add("Betsy", 23);
			sortedNames.Add("Wayne", 62);
			sortedNames.Add("Freddie", 38);
			sortedNames.Add("Martin", 55);
			sortedNames.Add("Ralph", 28);

			WorkWithXmlData("BookList.xml", true);
			#region Message
			
			messageTextBlock.Text = sentence;
			// look at the "return" value in the locals window.
			messageTextBlock.Text = taxRate.ToString();
			messageTextBlock.Text = GetBookName();
			#endregion
		}
		private void WorkWithXmlData(string xmlFileName, bool useSchema)
		{
			// the locals and Autos window will show
			// variables from this method

			var doc = System.Xml.Linq.XDocument.Load(xmlFileName);
			string text = doc.ToString();
		}
		private string GetBookName() {
			return "Top ten tips for .NET strings.";
		}
	}

	public class Book
	{
		public string Title { get; set; }
		public decimal Price { get; set; }
	}
}
