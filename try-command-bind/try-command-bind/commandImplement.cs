using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

namespace try_command_bind
{
    /// <summary>
    /// 
    /// </summary>
    class commandImplement : ICommand
    {
        public String CommandName { get => GetType().ToString(); }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
            Console.WriteLine(parameter.ToString());
            
        }
    }
}
