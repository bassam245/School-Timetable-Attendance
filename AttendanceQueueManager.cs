using System;

namespace student_mange
{
    internal class AttendanceQueueManager
    {
        public Studentt studentt;
        Studentt[] Array;
        int size;
        int front;
        int rear;
        int count;

        public AttendanceQueueManager()
        {
            size = 5; // حجم الصف
            Array = new Studentt[size];
            front = -1;
            rear = -1;
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return (rear + 1) % size == front;
        }

        public void Enqueue(Studentt student)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Error: Queue is full.");
            }

            if (IsEmpty())
            {
                front = 0; 
            }

            rear = (rear + 1) % size;
            Array[rear] = student;
            count++;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Cannot remove from queue because it is empty.");
                return;
            }

            
            front = (front + 1) % size;
            count--;

          
        }


        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements:");
            int index = front;
            for (int i = 0; i < count; i++)
            {
                if (Array[index] != null)
                {
                    Array[index].Displlaydate();
                    Console.WriteLine();
                }
                index = (index + 1) % size;
            }
        }
    }
}