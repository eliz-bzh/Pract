using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //AER0FL0TS tS = new AER0FL0TS(new List<AER0FL0T> {
            //    new AER0FL0T("Ce",2,"3"),
            //    new AER0FL0T("De",6,"3"),
            //    new AER0FL0T("Ae",1,"3")
            //});
            //tS.PrintDependentNumber();
            //Students students = new Students(new List<Student>
            //{
            //    new Student("bozhkova", 795, new int[] {10,5,4,2,8}), //5.8
            //    new Student("korobachka", 795, new int[] {2,2,3,1,8}), //3.2
            //    new Student("mat", 795, new int[] {10,9,5,7,8}) //7.8
            //});
            //students.AverageMarkGreater4();

            //Workers workers = new Workers(new List<Worker>
            //{
            //    new Worker("Liz", "1 sort", 2019),
            //    new Worker("Dasha", "1 sort", 2010),
            //    new Worker("Kate", "1 sort", 2000)
            //});
            //workers.PrintDependentExperience(2);

            Trains trains = new Trains();
            trains.PrintDependentTime(new DateTime());

            Console.ReadKey();
        }
    }
}
