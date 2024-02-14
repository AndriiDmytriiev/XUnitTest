using NSubstitute;
using Assert = Xunit.Assert;
namespace XUnitTest
{

    public class MethodTest
    {
        [Fact]
        public void TestAMethod()
        {
            if (GetFizzBuzz() == "FizzBuzz")
                Assert.Equal("FizzBuzz", GetFizzBuzz());
            else if (GetFizzBuzz() == "Fizz")
                Assert.Equal("Fizz", GetFizzBuzz());
            else if (GetFizzBuzz() == "Buzz")
                Assert.Equal("Buzz", GetFizzBuzz());
            else
                Assert.Equal("test", GetFizzBuzz());


        }


        public string GetFizzBuzz()
        {
            int number = ResInt();

            if (number % 3 == 0 && number % 5 == 0)
            {

                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
        public int ResInt()
        {
            Random random = new Random();

            //int resrandom = random.Next(1, 100);
            // Create a mock object
            var mock = Substitute.For<Random>();

            // Configure the method to return an integer value
            mock.Next(1, 100).Returns(33);

            // Now when the method is called, it will return 42
            int result = mock.Next(1, 100);
            return result;
        }
    }


}