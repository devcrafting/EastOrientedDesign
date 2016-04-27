namespace EastOriented
{
    public class BuzzAnalyzer : IAnalyzer
    {
        public void Process(IOutput output, int i)
        {
            if (i % 5 == 0)
            {
                output.Write("Buzz");
            }
        }
    }
}