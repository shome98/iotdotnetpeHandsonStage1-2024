using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2               //DO NOT Change namespace name
{
    public class Program                //DO NOT Change class 'Program' name
    {
        public static void Main(string[] args)        //DO NOT Change 'Main' method Signature
        {
            double num;
            System.Console.WriteLine("Enter a Number");
            num=double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Square of {0}} is {1}",num,FindSquare(num));
            System.Console.WriteLine("Cube of {0}} is {1}",num,FindCube(num));
            
        }
        
        
        public static double FindSquare (double num)
        {
            return (num*num);
        }
        
        public static double FindCube  (double num)
        {
            return (num*num*num);
        }

      //Implement methods here. Keep the method 'public' and 'static'
    }
}
