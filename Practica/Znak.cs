using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Znak
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Zodiak { get; set; }
        public int[] Date { get; set; } = new int[3];

        public Znak() { }
        public Znak(string n, string sN, string z, int[] d)
        {
            Name = n;
            SurName = sN;
            Zodiak = z;
            Date = d;
        }

        public override string ToString()
        {
            return "Фамилия: " + this.SurName + "\nИмя: " + this.Name + "\nЗнак зодиака: "
            + this.Zodiak;
        }
    }

    class Znaks
    {
        private List<Znak> znaks;

        public Znaks()
        {
            znaks = new List<Znak>();
            FillList(2);
        }

        public Znaks(List<Znak> znaks)
        {
            this.znaks = znaks;
        }

        public void AddMarch(Znak st)
        {
            znaks.Add(st);
        }

        public void RemoveMarch(Znak st)
        {
            znaks.Remove(st);
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                znaks.Add(new Znak());
                Console.WriteLine("Введите данные по {0}-ому человеку:", i + 1);
                Console.WriteLine("Фамилия: ");
                znaks[i].SurName = Console.ReadLine();
                Console.WriteLine("Имя: ");
                znaks[i].Name = Console.ReadLine();
                Console.WriteLine("Знак зодиака: ");
                znaks[i].Zodiak = Console.ReadLine();
                Console.WriteLine("Введите 3 числа даты:");
                for (int j = 0; j != 3; ++j)
                {
                    znaks[i].Date[j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void PrintDependentSurname(string surname)//15
        {
            foreach (var el in znaks)
            {
                if (el.SurName == surname)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void PrintDependentZodiak(string zodiak)//16
        {
            foreach (var el in znaks)
            {
                if (el.Zodiak == zodiak)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void PrintDependentDate(int mounth)//17
        {
            foreach (var el in znaks)
            {
                if (el.Date[1] == mounth)
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}
