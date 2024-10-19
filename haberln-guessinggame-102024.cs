/********************************************************************* 
*    Course:     DEV 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2024
*
*    Programmer: NataschaHaberl
*    Assignment: GuessingGameGradedExercise
*    
*    Description:   
*    A 30 minute exercise to complete a guessing game
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         10/18/2024         Initial Release 
*    
* 
*/

using System;
using static System.Console;

namespace GuessingGameGradedExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int guesses = 1;
            do
            {
                Random RandomClass = new Random();
                int randomNumber;
                randomNumber = RandomClass.Next(1, 11);

                Write("Guess a number between 1 and 10: ");
                int numInput = Convert.ToInt32(ReadLine());
                while (numInput != randomNumber)
                {

                    if (numInput > randomNumber)
                    {
                        guesses++;
                        Write("Your guess was too high \nGuess again: ");
                        numInput = Convert.ToInt32(ReadLine());
                    }
                    else if (numInput < randomNumber)
                    {
                        guesses++;
                        Write("Your guess was too low \nGuess again: ");
                        numInput = Convert.ToInt32(ReadLine());
                    }
                }
                if (numInput == randomNumber)
                {
                    if (guesses == 1)
                    {
                        WriteLine("You got it first try! Congrats!");
                        guesses = 1;
                    }
                    else
                    {
                        WriteLine($"That's correct! You got it in {guesses} guesses!");
                        guesses = 1;
                    }
                }
                Write("Would you like to play again? Enter Y to play again: ");
            } while (ReadLine().ToUpper() == "Y");
        }
    }
}