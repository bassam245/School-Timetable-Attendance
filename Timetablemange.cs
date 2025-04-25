using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static student_mange.TimetableEntry;

namespace student_mange
{
    internal class TimetableManager
    {
        public TimetableEntry timetableEntry;
        public List<TimetableEntry> timetableEntries;
        public TimetableManager()
        {
            timetableEntries = new List<TimetableEntry>();
        }
        //methode to add items
        public void Add(TimetableEntry entry)
        {
            if (timetableEntries == null)
            {
                throw new ArgumentException("List is ");

            }
            if (timetableEntries.Count >= 5)
            {
                throw new InvalidOperationException("list out the range");
            }
            timetableEntries.Add(entry);
        }
        //displlay all date 
        public void DisplayData(List<TimetableEntry> timetableEntries)
        {
            for (int i = 0; i < timetableEntries.Count; i++)
            {
                Console.WriteLine($"enter {i + 1} : ");
                timetableEntries[i].Displlaydate();
            }
        }
        //LInear searsh

        public void SearchBySubject(TimetableEntry.taught subject)
        {
            bool found = false;
            foreach (var entry in timetableEntries)
            {
                if (entry.Taught == subject)
                {
                    found = true;

                    Console.WriteLine($"Subjrct is fonud ");
                    break;

                }
            }

            //check found or not 
            if (!found)
            {
                Console.WriteLine($"Subject {subject}  not found");

            }

        }
        //sort start time 
        public void SortByStartTime()
        {
            for (int i = 0; i < timetableEntries.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < timetableEntries.Count; j++)
                {
                    if (timetableEntries[j].Start_time < timetableEntries[min].Start_time)
                    {
                        min = j;
                    }
                }
                var temp = timetableEntries[min];
                timetableEntries[min] = timetableEntries[i];
                timetableEntries[i] = temp;


            }
        }

    }
}
