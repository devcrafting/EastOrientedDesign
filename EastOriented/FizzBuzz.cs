using System.Collections.Generic;

namespace EastOriented
{
    public class FizzBuzz : IOutput
    {
        private IOutput output;

        public FizzBuzz(IOutput output)
        {
            this.output = output;
        }

        public void Play(int i)
        {
            if (i % (3 * 5) == 0)
            {
                output.Write("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                output.Write("Fizz");
            }
            else if (i % 5 == 0)
            {
                output.Write("Buzz");
            }
            else
            {
                output.Write("1");
            }
        }

        public void Write(string str)
        {
        }
    }
}
