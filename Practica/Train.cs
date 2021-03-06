﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct Train
    {
        public string Destination { get; set; }
        public int NumberTrain { get; set; }
        public DateTime Time { get; set; }

        public Train(string destination, int numberTrain, DateTime time)
        {
            Destination = destination;
            NumberTrain = numberTrain;
            Time = time;
        }

        public override string ToString()
        {
            return string.Format("Destination: {0}\nNumberTrain: {1}\nTime: {2} \n", Destination, NumberTrain, Time);
        }
    }

    struct Trains
    {
        public List<Train> trains;
        public Trains(List<Train> trains)
        {
            this.trains = trains;
        }

        public void Add(Train st)
        {
            trains.Add(st);
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                
                trains.Add(new Train());
                var str = trains[i];
                Console.WriteLine("Введите данные по {0}-ому рейсу:", i + 1);
                Console.WriteLine("Пункт назначения: ");
                str.Destination = Console.ReadLine();
                Console.WriteLine("Номер поезда: ");
                str.NumberTrain = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Время отправления");

                Console.WriteLine("Введите день отправления: ");
                int day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите час отправления: ");
                int hour = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите минуты отправления: ");
                int minutes = Convert.ToInt32(Console.ReadLine());
                str.Time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day, hour, minutes, 0);
            }
            //return new List<Train>(trains);
        }

        public void PrintDependentTime(DateTime time)//7
        {
            foreach (var item in trains)
            {
                if(item.Time > time)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void PrintDependentDestination(string destination)//8
        {
            foreach (var item in trains)
            {
                if(item.Destination == destination)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void PrintDependentNumberTrain(int numberTrain)//9
        {
            foreach (var item in trains)
            {
                if (item.NumberTrain == numberTrain)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
