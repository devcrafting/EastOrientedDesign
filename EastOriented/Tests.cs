using Moq;
using NFluent;
using Xunit;

namespace EastOriented
{
    public class FizzBuzzShould
    {
        [Fact]
        public void NCrunchIsWorking()
        {
            Check.That(true).IsTrue();
        }

        [Fact]
        public void OutputResult()
        {
            var i = 1;
            var output = new Mock<Output>();
            var fizzBuzz = new FizzBuzz(output.Object);

            fizzBuzz.Play(i);

            output.Verify(x => x.Write("1"));
        }
    }

    public interface Output
    {
        void Write(string str);
    }

    public class FizzBuzz
    {
        private Output output;

        public FizzBuzz(Output output)
        {
            this.output = output;
        }

        public void Play(int i)
        {
            output.Write("1");
        }
    }
}
