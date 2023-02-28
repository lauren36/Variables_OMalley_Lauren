using System;

namespace Variables_OMalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {   // An integer that is named favoriteNumber.
            int favoriteNumber;
            // A boolen that shows that isJumping and isRunning is false.
            bool isJumping = false, isRunning = false;
            // A floating point named myFloat.
            float myFloat;
            // Shows the value of favoriteNumber.
            favoriteNumber = 15;
            // Shows the value of myFloat.
            myFloat = 67.98f;
            // Interduces a finalGrade as well as shows the value of finalGrade.
            const double finalGrade = 96.0;
            // Shows all of the variables to the console.
            Console.WriteLine("Favorite #:" + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
