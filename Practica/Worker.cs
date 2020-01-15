using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Worker
    {
        public string Surname { get; set; }
        public string Position { get; set; }
        public int Year { get; set; }
        public int Experience { get; set; }

        public Worker() { }
        public Worker(string surname, string position, int year)
        {
            Surname = surname;
            Position = position;
            Year = year;
        }

        public override string ToString()
        {
            return string.Format("Surname: {0}\nPosition: {1}\nYear: {2} \nExperience: {3}\n", Surname, Position, Year, Experience);
        }
    }

    class Workers
    {
        private List<Worker> workers;

        public Workers()
        {
            workers = new List<Worker>();
            FillList(2);
            InitilizeLists();
        }
        public Workers(List<Worker> workers)
        {
            this.workers = workers;

            InitilizeLists();
        }

        public void Add(Worker st)
        {
            workers.Add(st);
        }

        public void InitilizeLists()
        {
            DateTime time = DateTime.Now;
            foreach (var item in workers)
            {
                item.Experience = time.Year - item.Year;
            }
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                workers.Add(new Worker());
                Console.WriteLine("Введите данные по {0}-ому работнику:", i + 1);
                Console.WriteLine("Фамилия:");
                workers[i].Surname = Console.ReadLine();
                Console.WriteLine("Занимаемая должность:");
                workers[i].Position = Console.ReadLine();
                Console.WriteLine("Год поступления:");
                workers[i].Year = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PrintDependentExperience(int experience)//6
        {
            foreach (var item in workers)   
            {
                if(item.Experience > experience)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
