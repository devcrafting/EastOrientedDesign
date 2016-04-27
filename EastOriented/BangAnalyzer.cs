namespace EastOriented
{
    public class BangAnalyzer : IAnalyzer
    {
        public void Process(IOutput output, int i)
        {
            if (i % 7 == 0)
            {
                output.Write("Bang");
            }
        }
    }
}