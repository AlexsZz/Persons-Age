using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Alice", "Johnson", new DateTime(1990, 5, 20), Gender.Female);
            Console.WriteLine(person.ToString());
            Console.WriteLine("An now she is " + person.Age + " years old");
        }

        public static void ExceptionExample()
        {
            try
            {

            }
            catch (Exception)
            {

            }

        }
    }
}
