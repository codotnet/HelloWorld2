using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld2
{
   public class Program
    {
        static void Main(string[] args)
        {
            Go(null);
        }

        public static void Go(string param)
        {
            if (param != null)
            {
                var a = param.ToString();
            }

            Console.WriteLine("Hello world...!!!!!!");
            Console.WriteLine("Hello saar...!!!!!!");
            Console.ReadLine();
        }
    }
}
