using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublisherLib {
	public class Book : Publication {
    #region Properties
    public decimal Price { get; set; }
    public string ISBN { get; set; }
		public int CopiesSold { get; set; }
		#endregion

		const Decimal MAX_PRICE = 120;

    public void UpdatePrice( decimal newPrice) {
      if (newPrice < 0)
      {
        Price = newPrice;
      }

      // call another method
      Console.WriteLine("Done");
      Price = CapPriceAtMaximum(newPrice);
    }
    private decimal CapPriceAtMaximum(decimal currentPrice) {

      // use the private field
      Price = 100M;

      if (currentPrice > 120M)
      {
        return 120M;
      }
      else
      {
        return currentPrice;
      }
    }
    public decimal CalculateBuyerDiscount(decimal currentPrice, BuyerType buyerType) {

      switch (buyerType)
      {
        case BuyerType.Retail:
          currentPrice = Price;
          break;
        case BuyerType.Wholesale:
          currentPrice = Price * .9M;
          break;
        case BuyerType.Academic:
          currentPrice = Price * .8M;
          break;
        case BuyerType.Goverment:
          currentPrice = Price * .85M;
          break;
        default:
          break;
      }
      return currentPrice;
    }
  }
  public enum BuyerType {
    Retail,
    Wholesale,
    Academic,
    Goverment
  }
}
