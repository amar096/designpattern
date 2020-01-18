using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CommandBeamDown : ICommand
    {      
        public CommandBeamDown()
        {
            
        }
        public void Execute()
        {
            Console.WriteLine("BeamDown");            
        }

    }
}
