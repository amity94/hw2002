using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2002
{
    class Person : IComparable<Person>
    {
        //SETTERS AND GETTERS
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        private static readonly IComparer<Person> idComparer;
        private static readonly IComparer<Person> ageComparer;
        private static readonly IComparer<Person> heightComparer;
        private static readonly IComparer<Person> nameComparer;

        public static IComparer<Person> IDComparer { get { return idComparer; } }
        public static IComparer<Person> AgeComparer { get { return ageComparer; } }
        public static IComparer<Person> HeightComparer { get { return ageComparer; } }
        public static IComparer<Person> NameComparer { get { return nameComparer; } }

        private static IComparer<Person> DefaultComparer;



        public Person(int id, int age, float height, string name)
        {
            this.Id = id;
            this.Age = age;
            this.Height = height;
            this.Name = name;
        }

        static Person()
        {
            idComparer = IDComparer;
            ageComparer = AgeComparer;
            heightComparer = HeightComparer;
            nameComparer = NameComparer;
        }

        public static void ModifyDefaultComparer(string any)
        {
           
        }


        //public static IComparer<Person> GetDefaultComparer()
        //{
            
        //}

        public override string ToString()
        {
            return $"Id: {Id}, Age: {Age}, Height: {Height}, Name: {Name}";
        }

        public int CompareTo(Person other)
        {
            return this.Id - other.Id;
        }
    }


}
