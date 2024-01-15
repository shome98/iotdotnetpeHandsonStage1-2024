using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2  //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
        public static void Main(string[] args)     //DO NOT change the 'Main' method signature
        {
            Console.WriteLine("Enter the number of pizzas bought : ");
            int costofpizzas = int.Parse(Console.ReadLine()) * 200;
            Console.WriteLine("Enter the number of puffs bought : ");
            int costofpuffs = int.Parse(Console.ReadLine()) * 40;
            Console.WriteLine("Enter the number of pepsi bought : ");
            int costofpepsis = int.Parse(Console.ReadLine()) * 120;
            
            int total=costofpizzas+costofpuffs+costofpepsis;
            
            double GST = total * 0.12;
            double CESS = total * 0.05;
            
            Console.WriteLine("Bill Details\n");
            Console.WriteLine("Cost of Pizzas :{0}",costofpizzas);
            Console.WriteLine("Cost of Puffs :{0}",costofpuffs);
            Console.WriteLine("Cost of Pepsis :{0}",costofpepsis);
            Console.WriteLine("GST 12% : {0}",GST);
            Console.WriteLine("CESS 5% : {0}",CESS);
            Console.WriteLine("Total Price :{0}",total);
            
            
            //Implement the code here
        }
    }
}
