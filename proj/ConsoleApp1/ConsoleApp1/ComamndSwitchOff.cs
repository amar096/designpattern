using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CommandSwitchOff : ICommand
    {
        Reciever _reciever;
       public CommandSwitchOff(Reciever reciever) 
        {
            _reciever = reciever;
        }
        public void Execute()
        {
            Console.WriteLine("SwitchOff");
            _reciever.ActionOff();
        }
    }
}
