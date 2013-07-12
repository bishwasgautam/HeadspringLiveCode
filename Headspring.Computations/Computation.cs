using System;
using System.Text;

namespace Headspring.Computations
{
    public class Computation
    {
        private readonly StringBuilder myOutput;

        public Computation()
        {
            myOutput = new StringBuilder();
        }

        //Returns String Output
        public String FizzBuzz(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if ((i%3 == 0) && (i%5 == 0))
                    myOutput.AppendLine("FIZZ BUZZ");


                else if (i%3 == 0)
                {
                    myOutput.AppendLine("FIZZ");
                }
                else if (i%5 == 0)
                    myOutput.AppendLine("BUZZ");


                else
                    myOutput.AppendLine(i.ToString());
            }


            return myOutput.ToString();
        }
    }
}