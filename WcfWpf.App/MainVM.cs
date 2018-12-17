using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WcfWpf.App
{
	public class MainVM : INotifyPropertyChanged
	{
		public MainVM()
		{
			counter = new Counter();
			StartCount = new RelayCommand(OnStartCount);
		}

		public ICommand StartCount { get; set; }
	
		private async void OnStartCount(object obj)
		{
			await IncrementCounter();
		}

		private async Task IncrementCounter()
		{
			for (int i = 0; i < 50; i++)
			{
				Status = "In progeress";
				await Task.Run(() =>
				{
					System.Threading.Thread.Sleep(1000);
				});
				Counter.Value++;
				PropertyChanged(this, new PropertyChangedEventArgs("Counter"));
			}
			Status = "Finished";
		}

		public string Status { get; set; } = "New";

		private Counter counter;
		public Counter Counter
		{
			get
			{
				return counter;
			}
			set
			{
				if (counter != value)
				{
					counter = value;
					PropertyChanged(this, new PropertyChangedEventArgs("Counter"));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate { };
	}
}
