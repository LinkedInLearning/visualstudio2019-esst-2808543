using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCSharp {
  public class Book : Document{
    // classes contain data and code
    public string Title { get; set; }
    public decimal Price { get; set; }

    public long GetWordCount() {
            // comments 
            return 42;
    }
    public void SaveBook() {
      // comments 
      
    }
  }

  public struct FileInformation {
    // structs are primarily for data stores
    public string FileName { get; set; }
    public string Size { get; set; }

    public event EventHandler<EventArgs> SizeChanged;
  }
}
