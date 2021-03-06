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
            Console.WriteLine(method.multiply(1, 10));
            Console.WriteLine(Method.Abs(-100));

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));

            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-52.273));

            Console.WriteLine(MyMath.Abs(2223456789L));
            Console.WriteLine(MyMath.Abs(-2223456789L));


            Box1 box1 = new Box1(10, 10);
            box1.width = -10;
            Console.WriteLine("box1의 면적은 : "+box1.Area());

            Box2 box2 = new Box2(10, -10);
            box2.setWidth(-10);
            Console.WriteLine("box2의 면적은 : " + box2.Area());

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box의 면적은 : " + box.Area);

            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(10));
            Console.WriteLine(Fibonacci.Get(100));
            Console.WriteLine(Fibonacci.Get(1000));

            // List<Dog> dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            //List<Cat> cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                 new Cat(), new Cat(), new Cat()
            };
            /*
            foreach(var item in dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            foreach(var item in cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
            */
            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();

                var dog = item as Dog;
                if(dog!=null) dog.Bark();

                var cat = item as Cat;
                if(cat!=null) cat.Meow();


                //((Dog)item).Bark();
                if(item is Dog)
                {
                    //item.Bark(); //이런거 안됨
                    ((Dog)item).Bark();
                }else if(item is Cat)
                {
                    Cat cat= (Cat)item;
                    cat.Meow();
                }

                Child childA = new Child();
                child childB = new child("string");

                Parent parent = new Parent();
                Child child = new Child();
                parent.CountParent();
                chlid.CountParent();
                Console.WriteLine("p counter:  "+parent.counter+" / c counter: "+Chlid.counter);
                parent.CountParent();
                Console.WriteLine("p counter:  "+parent.counter+" / c counter: "+Chlid.counter);
                child.CountParent();
                Console.WriteLine("p counter:  "+parent.counter+" / c counter: "+Chlid.counter);

            }
        }
    }
}
