using System;
using System.Collections.Generic;
using System.Text;

namespace MetodiHarjotus
{
    public class Person
    {
        public string Name;
        public int Age;
        public List<string> Hobbies = new List<string>();
        public Person Friend;


        public Person()
        {

        }

        public void Greet()
        {
            Console.WriteLine($"Terve! miten menee? {Name}");
        }

        public void FormanGreet()
        {
            Console.WriteLine($"Terve! {Name}. Jolla on ikää {Age} ja harrastan {Hobbies[0]}");
        }

        public bool AgeCheck()
        {
            if (Age < 18)
            {
                FormanGreet();
                Console.WriteLine($"Hei! nimeni on {Name}. Olen alaikäinen");
                return false;
            }
            else
            {
                FormanGreet();
                Console.WriteLine($"Hei! nimeni on {Name}. Olen täysi-ikäinen");
                return true;
            }
        }

        public void GrowingOld(int years)
        {
            Age += years;
        }

        public string FriendCompare()
        {
            if (Friend == null)
            {
                return $"{Name}. Olet yksinäinen";
            }
            if (Age > Friend.Age)
            {
                return $"{Name}. Sinä olet vanhempi";
                
            }
            else
            {
                return $"{Name}. Sinä olet vanhempi";
            }
        }
    }
}
