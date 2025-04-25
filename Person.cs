using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mange
{
    internal abstract class Person
    {
        //intiliz porperty
        public int Id;
        private string Name;
        //constractour take date 
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //print date 
        public virtual void Displlaydate()
        {
            Console.Write($"ID: {Id}, Name: {Name}");
        }
        //return private name 
        public string GetName()
        {
            return Name;
        }
        //return rule off class to mak effient by abstract
        public abstract string GetRole();
    }
}
