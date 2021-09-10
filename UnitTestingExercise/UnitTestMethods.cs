using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference

        // Create an Add method that passes 3 integers

        public int Add(int x,int y,int z)
        {
            int sum = x + y + z;
            return sum;
        }



        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            int diff = minuend - subtrahend;
            return diff;
        }


        // Create a Multiply method that passes 2 integers
        public int Multiply(int x, int y)
        {
            int prod = x * y;
            return prod;
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int x, int y)
        {
            int prod = x / y;
            return prod;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote

        public string YourMethodName()
        {
             string lyric= "Sorrows of the Earth";
            return lyric;
        }
        public string YourMethodName2()
        {
            string lyric = "Your Mind is a Stream of Colors";
            return lyric;
        }


    }
}
