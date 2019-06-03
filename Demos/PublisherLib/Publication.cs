using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublisherLib {
	public class Publication {

    public string Title { get; set; }
    public DateTime PublicationDate { get; set; }
		public Author Author { get; set; }
	}
}
  