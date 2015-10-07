using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AF
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;
        public Client(AbstractFactory abstractFactory)
        {
            water = abstractFactory.CreateWater();
            bottle = abstractFactory.CreateBottle();
            cover = abstractFactory.CreateCover();
        }

        public void Run()
        {
            bottle.Interact(water);
            cover.Interact(bottle);
        }
    }
}
