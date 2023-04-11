//There are two types of methods: Static and Instance Methods.
//Static Methods are methods that work only on the parameters that are being passed into it. It requires the 'static' keyword.
//Instance Methods are methods that are attached the to an object instance of its appropriate type. It doesn't require 'static keyword'.
DisplayHeader();
DisplayMenu();


static void DisplayHeader()
{
    Console.WriteLine("***********************");
    Console.WriteLine("**** Mark's Pub ******");
    Console.WriteLine("**********************");
}

static void DisplayMenu()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1: View the Menu");
    Console.WriteLine("2: Exit Menu");
}

//METHODS WITH RETURN TYPES
//Methods are usually declared as 'void' or contains a return type which could be string or int value.
//void means it does not return anything.
DisplayName();


 string Greeting(string name) // 'string' here in this instance serves as a return type for the 'Greeting' method.
                              // the variable 'name' is a paramater. Methods can take in arguements.
{
    return $"Hi {name}";
}

 void DisplayName()
{
    Console.WriteLine(Greeting("Gregory"));
}

//METHOD OVERLOADS
/* Method overload has to do with multiple declaration of the same named method
 with different parameters.
 */

 
// string greeting = CreateGreeting();
// Console.WriteLine($"Default Greeting: {greeting}");
//         
// string customGreeting = CreateGreeting("Steve");
// Console.WriteLine($"Custom Greeting: {customGreeting}");
//
// static string CreateGreeting()
// {
//     // call version with more parameters, passing a default value
//     return CreateGreeting("You"); 
// }
//     
// static string CreateGreeting(string name)
// {
//     return $"Hi {name}!";
// }


// DateTime end = DateTime.Now.AddSeconds(10);
// string endTimeString = end.ToString();
// TimeSpan timeLeft = end - DateTime.Now;
//
// SecondsRemaining();
//     
//
// int SecondsRemaining(DateTime endTime)
// {
//     return SecondsRemaining(endTime - DateTime.Now);
// }
//
// int SecondsRemaining(string endTime)
// {
//     return SecondsRemaining(DateTime.Parse(endTime));
// }
//
// int SecondsRemaining(TimeSpan duration)
// {
//     return (int)duration.TotalSeconds;
// }
//
// Console.WriteLine(SecondsRemaining(end));
// Console.WriteLine(SecondsRemaining(endTimeString));
// Console.WriteLine(SecondsRemaining(timeLeft));

//LAMBDA EXPRESSIONS
Func<int, int> addOne = x => x + 1; // this is the lambda expression
Console.WriteLine(addOne(4));

const int four = 4;
Func<int, int> addOneAgain = x => x + 1;
Func<int, int, int> calcArea = (x,y) => x * y; // two parameters
Func<int> twentyFive = () => calcArea(addOneAgain(four), addOneAgain(four)); // no parameters
Console.WriteLine(twentyFive());

//EXTENSION METHODS
