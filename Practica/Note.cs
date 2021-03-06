﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    struct Note
    {
        public string Famaly { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int[] Birthday { get; set; }
        public Note(string famaly, string name, string phone, int[] birtday)
        {
            if (birtday.Length != 3)
                throw new Exception("Массив должен состоять из трёх чисел.");
            Famaly = famaly;
            Name = name;
            Phone = phone;
            Birthday = birtday;
        }
        
        public override string ToString()
        {
            return "Фамилия: " + this.Famaly + "\nИмя: " + this.Name + "\nНомер телефона: "
            + this.Phone;
        }
    }

    class Notes
    {
        private List<Note> notes;

        public Notes(List<Note> note)
        {
            this.notes = note;
        }

        public void AddMarch(Note st)
        {
            notes.Add(st);
        }

        public void RemoveMarch(Note st)
        {
            notes.Remove(st);
        }

        public void FillList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                var str = notes[i];
                notes.Add(new Note());
                Console.WriteLine("Введите данные по {0}-ому ноте:", i + 1);
                Console.WriteLine("Фамилия: ");
                str.Famaly = Console.ReadLine();
                Console.WriteLine("Имя: ");
                str.Name = Console.ReadLine();
                Console.WriteLine("Номер телефона: ");
                str.Phone = Console.ReadLine();
                Console.WriteLine("Введите 3 числа даты:");
                for (int j = 0; j != 3; ++j)
                {
                    str.Birthday[j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void PrintDependentPhone(string phone)//12
        {
            foreach (var el in notes)
            {
                if (el.Phone == phone)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void PrintDependentMounth(int mounth)//13
        {
            foreach (var el in notes)
            {
                if (el.Birthday[1] == mounth)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void PrintDependentSurname(string surname)//14
        {
            foreach (var el in notes)
            {
                if (el.Famaly == surname)
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}

