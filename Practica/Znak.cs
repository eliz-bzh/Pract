using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct Znak
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Zodiak { get; set; }
        public int[] Date { get; set; }
        public Znak(string n, string sN, string z, int[] d)
        {
            if (d.Length != 3)
                throw new Exception("Массив должен состоять из трёх чисел.");
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

    struct Znaks
    {
        private List<Znak> znaks;

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
                var str = znaks[i];
                znaks.Add(new Znak());
                Console.WriteLine("Введите данные по {0}-ому человеку:", i + 1);
                Console.WriteLine("Фамилия: ");
                str.SurName = Console.ReadLine();
                Console.WriteLine("Имя: ");
                str.Name = Console.ReadLine();
                Console.WriteLine("Знак зодиака: ");
                str.Zodiak = Console.ReadLine();
                Console.WriteLine("Введите 3 числа даты:");
                for (int j = 0; j != 3; ++j)
                {
                    str.Date[j] = Convert.ToInt32(Console.ReadLine());
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
