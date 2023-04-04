// //NESTED FOR LOOP

Console.WriteLine("Multiplication Table:");
Console.WriteLine("     1  2  3  4  5  6  7  8  9");
for (int i = 1; i < 10; i++)
{
    Console.Write($" {i} ");
    for (int j = 1; j < 10; j++)
    {
        string product = (i * j).ToString();
        Console.Write(product.PadLeft(3));
    }
    Console.WriteLine();
}


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