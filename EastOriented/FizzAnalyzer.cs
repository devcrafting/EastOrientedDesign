namespace EastOriented
{
    public class FizzAnalyzer : IAnalyzer
    {
        public void Process(IOutput output, int i)
        {
            if (i % 3 == 0)
            {
                output.Write("Fizz");
            }
        }
    }
}