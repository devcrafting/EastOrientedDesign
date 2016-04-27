using System.Collections.Generic;

namespace EastOriented
{
    public class FizzBuzz
    {
        private readonly IEnumerable<IAnalyzer> _analyzers;
        private readonly IOutput _output;

        public FizzBuzz(IEnumerable<IAnalyzer> analyzers, IOutput output)
        {
            _analyzers = analyzers;
            _output = output;
        }

        public void Play(int i)
        {
            var outputWriter = new OutputWriter(i, _output);
            foreach (var analyzer in _analyzers)
            {
                analyzer.Process(outputWriter, i);
            }
            outputWriter.Flush();
        }

        private class OutputWriter : IOutput
        {
            private readonly int _i;
            private readonly IOutput _output;
            private string _result = string.Empty;

            public OutputWriter(int i, IOutput output)
            {
                _i = i;
                _output = output;
            }

            public void Write(string str)
            {
                _result += str;
            }

            public void Flush()
            {
                if (string.IsNullOrEmpty(_result))
                {
                    _result = _i.ToString();
                }
                _output.Write(_result);
            }
        }
    }
}
