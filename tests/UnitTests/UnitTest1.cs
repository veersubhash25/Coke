using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CalcWeight_workswithoneinput()
        {
            var expected = 8.0;
            var x = 4.0;
            var y = 4.0;
            var actual = CalcWeight(x, y);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(-500,150, 25)]
        [InlineData(-25,100,80)]
        [InlineData(-80, 45,25)]
        public void Add_WorksWithManyInputs(double exp, double  n1, double n2)
        {
            Assert.Equal(exp,CalclossPercent(n1,n2));
        }

        public double CalcWeight(double x, double y)
        {
            double z;
            return z = x + y + (x - y);
        }
        public double CalclossPercent(double loss,double total)
        {
            return ((total - loss) / total) * 100;
        }
    }
}
