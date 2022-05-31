using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100)); 
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);

            /*
            List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            */

             List<int> list = new List<int>() { 52,273,32,24};
            list.Remove(52);


            foreach(var item in list)
            {
                Console.WriteLine("Count: "+list.Count+"\titem: "+item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);


            Hamburger nyam = new Hamburger();

            Product productA = new Product();
            productA.name = "포켓몬 빵";
            productA.price = 1500;

            Product productB = new Product() { name = "소금빵", price = 2000 };
            Product productC = new Product() { name = "당근케이크"};


            Method method = new Method();
            Console.WriteLine(method.Multi(52.1, 273));

            Console.WriteLine(method.sum(1,100));

        }
    }
}
