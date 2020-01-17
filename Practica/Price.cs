using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct Price
    {
        public string Name { get; set; }
        public string Shop { get; set; }
        public double CostInRubli { get; set; }

        public Price(string name, string shop, double costInRubli)
        {
            Name = name;
            Shop = shop;
            CostInRubli = costInRubli;
        }

        public override string ToString()
        {
            return (string.Format("Название товара: {0}\nНазвание магазина: {1}\nСтоимость товара(в рублях): {2}", Name, Shop, CostInRubli));
        }
    }

    struct Prices
    {
        private List<Price> prices;

        public Prices(List<Price> prices)
        {
            this.prices = prices;
        }

        public void AddMarch(Price st)
        {
            prices.Add(st);
        }

        public void RemoveMarch(Price st)
        {
            prices.Remove(st);
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var str = prices[i];
                prices.Add(new Price());
                Console.WriteLine("Введите данные по {0}-ому магазину:", i + 1);
                Console.WriteLine("Название товара: ");
                str.Name = Console.ReadLine();
                Console.WriteLine("Название магазина: ");
                str.Shop = Console.ReadLine();
                Console.WriteLine("Стоимость в рублях: ");
                str.CostInRubli = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PrintDependentShop(string shop)//18
        {
            foreach (var el in prices)
            {
                if (el.Shop == shop)
                {
                    Console.WriteLine(el);
                }
            }
        }


        public void PrintDependentName(string name)//19
        {
            foreach (var el in prices)
            {
                if (el.Name == name)
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}
