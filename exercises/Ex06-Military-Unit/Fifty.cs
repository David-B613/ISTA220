using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06_Military_Unit
{
    class Fifty : WeaponSystem
    {
        public override void shooting()
        {
            Console.WriteLine("50 Cal: thump thump thump thump.");
        }
    }
}
