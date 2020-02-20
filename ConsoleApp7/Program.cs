using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[50] ;
            Console.WriteLine("enter names");
            for (int i = 0; i < 5; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("names are");
                for(int j=0;j<5;j++)
                {
                    Console.WriteLine(names[j]);
                }
            
           
        }
    }
}
