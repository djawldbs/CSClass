﻿using System;

namespace CSClass
{
    public class Cat { 
        public int Age { get; set; }


        public Cat() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }

        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("냐옹냐옹 짓습니다."); }
    }
}