using System;

namespace Structure
{
    struct Person{
        public string name;
        public int age;

         public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class StructureOOP
    {

        static void Main(string[] args)
        {
            Person person;
            person.name = "aaaaaa";
            person.age = 345;
            System.Console.WriteLine(person);
            Person s = ReturnPerson();
            System.Console.WriteLine(s.age+ " "+ s.name);

        }
        static Person ReturnPerson()
        {
            string name = "aaa";
            int age = 43;
            // Person p;
            // Person n = new Person("sfdf", 543);
            // System.Console.WriteLine("name {0} and age {1}", n.name, n.age);

            // p.name = name;
            // p.age = age;
            // return p;
            return new Person(name, age);
        }
    }
}