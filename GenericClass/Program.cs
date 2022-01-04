using System;
using System.Collections.Generic;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //OurGen<int> ourGen = new OurGen<int>(12);

            //OurGen<string> ourGenstring = new OurGen<string>("Sam");

            //ourGen.Display();

            //ourGenstring.Display();

            List<Emp> listEmps = new List<Emp>
            {
                new Emp{EmpId = 1, EmpDesig= "Member", DOJ = new DateTime(day:12, month: 12, year: 2021), EmpName= "Suresh"},
               new Emp{EmpId = 2, EmpDesig= "TL", DOJ = new DateTime(day:10, month: 1, year: 2021), EmpName= "Ramesh"},
               new Emp{EmpId = 3, EmpDesig= "Manager", DOJ = new DateTime(day:11, month: 2, year: 2021), EmpName= "Mahesh"},
               new Emp{EmpId = 4, EmpDesig= "Member", DOJ = new DateTime(day:8, month: 3, year: 2021), EmpName= "Rakesh"},
               new Emp{EmpId = 5, EmpDesig= "HOD", DOJ = new DateTime(day:7, month: 4, year: 2021), EmpName= "Rajesh"},
            };

            foreach(var emp in listEmps)
            {
                Console.WriteLine("EmpId = {0}  EmpDesignation= {1} DOJ = {2} Name = {3}", emp.EmpId, emp.EmpDesig, emp.DOJ, emp.EmpName  );
            }

            SortedList<int, string> nmes = new SortedList<int, string>
            {
                {1,"Rahul" },
                {2, "Sharma" },
                {4, "Jain" },
                {10, "Singh" }

            };
            int id = int.Parse(Console.ReadLine());

            if(nmes.ContainsKey(id))
            {
                Console.WriteLine("Output is  " + nmes[id]);

            }
            else
                Console.WriteLine("Not exist");
          

            Console.ReadKey();
        }
    }
}
