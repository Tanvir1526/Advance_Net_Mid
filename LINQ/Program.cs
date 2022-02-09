using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        private static object s;

        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            Random rand = new Random();
            for(int i=0;i<=1000;i++)
            {
                student s = new student();
                s.Id = 1;
                s.Name="Tanivr"+i;
                s.cgpa = rand.NextDouble() * (4.00 - 2.50) + 2.50;
                student.Add(s);
            }
            
            var filteredstu = (from i in students
                               where s.cgpa > 3.75
                               select s.Id).ToList();

            /*int [] arr =new int[] { 12, 15, 61, 898, 45, 56, 65 };
                foreach(var i in arr)
            {
                if (i>20)
                {

                }*/
        }

           
        }
    }
}
