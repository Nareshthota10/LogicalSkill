using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            for(i= 1;i <= 100; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine("fizz");
                }
               else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if((i%3==0) & (i %5 == 0))
                    {
                    Console.WriteLine("fizzbuzz");
                }

            }
           // Console.ReadLine();

            var text = Console.ReadLine();
            string reversestring = "";
            int length;

            length = text.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + text[length];
                length--;
            }
            Console.WriteLine(reversestring);

            Console.ReadLine();

            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
