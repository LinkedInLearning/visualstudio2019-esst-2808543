using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugWpf
{
	class TicketGenerator {

		public static decimal CalculateTicketPrice(int ticketCount, decimal ticketPrice, decimal discountRate) {
			return (ticketCount * ticketPrice) * discountRate;
		}

		public static decimal GetDiscountRate(DiscountType discountType) {

			switch (discountType)
			{
				case DiscountType.Group:
					return .9M;
					;
				case DiscountType.Employee:
					return .6M;
					;
				case DiscountType.TravelAgent:
					return .8M;
					;
				default:
					return 1M;
					;
			}
		}

		public static int GetTicketCount() {

			return 25000;

		}

		public static int GetTicketCount(bool isLocal) {

			if (isLocal)
			{
				return 1500;
			}

			else
			{
				return 25000;
			}

		}
		public static int GetTicketCount(string eventName) {
			if (eventName == "Build Conference")
			{
				return 40000;

			}
			else
			{
				return 20000;
			}
		}
	}



	public enum DiscountType {
		Group,
		Employee,
		TravelAgent
	}
}
