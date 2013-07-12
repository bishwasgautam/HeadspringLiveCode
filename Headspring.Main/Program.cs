using System;
using Headspring.Computations;

namespace Headspring.Main
{
    public class Program
    {
        private static Computation computation;

        //Entry point
        public static void Main()
        {
            computation = new Computation();
            //start =3 end =3
            Console.Write(computation.FizzBuzz(3, 3));

            Console.Write(computation.FizzBuzz(2, 150));

            Console.ReadKey();
        }
    }
}