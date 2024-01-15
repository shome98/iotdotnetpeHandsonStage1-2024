using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals1             //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    { 
        public static void Main(string[] args)        //DO NOT CHANGE 'Main' Signature
        {
            string name,country;
            int age;
                
            Console.WriteLine("Enter your name :");
            name=System.Console.ReadLine();
            
            System.Console.WriteLine("Enter your age :");
            age=int.Parse(System.Console.ReadLine());
          
            System.Console.WriteLine("Enter your country :");
            country=System.Console.ReadLine();
            
            System.Console.WriteLine("Welcome {0}. Your age is {1} and you are from {2}",name,age,country);
            //Fill the code here
        }
    }
}
