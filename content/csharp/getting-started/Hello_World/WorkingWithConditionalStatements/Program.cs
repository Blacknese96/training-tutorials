Random rand = new Random();
int secretNumber = rand.Next(1, 4); // Generate a random number between 1 and 3
Console.WriteLine("Guess a number between 1 and 3: ");
string input = Console.ReadLine();
int guess;
if (!int.TryParse(input, out guess)) {
    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
} else if (guess is < 1 or > 3) {
    Console.WriteLine("Your guess is outside the range of valid numbers. Please enter a number between 1 and 3.");
} else if (guess == secretNumber) {
    Console.WriteLine("Congratulations, you guessed the secret number!");
} else if (guess < secretNumber) {
    Console.WriteLine("Your guess is too low.");
} else {
    Console.WriteLine("Your guess is too high.");
}