using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Invoker
    {
        private ICommand On;
        private ICommand Off;

      
        public Invoker(ICommand On, ICommand Off)
        {
            this.On = On;
            this.Off = Off;
        }

        public void SwitchOn()
        {
            this.On.Execute();
        }

        public void SwitchOff()
        {
            this.Off.Execute();
        }
    }   
}
