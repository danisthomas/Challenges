using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Thursday_Challenge_Nov_12
{
    [TestClass]
    public class Week1challenge
    {
        
        
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Daniele";
            string lastName = "Thomas";
            int age = 50;
            

        }
        [TestMethod]
        public void FavoriteBooksorMoviesArray()
        {
            string[] Movies = { "My Cousin Vinny", "Sweet Home Alabama", "Star Wars", "Harry Potter" };

            
        }
        [TestMethod]
        public void DateList()
        {
            List<DateTime> kids = new List<DateTime>();
            DateTime kbday = new DateTime(1995, 04, 02);
            DateTime bbday = new DateTime(1996, 11, 06);
            DateTime cbday = new DateTime(2013, 06, 04);
            DateTime now = DateTime.Now;


            kids.Add(kbday);
            kids.Add(bbday);
            kids.Add(cbday);
            kids.Add(now);
            kids.Add(new DateTime(2020, 12,25));
          


            

        }
        [TestMethod]
        public void AgeVariable()
        {
            int age = 50;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);
	    }
		
	
                
        
        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int sleep = 3;
            if (sleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (sleep >= 8 && sleep < 10)
            {
                Console.WriteLine("You Should be pretty rested");
            }
            else if (sleep > 4 && sleep < 8)
            {
                Console.WriteLine("Bummer"); 
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            
                       


        }
        [TestMethod]
        public void HowHasYourDayBeen()
        {   
            String Feelings = "Great";
            switch (Feelings)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine("It is a day to be good on");
                    break;
                case "Okay":
                    Console.WriteLine("Hopefully it will get better from here");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;

                    
            }
        }
        [TestMethod]
        public void Supercalif()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            Console.WriteLine(letter);
        }

        [TestMethod]
        public void OnlyI()
        {
             string name = "Supercalifragilisticexpialidocious";
             foreach (char letter in name)
             if (letter == 'i')
             {
                 Console.WriteLine(letter);
             }
             else
             {
                 Console.WriteLine("Not an i");
             }
        } 
        [TestMethod]
        public void Countletters()
        {
             string name = "Supercalifragilisticexpialidocious";
             int count = 0;
             for (int i = 0; i < name.Length; i++)
             {
               count++;

                

             }
               Console.WriteLine(count);

        }
    

	

    }
    
}
