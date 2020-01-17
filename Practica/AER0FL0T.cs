using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct AER0FL0T
    {
        public string Destination { get; set; }
        public int Number { get; set; }
        public string TypePlain { get; set; }
        public AER0FL0T(string destination, int number, string typePlain)
        {
            Destination = destination;
            Number = number;
            TypePlain = typePlain;
        }

        public override string ToString()
        {
            return string.Format("Destination: {0}\nNumber: {1}\nTypePlain: {2}\n", Destination, Number, TypePlain);
        }
    }

    struct AER0FL0TS
    {
        private List<AER0FL0T> aER0FL0Ts;
        public AER0FL0TS(List<AER0FL0T> aER0FL0Ts)
        {
            this.aER0FL0Ts = aER0FL0Ts;
        }
        public void Add(AER0FL0T st)
        {
            aER0FL0Ts.Add(st);
        }

        public void DependentDestination(String destination)//4
        {
            foreach (var item in aER0FL0Ts)
            {
                if(item.Destination == destination)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void DependentTypePlain(String typePlain)//5
        {
            foreach (var item in aER0FL0Ts)
            {
                if (item.TypePlain == typePlain)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                aER0FL0Ts.Add(new AER0FL0T());
                var str = aER0FL0Ts[i];
                Console.WriteLine("Введите данные по {0}-ому рейсу:", i + 1);
                Console.WriteLine("Пункт назначения:");
                str.Destination = Console.ReadLine();
                Console.WriteLine("Номер рейса:");
                str.Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Тип самолёта:");
                str.TypePlain = Console.ReadLine();
            }
        }

        public void PrintDependentNumber()//4
        {
            aER0FL0Ts = aER0FL0Ts.OrderBy(x => x.Number).ToList();
            foreach (var item in aER0FL0Ts)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintDependentDestination()//5
        {
            aER0FL0Ts = aER0FL0Ts.OrderBy(x => x.Destination).ToList();
            foreach (var item in aER0FL0Ts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
