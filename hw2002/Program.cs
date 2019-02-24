using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,4,7,43,7,32};
            Array.Sort(arr);
            PrintArray(arr);

            string[] arr2 = { "first", "second", "third", "fourth" };
            Array.Sort(arr2);
            PrintArray(arr2);

            Person first = new Person(1, 24, 1.820f, "Amity");
            Person second = new Person(2, 21, 1.650f, "Lee");
            Person third = new Person(3, 55, 1.720f, "Ronni");
            Person fourth = new Person(4, 59, 1.60f, "Shulamit");
            Person fifth = new Person(5, 28, 1.80f, "Baker");

            Person[] persons = { second, first, third, fourth, fifth };
            PrintPersonArray(persons);

            Console.WriteLine();

            Array.Sort(persons);
            PrintPersonArray(persons);

            Console.WriteLine();

            Console.WriteLine("Sort by Id");
            Array.Sort(persons, new PersonCompareById());
            PrintPersonArray(persons);

            Console.WriteLine("Sort by Age");
            Array.Sort(persons, new PersonCompareByAge());
            PrintPersonArray(persons);

            Console.WriteLine("Sort by Height");
            Array.Sort(persons, new PersonCompareByHeight());
            PrintPersonArray(persons);

            Console.WriteLine("Sort by Name");
            Array.Sort(persons, new PersonCompareByName());
            PrintPersonArray(persons);
            Console.WriteLine();

            Console.WriteLine("by age");
            Array.Sort(persons, Person.AgeComparer);
            PrintPersonArray(persons);
        }

        static void PrintPersonArray(Person[] anyperson)
        {
            foreach(var person in anyperson)
            {
                Console.WriteLine(person);
            }
        }

        static void PrintArray(Array anyarr)
        {
            foreach(var item in anyarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
