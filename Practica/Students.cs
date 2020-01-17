using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct Student
    {
        public string Surname { get; set; }
        public int NumberGroup { get; set; }
        public int[] Marks { get; set; }

        public Student(string surname, int numberGroup, int[] marks)
        {
            if (marks.Length != 5)
                throw new Exception("Массив должен состоять из пяти чисел.");
            this.Surname = surname;
            this.NumberGroup = numberGroup;
            this.Marks = marks;
        }

        public override string ToString()
        {
            return string.Format("Surname: {0}\nNumberGroup: {1}\n", Surname, NumberGroup);
        }
    }

    struct Students
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

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                students.Add(new Student());
                var str = students[i];
                Console.WriteLine("Введите данные по {0}-ому студенту:", i + 1);
                Console.WriteLine("Фамилию: ");
                str.Surname = Console.ReadLine();
                Console.WriteLine("Номер группы: ");
                str.NumberGroup = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите 5 оценок:");
                for(int j = 0; j != 5; ++j)
                {
                    str.Marks[j] = Convert.ToInt32(Console.ReadLine());
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
