using System;
namespace Ex_7_HashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Киселев М.А.", new DateTime(1995, 10, 24), "Новосибирск", 1497325);
            var person2 = new Person("Канин П.В.", new DateTime(2005, 5, 16), "Иркутск", 1497325);
            var person3 = new Person("Кулябин Ф.Л.", new DateTime(2000, 2, 23), "Братск", 6317829);
            var person4 = new Person("Киселев М.А.", new DateTime(1995, 10, 24), "Новосибирск", 1497325);
            Console.WriteLine("person1 && person2");
            if (person1.GetHashCode() == person2.GetHashCode())
            {
                Console.WriteLine("HashCode: Равны");
                if (person1 == person2)
                {
                    Console.WriteLine("Equals: Равны");
                }
                else
                {
                    Console.WriteLine("Equals: Не равны");
                }
            }
            else
            {
                Console.WriteLine("HashCode: Не равны");
            }
            Console.WriteLine("\nperson1 && person4");
            if (person1.GetHashCode() == person4.GetHashCode())
            {
                Console.WriteLine("HashCode: Равны");
                if (person1 == person4)
                {
                    Console.WriteLine("Equals: Равны");
                }
                else
                {
                    Console.WriteLine("Equals: Не равны");
                }
            }
            else
            {
                Console.WriteLine("HashCode: Не равны");
            }
            Console.WriteLine("\nperson2 && person3");
            if (person2.GetHashCode() == person3.GetHashCode())
            {
                Console.WriteLine("HashCode: Равны");
                if (person2 == person3)
                {
                    Console.WriteLine("Equals: Равны");
                }
                else
                {
                    Console.WriteLine("Equals: Не равны");
                }
            }
            else
            {
                Console.WriteLine("HashCode: Не равны");
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Нажмите любую клавишу для закрытия окна");
        }
    }
    class Person
    {
        public string FIO { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string BirthPlace { get; private set; }
        public int PassportNumber { get; private set; }
        public Person(string fio, DateTime birthDate, string birthPlace, int passportNumber)
        {
            FIO = fio;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            PassportNumber = passportNumber;
        }
        public override int GetHashCode()
        {
            return PassportNumber.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj is Person person && FIO == person.FIO
                && BirthDate == person.BirthDate
                && BirthPlace == person.BirthPlace
                && PassportNumber == person.PassportNumber;
        }
        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Equals(person2);
        }
        public static bool operator !=(Person person1, Person person2)
        {
            return !person1.Equals(person2);
        }
    }
}