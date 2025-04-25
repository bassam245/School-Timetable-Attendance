using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mange
{
    internal class Studentt : Person
    {
        public enum AttendanceStatus { Present, Absent, Late }
        public int Grade;
        public AttendanceStatus attendanceStatus;
        //constractour take student enformation
        public Studentt(int id, string name, int grade, AttendanceStatus attendanceStatus) : base(id, name)
        {
            Grade = grade;
            this.attendanceStatus = attendanceStatus;
        }
        //override methode to print student information
        public override void Displlaydate()
        {
            base.Displlaydate();
            Console.Write($", Grade: {Grade}, Attendance: {attendanceStatus}");
        }
        // used methode return class rule
        public override string GetRole()
        {
            return "Student";
        }
    }
}
