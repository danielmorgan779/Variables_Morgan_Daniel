using System;

namespace Variables_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber; //Declares an integer I named to favoriteNumber
            bool isJumping = false, isRunning = false; //Declares two bools and sets them to false
            float theFloat; //Created a floating point variable
            favoriteNumber = 27; //Assigns favoriteNumber to 27
            theFloat = 77.77f; // Assigns the floating point variable to 77.77
            const double finalGrade = 99.99; //declares a constant double variable and names it finalGrade and assigns it to 99.99 

            Console.WriteLine("Favorite Number: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);   //all of these writes the stuff above to the console so we can see it when we run
            Console.WriteLine("Floating #: " + theFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
