using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AF;


namespace AbstractFactory
{
    class Program
    {       
        static void Main(string[] args)
        {
            Client cl =  new Client( new CocaColaFactory());
            cl.Run();
            cl = new Client(new PepsiFactory());
            cl.Run();
            cl = new Client(new SchweppesFactory());
            cl.Run();
        }
    }
}
