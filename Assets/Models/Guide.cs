using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShowDataBinding.Models {
	public class Guide : INotifyPropertyChanged {
		private string _guideName;
		public string GuideName {
			get
			{
				return _guideName;
			}
			set
			{
				SetProperty(ref _guideName, value);
			}
		}
		private string _homeCity;
		public string HomeCity {
			get
			{
				return _homeCity;
			}
			set
			{
				SetProperty(ref _homeCity, value);
			}
		}

		public int NumberOfToursLed { get; set; }

		private void SetProperty<T>(ref T field, T value, [CallerMemberName] string name = "") {
			if (!EqualityComparer<T>.Default.Equals(field, value))
			{
				field = value;
				var handler = PropertyChanged;
				if (handler != null)
				{
					handler(this, new PropertyChangedEventArgs(name));
				}
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
