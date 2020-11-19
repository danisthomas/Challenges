using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengeCon
{
    class Greeter
    {
       

        public void SayHello(string fName)
            
        {
            Console.WriteLine($"Hello {fName}");
            
        }
        
        public void SayFarwell(string fName)
        {
            Console.WriteLine($"Farewell {fName} have a great day!");

        }

        public void GreetingTimeofDay(string time)
        {
            switch (time)
            {
                case "morning":
                    Console.WriteLine("Good Morning!");
                    break;
                case "afternoon":
                    Console.WriteLine("Good Afternoon!");
                    break;

                case "evening":
                    Console.WriteLine("Good Evening!");
                    break;
                case "night":
                    Console.WriteLine("Good Night!");
                    break;
                
                        

            }
         



           
        }

        
    }
    }
