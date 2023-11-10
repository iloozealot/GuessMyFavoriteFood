// 2023 Guess my favorite food
// Author: Justin Spencer
// This program has the user type guesses until the correct guess is made.


string? food;
do
{
    Console.Write("Try to guess my favorite food: ");
    food = Console.ReadLine();
    if (food != "pizza")
        Console.WriteLine("nope.");
} while (food != "pizza");
Console.WriteLine("Good job! Pizza is my favorite food.");