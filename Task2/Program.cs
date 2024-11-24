using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.ToLower().Replace(" ", "");

            bool result = true;
            for (int i = 0; i < str.Length/2; i++) 
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    result = false;
                    
                    break;
                }

            }
            if (result)
            
                Console.WriteLine("Предложение является палиндромом");

            
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey();
            
          
        }

    }
}
