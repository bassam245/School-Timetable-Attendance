using student_mange;

namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate  5 teachers
            Teacher t1 = new Teacher(524093, "En.Bassam", 9, Teacher.Subject_taught.Math);
            Teacher t2 = new Teacher(3444, "En.Ramadan", 12, Teacher.Subject_taught.Science);
            Teacher t3 = new Teacher(30944, "En.Amal", 8, Teacher.Subject_taught.Science);
            Teacher t4 = new Teacher(90944, "En.youseef", 3, Teacher.Subject_taught.Math);
            Teacher t5 = new Teacher(30944, "En.ali", 22, Teacher.Subject_taught.Science);

            // Instantiate  3 students
            Studentt s1 = new Studentt(524012, "Yomna ", 90, Studentt.AttendanceStatus.Present);
            Studentt s2 = new Studentt(524076, "Saif", 99, Studentt.AttendanceStatus.Late);
            Studentt s3 = new Studentt(524056, "Mallek", 55, Studentt.AttendanceStatus.Absent);
            //oCreate a TimetableManager object.
            TimetableManager timetableManager = new TimetableManager();
            //  Add up to 5 TimetableEntry
            TimetableEntry entry1 = new TimetableEntry(TimetableEntry.taught.Math, t1, 11, 10);
            TimetableEntry entry2 = new TimetableEntry(TimetableEntry.taught.Science, t2, 4, 8);
            TimetableEntry entry3 = new TimetableEntry(TimetableEntry.taught.Science, t3, 12, 5);
            TimetableEntry entry4 = new TimetableEntry(TimetableEntry.taught.Math, t4, 6, 12);
            TimetableEntry entry5 = new TimetableEntry(TimetableEntry.taught.Science, t5, 8, 1);
            TimetableEntry entry6 = new TimetableEntry(TimetableEntry.taught.Science, t5, 10, 1);
            // Create a TimetableManager object
            TimetableManager timetableManager1 = new TimetableManager();
            timetableManager1.Add(entry1);
            timetableManager1.Add(entry2);
            timetableManager1.Add(entry3);
            timetableManager1.Add(entry4);
            timetableManager1.Add(entry5);
            //to check handle is work
            //timetableManager1.Add(entry6);
            //displlay oll date in list 
            Console.WriteLine("taple mange before sort");
            timetableManager1.DisplayData(timetableManager1.timetableEntries);
            //sort start time

            timetableManager1.SortByStartTime();
            //Displlay after sort
            Console.WriteLine("taple mange after sort");
            timetableManager1.DisplayData(timetableManager1.timetableEntries);
            //Use Linear Search to find and display entries by subject.
            Console.WriteLine("Searsh by subject off entry 3");
            timetableManager1.SearchBySubject(entry3.Taught);
            //oCreate an AttendanceQueueManager object.
            AttendanceQueueManager a1 = new AttendanceQueueManager();
            //oAdd 3 students to the queue.
            a1.Enqueue(s1);
            a1.Enqueue(s2);
            a1.Enqueue(s3);
            //  oProcess the queue and mark all students as Present.
            a1.Display();


        }
    }
}
