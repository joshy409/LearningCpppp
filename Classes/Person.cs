using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public Person()
        {

        }
        public Person(string name)
        {
            this.Name = name;
        }
        public void Introduce(string to)
        {
            Console.WriteLine("hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
        public string UserName { get; set; }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }

        public int Age
        {   
            get { var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        
    }
}
