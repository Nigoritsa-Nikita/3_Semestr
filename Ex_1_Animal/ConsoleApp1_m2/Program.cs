using System;

namespace ConsoleApp1_m2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Random rand = new Random();
                int number = 0;

                while (true)
                {
                    Console.WriteLine("Вв кол-во животных:");
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number < 1)
                        {
                            Console.WriteLine("Ошибка!(введите положительное число)");
                            continue;
                        }
                        break;
                    }
                    catch { Console.WriteLine("Ошибка!(введите челое, положительное число)"); }
                }
                Mammal Cat = new Mammal("кот");
                Mammal Dog = new Mammal("собака");
                Mammal Cow = new Mammal("корова");
                Mammal Lion = new Mammal("лев");
                Mammal Wolf = new Mammal("волк");

                Mammal[] arrayMammal = new Mammal[] { Cat, Dog, Cow, Lion, Wolf };

                Bug Fly = new Bug("муха");
                Bug Ant = new Bug("муровей");
                Bug Bee = new Bug("пчела");
                Bug Roach = new Bug("таракан");
                Bug Moth = new Bug("моль");

                Bug[] arrayBug = new Bug[] { Fly, Ant, Bee, Roach, Moth };

                Fish Perch = new Fish("окунь");
                Fish Crucian = new Fish("карась");
                Fish Cod = new Fish("треска");
                Fish Flounder = new Fish("камбала");
                Fish Sturgeon = new Fish("осётр");

                Fish[] arrayFish = new Fish[] { Perch, Crucian, Cod, Flounder, Sturgeon };

                for (int i = 0; i < number; i++)
                {
                    int q = rand.Next(0, 3);
                    if (q == 0)
                        arrayMammal[rand.Next(0, 5)].Info();
                    if (q == 1)
                        arrayBug[rand.Next(0, 5)].Info();
                    if (q == 2)
                        arrayFish[rand.Next(0, 5)].Info();
                }
                Console.WriteLine();

                /**
                for (int i = 0; i < number; i++)
                {
                    arrayOfBug[rand.Next(0, 5)].Info();
                }
                Console.WriteLine();

                for (int i = 0; i < number; i++)
                {
                    arrayOfFish[rand.Next(0, 5)].Info();
                }
                Console.WriteLine();
                **/

                Console.WriteLine("Повторить?(да - нажмите 'enter'; нет - введите любой символ)");
                string repeat = Convert.ToString(Console.ReadLine());
                if (repeat != "")
                    break;
            }
        }
    }
    abstract class Animal
    {  
        public abstract string _name { get; set; }
        public abstract int _leg { get; set; }
        public void Info()
        {
            Console.WriteLine(_name + "; кол-во конечностей: " + _leg);
        }
    }
    class Mammal : Animal
    {
        public override string _name { get; set; }
        public override int _leg { get; set; }

        public Mammal(string name)
        {
            _name = name;
            _leg = 4;
        }
    }
    class Bug : Animal
    {
        public override string _name { get; set; }
        public override int _leg { get; set; }

        public Bug(string name)
        {
            _name = name;
            _leg = 6;
        }
    }
    class Fish : Animal
    {
        public override string _name { get; set; }
        public override int _leg { get; set; }
        public Fish(string name)
        {
            _name = name;
            _leg = 0;
        }
    }
}
