using System;
using Xunit;
using Lab03System.IOReview;

namespace review
{
    public class UnitTest1
    {
        [Fact]
        public void multiplied_three_num()
        {
            String test1 = "4 8 15";

            Assert.Equal(480, Program.challenge_One(test1));


        }
        [Theory]
        [InlineData(480, "4 8 15")]
        [InlineData(480, "4 8 15 22 4")]
        [InlineData(0, "4 8")]
        public void multiplied_num(int result_m ,String test1)
        {
 
            Assert.Equal(result_m, Program.challenge_One(test1));
        }

        //[Theory]
        //[InlineData(480, "4 8 15")]
        //[InlineData(480, "4 8 15 22 4")]
        //[InlineData(0, "4 8 ")]
        //public void (int result_m, String test1)
        //{

        //    Assert.Equal(result_m, Program.challenge_One(test1));
        //}
    }
}
