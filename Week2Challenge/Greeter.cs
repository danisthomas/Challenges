using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week2Challenge
{
    [TestClass]
    public class Greeter
    {
        public string Name { get; set; }
        
        
            [TestMethod]
        public void HelloName()
        {
            Greeter Girl = new Greeter();
            Girl.Name = "Daniele";
            Console.WriteLine("Hello " + Girl.Name);


        }
        [TestMethod]
        public void FarewellName()
        {
            Greeter Boy = new Greeter();
            Boy.Name = "Chad";
            Console.WriteLine("Have a great day " + Boy.Name + "!");

        }
        [TestMethod]
        public void MyTestMethod()
        {

        }
        
    }       
}
