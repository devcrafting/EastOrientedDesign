using Moq;
using NFluent;
using Xunit;

namespace EastOriented
{
    public class FizzBuzzShould
    {
        private readonly Mock<IOutput> _output;
        private readonly FizzBuzz _fizzBuzz;

        public FizzBuzzShould()
        {
            _output = new Mock<IOutput>();
            _fizzBuzz = new FizzBuzz(_output.Object);
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

            _output.Verify(x => x.Write("1"), Times.Once);
        }

        [Fact]
        public void OutputFizzWhenMultipleOf3()
        {
            _fizzBuzz.Play(3);

            _output.Verify(x => x.Write("Fizz"), Times.Once);
            _output.Verify(x => x.Write(It.Is<string>(y => !y.Equals("Fizz"))), Times.Never);
        }

        [Fact]
        public void OutputBuzzWhenMultipleOf5()
        {
            _fizzBuzz.Play(5);

            _output.Verify(x => x.Write("Buzz"), Times.Once);
        }

        [Fact]
        public void OutputFizzBuzzWhenMultipleOf3And5()
        {
            _fizzBuzz.Play(15);

            _output.Verify(x => x.Write("FizzBuzz"), Times.Once);
        }
    }
}