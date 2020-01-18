using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CommanBeamUp : ICommand
    {
        public CommanBeamUp()
        {
            
        }
        public void Execute()
        {
            Console.WriteLine("BeamUp");            
        }
    }
}
