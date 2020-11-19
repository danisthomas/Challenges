using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengeCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter me = new Greeter();
            me.SayHello("Daniele");
            me.SayFarwell("Daniele");
            me.GreetingTimeofDay("night");

            Console.ReadKey();
            

            Greeter chad = new Greeter();
            chad.SayHello("Chad");
            chad.SayFarwell("Daniele");
            chad.GreetingTimeofDay("morning");

            Console.ReadKey();
            
        }

    }
}
