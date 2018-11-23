using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            CitizenCollection collection = new CitizenCollection();

            collection.Add(new Student(3));

            foreach (var VARIABLE in collection)
            {
                Console.WriteLine(VARIABLE.PassportNumber);
            }




        }
    }
}
