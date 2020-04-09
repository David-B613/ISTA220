using System;
using System.Media;

namespace Ex06_Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeComing veni = new HomeComing();
            veni.Icame();
            Console.WriteLine("Choose :1 Go on leave to find a house.\n Choose 2: Go to the field because the Tank is your home!");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Wrong choice buddie, the tank will provide you with all that you need!");
                System.Environment.Exit(0);

            }
            else
                Console.WriteLine("Good choice, it is time to meet your tank crew and prep your tank. You leave for gunnery in two days welcome back chump!\n");
            Console.WriteLine("\n");

            TankCrew crew = new TankCrew();
            crew.crewintro();

            HomeComing vidi = new HomeComing();
            vidi.Isaw();

            WeaponSystem testfire = new WeaponSystem();
            testfire.loading();
            testfire.shooting();

            Coax littlemg = new Coax();
            littlemg.shooting();

            Fifty bigmg = new Fifty();
            bigmg.shooting();

            Console.WriteLine("Test fire complete.");
            Console.WriteLine("\n");


            HomeComing vici = new HomeComing();
            vici.Iconcured();

            TankCrew.TC commander = new TankCrew.TC();
            commander.SSgt();

            TankCrew.loader loader = new TankCrew.loader();
            loader.LCpl();

            TankCrew.Gunner gunner = new TankCrew.Gunner();
            gunner.Cpl();


        }


    }
}
