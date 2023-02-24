using System;

namespace Variables_OMalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber;
            bool isJumping = false, isRunning = false;
            float myFloat;
            favoriteNumber = 15;
            myFloat = 67.98f;
            const double finalGrade = 96.0;

            Console.WriteLine("Favorite #:" + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
