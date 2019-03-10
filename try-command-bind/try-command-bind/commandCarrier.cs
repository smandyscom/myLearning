using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace try_command_bind
{
    public class commandCarrier
    {
        public String Now { get => DateTime.Now.ToString(); }

        /// <summary>
        /// Return a command instant
        /// </summary>
        public ICommand Command { get => new commandImplement(); }
    }
}
