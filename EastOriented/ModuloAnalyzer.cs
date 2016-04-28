namespace EastOriented
{
    public class ModuloAnalyzer : IAnalyzer
    {
        private readonly int _number;
        private readonly string _result;

        public ModuloAnalyzer(int number, string result)
        {
            _number = number;
            _result = result;
        }

        public void Process(IOutput output, int i)
        {
            if (i%_number == 0)
            {
                output.Write(_result);
            }
        }
    }
}