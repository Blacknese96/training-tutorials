public class Program
{
    
        int versionNumber = 123; //this line defines a field.
        public static void Main()
        {
//this line will not compile. Error ( An object reference is required for the non-static field,
//method, or property 'Program.versionNumber'). 
//Console.WriteLine($"Current version number {versionNumber}");

        //You must create an instance of Program
        var myProgram = new Program();
        Console.WriteLine($"{myProgram.versionNumber}");
        //OR
        Console.WriteLine(myProgram.ToString());
        //OR
        Console.WriteLine(myProgram); //This will automatically call ToString() internally.
        }
}

//PROPERTIES AND FIELDS
//FIELDS are attached to class. Check Line 4. versionNumber is an example of a field.
//FIELDS are just variables, while properties are methods that help to manipulate the state of an object.
public class Speedometer
{
        private int _currentSpeed;
        public int CurrentSpeed
        {
                get
                {
                        return _currentSpeed;
                }
                set 
                {
                        if (value < 0) return;
                        if (value > 120) return;
            
                        // value is a keyword used in setters representing the new value
                        _currentSpeed = value; 
                }
        }
}