using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct Worker
    {
        public string Surname { get; set; }
        public string Position { get; set; }
        public int Year { get; set; }
        public int Experience { get; set; }
        public Worker(string surname, string position, int year)
        {
            DateTime time = DateTime.Now;
            Surname = surname;
            Position = position;
            Year = year;
            Experience = time.Year - year;
        }

        public override string ToString()
        {
            return string.Format("Surname: {0}\nPosition: {1}\nYear: {2} \nExperience: {3}\n", Surname, Position, Year, Experience);
        }
    }

    struct Workers
    {
        private List<Worker> workers;
        public Workers(List<Worker> workers)
        {
            this.workers = workers;
        }

        public void Add(Worker st)
        {
            workers.Add(st);
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                workers.Add(new Worker());
                var str = workers[i];
                Console.WriteLine("Введите данные по {0}-ому работнику:", i + 1);
                Console.WriteLine("Фамилия:");
                str.Surname = Console.ReadLine();
                Console.WriteLine("Занимаемая должность:");
                str.Position = Console.ReadLine();
                Console.WriteLine("Год поступления:");
                str.Year = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PrintDependentExperience(int experience)//6
        {
            DateTime time = DateTime.Now;
            foreach (var item in workers)   
            {
                if(time.Year - item.Year > experience)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
