//2
var name = "Gregory";
Console.Write($"Hello, {name}");

string empty = "";
string emptyLength = String.Empty;
Console.WriteLine(empty);
Console.WriteLine(emptyLength.Length);

string trynull = null;
//Console.WriteLine(trynull.Length); //this length will throw out an exception (NullReference exception)

string inputOne = " Gregory ";
string inputTwo = "Hello";
string trimInput = inputOne.Trim();
string trimInput2 = inputTwo.TrimStart();
Console.WriteLine($"{inputTwo}, {inputOne}"); 
Console.WriteLine($"{trimInput} and {trimInput2}");

string greet = "Good Evening, ";
string myName = "Gregory";
string greetings = greet + myName;
string loud = greetings.ToUpper();
string quiet = greetings.ToLower();

Console.WriteLine($"{loud}!");
Console.WriteLine($"{quiet}");