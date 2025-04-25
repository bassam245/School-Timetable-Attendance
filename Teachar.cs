using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mange
{
    internal class Teacher : Person
    {
        //creat cllas Properties
        public enum Subject_taught { Math, Science }
        public double ArrivalTime;
        public Subject_taught Subject;
        //constractour take date from teachear
        public Teacher(int id, string name, double ArrivalTime, Subject_taught Subject) : base(id, name)
        {
            this.ArrivalTime = ArrivalTime;
            this.Subject = Subject;
        }
        //check techear come in time or not
        public void Check()
        {
            if (ArrivalTime > 9)
            {
                throw new Exception("You are late ");
            }
            else
            {
                Console.WriteLine("You come in time ");
            }
        }
        //print information of Teacher
        public override void Displlaydate()
        {
            base.Displlaydate();
            Console.Write($" Subject: {Subject}, Arrival Time: {ArrivalTime}");
        }
        //return rule off Teacher
        public override string GetRole()
        {
            return "Teacher";
        }
    }
}
