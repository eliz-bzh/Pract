using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Student
    {
        public string Surname { get; set; }
        public int NumberGroup { get; set; }
        public int[] Marks { get; set; } = new int[5];

        public Student(string surname, int numberGroup, int[] marks)
        {
            this.Surname = surname;
            this.NumberGroup = numberGroup;
            this.Marks = marks;
        }

        public override string ToString()
        {
            return string.Format("Surname: {0}\nNumberGroup: {1}\n", Surname, NumberGroup);
        }
    }

    class Students
    {
        private List<Student> students;

        public Students(List<Student> students)
        {
            this.students = students;
        }

        public void AddStudent(Student st)
        {
            students.Add(st);
        }

        public void RemoveStudent(Student st)
        {
            students.Remove(st);
        }

        public void findStudent(String name)
        {
            foreach (var el in students)
            {
                if (el.Surname.Contains(name))
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void AverageMarkGreater4()//1
        {
            foreach (var el in students)
            {
                double average = 0;
                foreach(var i in el.Marks)
                {
                    average += i;
                }
                if((average /= el.Marks.Length) > 4)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void Have45()//2
        {
            foreach (var el in students)
            {
                if(el.Marks.Contains(4) && el.Marks.Contains(5))
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void HaveA2()//3
        {
            foreach(var el in students)
            {
                if (el.Marks.Contains(2))
                {
                    Console.WriteLine(el);
                }
            }
        }


    }
}
