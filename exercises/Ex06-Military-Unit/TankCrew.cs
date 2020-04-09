using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06_Military_Unit
{
    public class TankCrew : WeaponSystem
    {
        public void crewintro() //Tank Crew Intro 
        {
            Console.WriteLine("I am Cpl Baughn I will be your Gunner.");
            Console.ReadLine();
            Console.WriteLine("I am LCpl Cavazos I will be your Loader.");
            Console.ReadLine();
            Console.WriteLine("I am PFC Blumelchundia, but everyone call me be Blue I will be your Driver.");
            Console.ReadLine();

        }
        public class Gunner

        {
            public void Cpl() // Gunners words during the fire command (third in order) 
            {
                Console.WriteLine("Identified Tank, range 2000 meters");
                Console.ReadLine();
                TC babers = new TC();
                babers.fire();
                Console.WriteLine("ON THE WAY!");
                Console.ReadLine();
                WeaponSystem BB = new WeaponSystem();
                BB.shooting();
                Console.WriteLine("Target");
                Console.ReadLine();
                babers.TC2();
                Console.WriteLine("Identified");
                Console.ReadLine();
                loader cavazos = new loader();
                cavazos.LCpl();
                babers.fire();
                Console.WriteLine("ON THE WAY!");
                Console.ReadLine();
                BB.shooting();
                Console.WriteLine("Target");
                Console.ReadLine();
                babers.TC3();
                Console.WriteLine("That's All Folks come again for story time!!!");
                Console.ReadLine();

            }

        }
        public class loader // Loaders words during a fire command. (2nd in order) 
        {
            public void LCpl()
            {
                Console.WriteLine("Up!");
                Console.ReadLine();

            }
        }
        public class TC
        {
            public void SSgt() // TC words during the fire command (1st in order) 
            {
                Console.WriteLine("Gunner Sabot 2 Tanks left tank first.");
                Console.ReadLine();
                Console.WriteLine("Driver Move out.");
                driver blue = new driver();
                blue.PFC();
                Console.WriteLine("Diver, Driver!!!!!, DRIVER!!! WAKE UP!");
                blue.PFC1();
                Console.WriteLine("");
            }
            public void fire()
            {
                Console.WriteLine("fire");
            }
            public void TC2()
            {
                Console.WriteLine("Right, tank");
            }
            public void TC3()
            {
                Console.WriteLine("Cease fire, Driver back down.");
            }

        }
    }
    public class driver
    {
        public void PFC() //Driver being a driver :-) You have to love them. 
                          // Do not need to add group this role into the TC
        {
            Console.WriteLine("cricket cricket");
            Console.ReadLine();


        }
        public void PFC1()
        {
            Console.WriteLine("SSgt I wasnt sleep.");
            Console.ReadLine();
        }
    }
}

