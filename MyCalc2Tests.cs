using Xunit;

namespace MyCalcLib.Tests
{
    public class MyCalc2Tests
    {
        [Fact]
        public void Raz_19and11_8returned()
        {
            // arrange
            int x = 19;
            int y = 11;
            int expected = 8;

            // act
            Calc2 c = new Calc2();
            int actual = c.Raz(x, y);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Umn_4and5_20returned()
        {
            // arrange
            int x = 4;
            int y = 5;
            int expected = 20;

            // act
            Calc2 c = new Calc2();
            int actual = c.Umn(x, y);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
