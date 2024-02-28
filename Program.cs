using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> demoList = new List<int>();
            demoList.Add(1);
            demoList.Add(2);
            demoList.Add(3);
            demoList.Add(4);

            Console.WriteLine(demoList.Count);

            //List<string> demoList2 = new List<string>();

            //List<string> demoList2 = new List<string>();

            string[] cars = { "Toyota", "Nissan", "Honda" };

            List<string> carList = new List<string>(cars);

            foreach (string x in carList)
            {
                Console.WriteLine(x);
            }

            carList.AddRange(carList);
            foreach (string x in carList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(carList.Contains("Toyota"));

            Console.WriteLine(carList.Equals(demoList));

            List<string> cars2 = new List<string>();

            cars2 = carList;

            foreach (string x in cars2)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
