using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Order
    {
        public int Platelshik { get; set; }
        public int Poluchatel { get; set; }
        public int Sum { get; set; }

        public Order() { }
        public Order(int platelshik, int poluchatel, int sum)
        {
            Platelshik = platelshik;
            Poluchatel = poluchatel;
            Sum = sum;
        }

        public override string ToString()
        {
            return (string.Format("Расчетный счет плательщика: {0}\nРасчетный счет получателя: {1}\nПеречисляемая сумма (в рублях): {2}", Platelshik, Poluchatel, Sum));
        }
    }

    class Orders
    {
        private List<Order> orders;

        public Orders()
        {
            orders = new List<Order>();
            FillList(2);
        }

        public Orders(List<Order> orders)
        {
            this.orders = orders;
        }

        public void AddMarch(Order st)
        {
            orders.Add(st);
        }

        public void RemoveMarch(Order st)
        {
            orders.Remove(st);
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                orders.Add(new Order());
                Console.WriteLine("Введите данные по {0}-ому заказу:", i + 1);
                Console.WriteLine("Расчетный счет плательщика: ");
                orders[i].Platelshik = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Расчетный счет получателя: ");
                orders[i].Poluchatel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Перечисляемая сумма (в рублях): ");
                orders[i].Sum = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PrintDependentPlatelshik(int platelshik)//20
        {
            foreach (var el in orders)
            {
                if (el.Platelshik == platelshik)
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}
