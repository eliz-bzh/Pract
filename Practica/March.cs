using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct March
    {
        public string Nachalniy_punkt_marshryta { get; set; }
        public string Konechniy_punkt_marshryta { get; set; }
        public int Nomer_marshryta { get; set; }
        public March(string StartPoint, string FinalPoint, int Number)
        {
            Nachalniy_punkt_marshryta = StartPoint;
            Konechniy_punkt_marshryta = FinalPoint;
            Nomer_marshryta = Number;
        }

        public override string ToString()
        {
            return (string.Format("Начальный пункт назначения: {0}\nКонечный пункт назначения: {1}\nНомер маршрута: {2}", Nachalniy_punkt_marshryta, Konechniy_punkt_marshryta, Nomer_marshryta));
        }

    }

    struct Marches
    {
        private List<March> marches;

        public Marches(List<March> students)
        {
            this.marches = students;
        }

        public void AddMarch(March st)
        {
            marches.Add(st);
        }

        public void RemoveMarch(March st)
        {
            marches.Remove(st);
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var str = marches[i];
                marches.Add(new March());
                Console.WriteLine("Введите данные по {0}-ому маршруту:", i + 1);
                Console.WriteLine("Название начального пункта маршрута: ");
                str.Nachalniy_punkt_marshryta = Console.ReadLine();
                Console.WriteLine("Название конечного пункта маршрута: ");
                str.Konechniy_punkt_marshryta = Console.ReadLine();
                Console.WriteLine("Номер маршрута");
                str.Nomer_marshryta = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PrintDependentNomerMarshryta(int march)//10
        {
            foreach (var el in marches)
            {
                if (el.Nomer_marshryta == march)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void PrintDependentMarch(string march)//11
        {
            foreach (var el in marches)
            {
                if (el.Konechniy_punkt_marshryta.Contains(march) || el.Nachalniy_punkt_marshryta.Contains(march))
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}
