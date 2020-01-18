using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class CommandSwitchOn : ICommand
    {
        Reciever _reciever;

        public CommandSwitchOn(Reciever reciever)
        {
            _reciever = reciever;
        }
        public void Execute()
        {
            Console.WriteLine("SwitchOn");
            _reciever.ActionOn();
        }
    }
}
