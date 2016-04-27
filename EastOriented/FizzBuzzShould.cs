using Moq;
using NFluent;
using Xunit;

namespace EastOriented
{
    public class FizzBuzzShould
    {
        private readonly Mock<IOutput> _output;
        private readonly FizzBuzz _fizzBuzz;

        private string _result = string.Empty;

        public FizzBuzzShould()
        {
            _output = new Mock<IOutput>();
            _output.Setup(x => x.Write(It.IsAny<string>())).Callback<string>(x => _result += x);
            _fizzBuzz = new FizzBuzz(new IAnalyzer[] { new FizzAnalyzer(), new BuzzAnalyzer(), new BangAnalyzer() }, _output.Object);
        }

        [Fact]
        public void NCrunchIsWorking()
        {
            Check.That(true).IsTrue();
        }

        [Fact]
        public void OutputNumberWhenNotMultiple()
        {
            _fizzBuzz.Play(1);

            Check.That(_result).Equals("1");
        }

        [Fact]
        public void OutputFizzWhenMultipleOf3()
        {
            _fizzBuzz.Play(3);

            Check.That(_result).Equals("Fizz");
        }

        [Fact]
        public void OutputBuzzWhenMultipleOf5()
        {
            _fizzBuzz.Play(5);

            Check.That(_result).Equals("Buzz");
        }

        [Fact]
        public void OutputFizzBuzzWhenMultipleOf3And5()
        {
            _fizzBuzz.Play(15);

            Check.That(_result).Equals("FizzBuzz");
        }

        [Fact]
        public void OutputBangWhenMultipleOf7()
        {
            _fizzBuzz.Play(7);

            Check.That(_result).Equals("Bang");
        }
    }
}