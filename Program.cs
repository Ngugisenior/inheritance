using System;

namespace firstConsoleProject {
    class Program {
        class Animal {
            //variables Declaration
            public string name;
            public int age;
            public float happiness;

            //methods
            public void PrintBase () {
                Console.WriteLine ("NAME: " + name);
                Console.WriteLine ("AGE: " + age);
                Console.WriteLine ("HAPINESS: " + happiness);
            }

        }
        //Derived Classes
        class Dog : Animal {
            //Variable Declaration
            public int spotCount;
            //method
            public void Bark () {
                Console.WriteLine ("Wuf!");
                base.happiness = +1;
            }
        }

        class Cat : Animal {
            //variable declaration
            public int cuteness;
            //Method
            public void Meow () {
                Console.WriteLine ("meow!");
                base.happiness = +9;
            }
        }

        static void Main (string[] args) {
            //Instantiating a class
            Dog spotty = new Dog ();
            spotty.name = "spotty";
            spotty.age = 4;
            spotty.spotCount = 25;
            spotty.PrintBase ();
            spotty.Bark ();
            Console.WriteLine ("New Happiness:" + spotty.happiness);

            Cat Heisenberg = new Cat ();
            Heisenberg.name = "Heisenberg";
            Heisenberg.age = 2;
            Heisenberg.cuteness = 25;
            Heisenberg.PrintBase ();
            Heisenberg.Meow ();
            Console.WriteLine ("New Happiness:" + Heisenberg.happiness);

            Console.Read ();
        }
    }
}