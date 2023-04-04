int[] someIntegers = new int[3]; // holds 3 elements, with indexes of 0, 1, and 2.
// uninitialized elements of a declared array hold the default value for the type (in this case 0).

int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }; // initializes the values of the array

int[] otherIntegers = new [] { 1, 3, 5, 7, 9 }; // you can omit `int` and just specify []; type is inferred
Console.WriteLine(someIntegers[2]);
Console.WriteLine(moreIntegers[3]);
Console.WriteLine(otherIntegers[1]);