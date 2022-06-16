using System;
namespace CSClass
{
	public class Child : Parent
    {
        public Child() :base(){
            Console.WriteLine("Chlid():base(10)");
        }
        public Child(string input): base(input)
        {
            Console.WriteLine("Chlid(string input) : base(input) ")
        }
        public void CountChild()
        {
            Child.counter++;
        }
        public Child()
        {
            Console.WriteLine("切縦 持失切");
        }
    }
}