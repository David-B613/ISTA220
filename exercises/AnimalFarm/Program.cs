using System;

namespace AnimalFarm
{
    class Animals
    {

        string name = "";
        string sound = "";
        string color = "";
        
        
        public Animals(string aName, string asound, string acolor)
        {
            name = aName;
            sound = asound;
            color = acolor;
                                  
        }
        public string AnimalsGo()
        {
            Console.WriteLine($"I am {name} and I go {sound} My favorite color is {color}.");
               
            return "";
        }
        
        static void Main(string[] args)
        { 

    Console.Write("This is my farm and there are a lot of animals that would like to meet you!\n");
            Console.Write("What is your name? ");
            string username = ("");
            username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}");
            Console.ReadLine();
                            
            Animals duck = new Animals("Rubber Duck", "quack debug quack debug!", "yellow");
            Animals duck1 = new Animals("Donald Duck", "blah blah blah", "Black");
            Animals duck2 = new Animals("White Duck", "quack!", "Swan White");
            Animals cow = new Animals("Cow", "Mooo Mooo Mooovvveee!", "Green");
            Animals cow1 = new Animals("Cow", "Mooo Mooo STOOOOPP!", "Red");
            Animals cow2 = new Animals("Cow", "Mooo Mooo slllooooowww doooowwnn!", "Yellow");
            Animals pig = new Animals("Pig", "quink quink quink i'm a little piggy!", "pink");
            Animals pig1 = new Animals("Pig", "quink quink quink i'm a BIG piggy!", " hot pink");
            Animals pig2 = new Animals("Pig", "quink quink quink i'm a pretty piggy!", "pretty in");


            Console.Write(duck.AnimalsGo());
            Console.Write(duck1.AnimalsGo());
            Console.Write(duck2.AnimalsGo());
            Console.Write(cow.AnimalsGo());
            Console.Write(cow1.AnimalsGo());
            Console.Write(cow2.AnimalsGo());
            Console.Write(pig.AnimalsGo());
            Console.Write(pig1.AnimalsGo());
            Console.Write(pig2.AnimalsGo());
            
                           
           
        
            
        }
        
    }
}