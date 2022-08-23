using System;
//REQUIRED FOR DECLARING ARRAYLIST
using System.Collections;

namespace Practice_space
{
    class Program
    {
        //HASHTABLES
        static void Main(string[] args)
        {
            //CHALLENGE- TAKE ALL VALUES FROM STUDENT ARRAY AND INSERT INTO HASHTABLE
            //IF ID IS SAME SKIP STUDENT AND DISPLAY ERROR: "Sorry, a student with the same ID already exists."

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragnar", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);


            Hashtable studentsTable = new Hashtable();

            foreach (Student studentIndex in students)
            {
                if (studentsTable.ContainsKey(studentIndex.Id))
                {
                    Console.WriteLine("Sorry, a student with the same ID already exists.");
                } else
                {
                    studentsTable.Add(studentIndex.Id, studentIndex);
                }
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0},", value.Id);
                Console.WriteLine("Student Name:{0},", value.Name);
                Console.WriteLine("Student GPA:{0},", value.GPA);
            }
            Console.ReadLine();
        }
    }

    class Student
    {
        //property called Id
        public int Id { get; set; }

        //property called Name
        public string Name { get; set; }

        //property called GPA
        public float GPA { get; set; }

        //constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}