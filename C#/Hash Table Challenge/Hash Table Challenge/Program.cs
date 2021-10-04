using System;
using System.Collections;
namespace Hash_Table_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 88);
            students[2] = new Student(6, "Ragner", 88);
            students[3] = new Student(1, "Luise", 88);
            students[4] = new Student(4, "Levi", 88);
            Hashtable hashStudent = new Hashtable();
            Console.WriteLine(students[1].Id) ;
            for (int i = 0; i < students.Length; i++)
            {
                if (hashStudent.ContainsKey(students[i].Id))
                {
                    Console.WriteLine("Sorry, A student with the same ID already Exists.");
                }
                else
                {
                    hashStudent.Add(students[i].Id, students[i]);
                    Console.WriteLine("The student with ID{0} was added",students[i].Id);
                }
       

            }
            Console.WriteLine("Printing all student in the hash table");
            foreach (Student student in hashStudent.Values)
            {
                Console.WriteLine("ID:{0} Name:{1} GPA {2}",student.Id,student.Name,student.Gpa);
            }

        }
    }
    class Student
    {

        public Student(int id, string name, int gpa)
        {
            this.Id = id;
            this.Name = name;
            this.Gpa = gpa;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gpa { get; set; }
    }

    //2.This is the second way to define a class setter and getter
    //class Student
    //{
    //    int id;
    //    string name;
    //    int gpa;
    //    public Student(int id, string name, int gpa)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.gpa = gpa;

    //    }
    //    public int getId()
    //    {
    //        return this.id;
    //    }
    //    public void setId(int id)
    //    {
    //        this.id = id;
    //    }
    //}
}
