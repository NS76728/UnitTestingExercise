using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods UT = new UnitTestMethods();
            //Act
            int actual= UT.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods UT = new UnitTestMethods();
            //Act
            int actual = UT.Subtract(minuend,subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12,12,144)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods UT = new UnitTestMethods();

            //Act
            int actual = UT.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(144,12,12)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods UT = new UnitTestMethods();

            //Act
            int actual = UT.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            UnitTestMethods UT = new UnitTestMethods();
            string lyric = "sorrows of the earth";
            //Act
            string lyricActual = UT.YourMethodName();
            bool equal = lyric == lyricActual;
            //Assert
            Assert.False(equal);

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            UnitTestMethods UT = new UnitTestMethods();
            string lyric = "your mind is a stream of colors";
            //Act
            string lyricActual = UT.YourMethodName2().ToLower();
            bool equal = lyric == lyricActual;
            //Assert
            Assert.True(equal);
        }
    }
}
