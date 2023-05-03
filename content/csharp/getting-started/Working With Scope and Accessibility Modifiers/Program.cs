//SCOPING
/*Scoping is basically the timeframe of which any variable can be accessed or exist within a program.
And the timeframe is dependent on where your variable is declared. If your variable is within its scope, it can be used.
There are three (3) types of scoping: Method level, Block level and Class level.
*/

//BLOCK LEVEL SCOPING
/*
Line 12-22  is n exmple of block level scoping because,
the 'message' variable is declared within the scope of the FOR loop.
*/


DoWork();
DoesCompile();



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
  //  Console.WriteLine(i); // Line 28 won't compile because the variable 'i' isn't defined within the scope of the For loop.
    
//METHOD LEVEL SCOPING
  static void DoesCompile()
    {
        int width = 10;
        int length = 4;
        int area = width * length;
        Console.WriteLine($"{nameof(area)}:{area}");
    }
 /*static void DoesNotCompile()
    {
        int area = width * length; // width and length don't exist yet
        int width = 10;
        int length = 4;
        Console.WriteLine($"{nameof(area)}:{area}");
    }
*/
/*
In Method Level Scoping, only object of a given name can be accessed. 
Variable name reusability cannot be done unlike the block level scoping.
*/
 static void DoWork()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }
   // int i = 777; // Compiler error here
   // Console.WriteLine(i);
}

//CLASS LEVEL SCOPING
/*
Some objects or variables are dependent on the lifetime of the class they're been declared.
In Class Level Scoping, reference members are declared below the block of code you are working on.
*/

/*var circle = new Circle(5m);
Console.WriteLine(circle.Perimeter());

public class Circle{
public Circle(decimal radius){
    Radius = radius;  //Using 'Radius' before its declared.
}
public decimal Radius{get; set;}
public decimal Perimeter(){
   return 2 * _pi * this.Radius; //Using '_pi' before its declared.
}
private const decimal _pi = 3.14159m;
}
*/

//ACCESS MODIFIERS
//PUBLIC, PRIVATE, INTERNAL AND PROTECTED.


//ASSESSMENT
Course course = new Course("Introduction to Programming");
course.AddStudent(new Student("Gregory", 20, "Computer Science"));
course.AddStudent(new Student("Mark", 22, "Mathematics"));
course.AddStudent(new Student("Shegz", 19, "Engineering"));

Console.WriteLine("Course name: " + course.GetCourseName());
Console.WriteLine("Roster:");
foreach (string name in course.RosterName()) {
    Console.WriteLine(name);
}

public class Course{
private string _name;
private List<Student> _students;

public Course(string name){
     _name = name;
     _students = new List<Student>();
}
public void AddStudent(Student student){
    _students.Add(student);
}
public void RemoveStudent(Student student){
     _students.Remove(student);
}
public string GetCourseName(){
     return _name;
}
public List<string> RosterName(){
   List<string> rosterName = new List<string>();
   foreach(Student student in _students){
    rosterName.Add(student.Name);
    }
    return rosterName;
}
}
public class Student {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }

    public Student(string name, int age, string major) {
        Name = name;
        Age = age;
        Major = major;
    }
}