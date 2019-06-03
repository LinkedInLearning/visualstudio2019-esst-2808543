using System;
using System.Collections.Generic;
using System.Text;

namespace PublisherLib
{
	public interface ILibrary

	{
		string SystemName { get; set; }
		string BranchName { get; set; }

	}
}
