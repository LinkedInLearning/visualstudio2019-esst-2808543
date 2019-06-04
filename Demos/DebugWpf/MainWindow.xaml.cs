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

		private void steppingButton_Click(object sender, RoutedEventArgs e)
		{
			decimal monthlyPayment;
			decimal rate = 5.6M;

			// step into
			monthlyPayment = Financial.CalculateMonthlyPayment(numberOfMonths: 12,
																												 loanRate: rate,
																												 loanAmount: 1200);

			// step over
			monthlyPayment = Financial.CalculateMonthlyPayment(numberOfMonths: 24,
																									 loanRate: rate,
																									 loanAmount: 2365);


			// step out;
			monthlyPayment = Financial.CalculateMonthlyPayment(numberOfMonths: 36,
																								 loanRate: rate,
																								 loanAmount: 3700);

		}
	}
}
