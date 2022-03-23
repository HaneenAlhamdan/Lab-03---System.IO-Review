using System;
using Xunit;
using Lab03System.IOReview;

namespace review
{
    public class UnitTest1
    {
        
        
            [Theory]
            [InlineData(480, "4 8 15")]
            [InlineData(480, "4 8 15 22 4")]
            [InlineData(0, "4 8")]
            public void multiplied_num(int result, String test1)
            {

                Assert.Equal(result, Program.challenge_One(test1));
            }

            [Theory]
            [InlineData(2, new int[] { 0, 2, 2, 1, 3, 4, 5, 2 })]
            [InlineData(6, new int[] { 6, 6, 6, 6, 6, 6, 6, 6 })]
            [InlineData(5, new int[] { 5, 4, 3, 2, 1, 0 })]
            public void duplicates_num(int result, int[] arr)
            {

                Assert.Equal(result, Program.challenge_Four(arr));
            }


            [Theory]
            [InlineData(-1, new int[] { -1, -2, -7, -10, -3, -4, -5, -12 })]
            [InlineData(3, new int[] { 3, 3, 3, 3, 3, 3 })]
            public void maximum_num(int result, int[] arr)
            {

                Assert.Equal(result, Program.challenge_Five(arr));
            }


            [Theory]
            [InlineData(new string[] { "Hello: 5", "in: 2", "my: 2", "world: 5" }, "Hello in my world")]
            [InlineData(new string[] { "This: 4", "is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6", "96: 2" }, "This is a sentance about important things 96")]
            [InlineData(new string[] { "Hello%: 6", "@in: 4", "m#y: 3", "$world: 6" }, "Hello% @in@ m#y $world")]
            public void sentence_test(String[] result, String str)
            {

                Assert.Equal(result, Program.challenge_Nine(str));
            }
        }
    } 
