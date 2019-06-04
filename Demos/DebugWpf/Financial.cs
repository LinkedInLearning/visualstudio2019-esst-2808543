using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugWpf
{
  class Financial
  {
    public static decimal CalculateMonthlyPayment(int numberOfMonths, decimal loanRate, decimal loanAmount)
    {
      // simplified formula
      decimal perMonth = 0;
      decimal perMonthWithLoanRate = 0;
    

      perMonth = loanAmount / numberOfMonths;
      perMonthWithLoanRate = perMonth * loanRate;
      return perMonthWithLoanRate;

    }
  }
}
