public class Program
{
        int versionNumber = 123; //this line defines a field.
        public static void Main()
        {
//this line will not compile. Error (An object reference is required for the non-static field,
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

//CONSTRUCTORS AND PROPERTY INITIALIZERS
public Person()
{
        FirstName = string.Empty;
}

//Constructors can also take in parameters.
public Person(DateTime dateOfBirth)
{
        DateOfBirth = dateOfBirth;
        FirstName = string.Empty;
}
 // The best way to do this is:
public class Person
{
        public Person(DateTime dateOfBirth)
        {
                DateOfBirth = dateOfBirth;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
}

//COMPOSITION
public class Company
{
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
}
// Composition allows you to create your own type like string or int in order suit what you want to the class for.
// in this case, we'll create an 'Address' type to take in addresses.
public class Address
{
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
}

public class Person
{
        public string FirstName { get; set; }
        
        //In this 'Address' is used as a type. 
        public Address ShippingAddress { get; set; }
}