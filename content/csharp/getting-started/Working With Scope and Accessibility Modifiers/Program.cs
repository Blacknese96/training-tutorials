//SCOPING
/*Scoping is basically the timeframe of which any variable can be accessed or exist within a program.
And the timeframe is dependent on where your variable is declared. If your variable is within its scope, it can be used.
There are three (3) types of scoping: Method level, Block level and Class level.
*/

//BLOCK LEVEL SCOPING
/*
Line 11-21 is n exmple of block level scoping because,
the 'message' variable is declared within the scope of the FOR loop.
*/
 for (int i = 0; i < 5; i++)
    {
        string message = $"I ran this loop {i} times already.";
        Console.WriteLine(message);
    }
       Console.WriteLine("   -----------------------   ");
    for (int i = 0; i < 4; i++)
    {
        string message = $"I ran this loop {i} times already.";
        Console.WriteLine(message);
    }

 for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine(i); // Line 28 won't compile because the variable 'i' isn't defined within the scope of the For loop.
    
//METHOD LEVEL SCOPING
 public static void DoesCompile()
    {
        int width = 10;
        int length = 4;
        int area = width * length;
        Console.WriteLine($"{nameof(area)}:{area}");
    }
public static void DoesNotCompile()
    {
        int area = width * length; // width and length don't exist yet
        int width = 10;
        int length = 4;
        Console.WriteLine($"{nameof(area)}:{area}");
    }
/*
In Method Level Scoping, only object of a given name can be accessed. 
Variable name reusability cannot be done unlike the block level scoping.
*/
public static void DoWork()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }
    int i = 777; // Compiler error here
    Console.WriteLine(i);
}