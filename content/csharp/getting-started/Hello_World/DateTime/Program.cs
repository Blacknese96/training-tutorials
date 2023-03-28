// var currentTime = DateTime.Now; // 
// var today = DateTime.Today; 
// var someDate = new DateTime(2023,3,27); 
// var someMoment = new DateTime(2023,3,27,4,24,19);
// var tomorrow = DateTime.Today.AddDays(1);
// var yesterday = DateTime.Today.AddDays(-1);
// var someDay = DateTime.Parse("3/27/2023");
//
// Console.WriteLine(currentTime);
// Console.WriteLine(today);
// Console.WriteLine(someDate);
// Console.WriteLine(someMoment);
// Console.WriteLine(tomorrow);
// Console.WriteLine(yesterday);
// Console.WriteLine(someDay);


//Calculating Birthday
DateTime birthDate = new DateTime(1996, 5, 25);
DateTime todaysDate = DateTime.Today;
var age = todaysDate - birthDate;
double days = age.TotalDays;
double daysToNextAnniversary = 10000 - (days % 10000);


Console.WriteLine($"Age in days is {days}");
Console.WriteLine(daysToNextAnniversary);
