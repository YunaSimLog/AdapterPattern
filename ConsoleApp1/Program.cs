using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adaptee adaptee = new Adaptee();
            //ITarget target = new Adapter(adaptee);
            //Console.WriteLine(target.GetRequest());

            NewDuck newDuck = new NewDuck();
            newDuck.NewMove();

            OringinDuck oringinDuck = new OringinDuck();
            AdapterDock adapterDock = new AdapterDock(oringinDuck);

            adapterDock.NewMove();
        }
    }
}
