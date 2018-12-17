using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WcfWpf.App
{
	public class RelayCommand : ICommand
	{
		private readonly Action<object> Handler;

		public RelayCommand(Action<object> handler)
		{
			Handler = handler;
		}
		public event EventHandler CanExecuteChanged;// = delegate { };


		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			Handler(parameter);
		}
	}
}
