using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherLib
{
	class CirculationLibrary : ILibrary
	{
		public string SystemName { get; set; }
		public string BranchName { get; set; }
	}
}
