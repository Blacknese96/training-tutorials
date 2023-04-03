//WHILE LOOP
//Think of the WHILE LOOP as a repeated IF statement. While the IF evaluates the condition once,
//the WHILE LOOP evaluates the condition until it returns as false.

// int numberToGuess = new Random().Next(1,101); // a number from 1 to 100
// int currentGuess = 0; // start with an incorrect guess
// while (currentGuess != numberToGuess)
// {
//     Console.WriteLine("Guess the number (1 to 100): ");
//     currentGuess = int.Parse(Console.ReadLine()); // If the user inputs a string, it throws an Unhandled exception (System.FormatException).
//                                                   // Which clearly means that string is not what was required to be inputted instead an integer.
//     if (currentGuess < numberToGuess)
//     {
//         Console.WriteLine("You guessed too low! Try again!");
//     }
//     if (currentGuess > numberToGuess)
//     {
//         Console.WriteLine("You guessed too high! Try again!");
//     }
// }
// Console.WriteLine("You got it! Good job!");

//ASSESSMENT
// Find the factors of a given number

//
//     Console.WriteLine("Enter a number:");
//     int number = int.Parse(Console.ReadLine());
//     Console.Write("Factors: ");
//     while (number > 1) // convert this to while
//     {
//         int candidateFactor = 2;
//         while (candidateFactor <= number) // convert this to while
//         {
//             if (number % candidateFactor == 0) // found a factor
//             {
//                 Console.Write(candidateFactor);
//                 number /= candidateFactor; // divide number by the factor you found and assign this back to number
//                Console.Write($" , "); // print values if the number is still greater than 1
//             }
//             candidateFactor++; // don't forget to increment factor!
//         }
//     }
//     Console.WriteLine();
//
//
// //NESTED FOR LOOP
//
//     Console.WriteLine("Multiplication Table:");
//     Console.WriteLine("     1  2  3  4  5  6  7  8  9");
//     for (int i = 1; i < 10; i++)
//     {
//         Console.Write($" {i} ");
//         for (int j = 1; j < 10; j++)
//         {
//             string product = (i * j).ToString();
//             Console.Write(product.PadLeft(3));
//         }
//         Console.WriteLine();
//     }


//ASSESSMENT ON NESTED FOR LOOP
// Write a program that prints the result of counting up to 24 using four different increments.
// First, count by 1s, then by 2s, by 3s, and finally by 4s.

for (int indexNumber = 1; indexNumber <= 4; indexNumber++)
{
    Console.Write("Counting by " + indexNumber + "s: ");
    for (int j = 0; j <= 24; j += indexNumber)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}