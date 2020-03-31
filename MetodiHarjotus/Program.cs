using System;
using System.Collections.Generic;

namespace MetodiHarjotus
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            person1.Age = 16;
            person2.Age = 19;
            person3.Age = 24;
            person1.Name = "Mikko";
            person2.Name = "Kalle";
            person3.Name = "Tiina";
            person1.Hobbies.Add("Golf, Tennis");
            person2.Hobbies.Add("Jalkapallo");
            person3.Hobbies.Add("Uinti, Pianonsoitto, Jääkiekko");
            person1.Friend = person2;
            person2.Friend = person1;
            person1.Greet();
            person1.FormanGreet();
            person3.FormanGreet();
            person2.FormanGreet();
            person1.AgeCheck();
            person3.AgeCheck();
            person1.GrowingOld(10);
            person1.AgeCheck();
            Console.WriteLine(person1.FriendCompare());
            Console.WriteLine(person3.FriendCompare());
        }   
    }
}
