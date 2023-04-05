int[] someIntegers = new int[3]; // holds 3 elements, with indexes of 0, 1, and 2.
// uninitialized elements of a declared array hold the default value for the type (in this case 0).

int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }; // initializes the values of the array

int[] otherIntegers = new [] { 1, 3, 5, 7, 9 }; // you can omit `int` and just specify []; type is inferred
Console.WriteLine(someIntegers[2]);
Console.WriteLine(moreIntegers[3]);
Console.WriteLine(otherIntegers[1]);


        int[,] eggCarton = new int[2,6]; // a typical egg carton can be thought of as a 2x6 array
        Console.WriteLine(eggCarton[0,0]); // one "corner" of the array
        Console.WriteLine(eggCarton[1,5]); // the opposite "corner"

        int[,] someTable = { { 1, 2, 3 }, { 4, 5, 6 } }; // you can fill a multi-dimensional array on assignment as well
        Console.WriteLine(someTable[0,0]); // one "corner" of the array

// JAGGED ARRAYS
int[][] jaggedArray = new int[4][]; // define first dimension
jaggedArray[0] = new int[2] { 1, 2 }; // set values of first array
Console.WriteLine(jaggedArray[0][0]); // first element in first row
Console.WriteLine(jaggedArray[0][1]); // second element in first row

// additional rows haven't yet been created/assigned
Console.WriteLine(jaggedArray[1]); // value is null

//WORKING WITH ARRAYS
int[] someNumbers = { 1, 2, 3 };

int x = 1 + someNumbers[0]; // x = 2
int y = 2 * someNumbers[2]; // y = 6
someNumbers[2] = y; // someIntegers now contains { 1, 2, 6 }
// someIntegers[3] = 3; // EXCEPTION (IndexOutOfRange)

//ARRAYS AND STRINGS
string input = "red,blue,yellow,green";
string[] colors = input.Split(','); // note single quotes, which are used to define literal character (``char``) values

Console.WriteLine(colors[0]);
Console.WriteLine(colors[1]);
    