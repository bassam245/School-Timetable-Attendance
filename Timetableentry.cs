using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mange
{
    internal class TimetableEntry
    {
        //creat cllas Properties
        public enum taught { Math, Science }
        public taught Taught;
        public Teacher teacher;
        public double Start_time;
        public double End_time;
        //constractour take date from teachear
        public TimetableEntry(taught taught, Teacher teacher, double Start_time, double End_time)
        {
            this.Taught = taught;
            this.Start_time = Start_time;
            this.End_time = End_time;
            this.teacher = teacher;
        }

        //print date 
        public void Displlaydate()
        {
            Console.WriteLine($"Subject: {Taught}, Teacher: {teacher.GetName()},Time: {Start_time} - {End_time}");
        }

    }
}