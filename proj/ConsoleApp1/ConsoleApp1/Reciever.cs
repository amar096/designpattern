using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Reciever
    {
       public Reciever()
        {

        }

        public void ActionOn()
        {
            Console.WriteLine("Recieved Switch ONN");
        }

        public void ActionOff()
        {
            Console.WriteLine("Recieved Switch OFF");
        }

        public void ActionBeamUp()
        {
            Console.WriteLine("Recieved Beam Up");
        }

        public void ActionBeamDown()
        {
            Console.WriteLine("Recieved Beam Down");
        }
    }
}
