using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       public static void Main(string[] args)
        {
            Reciever reciever = new Reciever();
            Invoker invoker = new Invoker(new CommandSwitchOff(reciever),new CommandSwitchOn(reciever));

            invoker.SwitchOn();
            invoker.SwitchOff();
        }
    }
}
