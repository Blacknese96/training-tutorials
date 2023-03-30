DateTime tellTime = DateTime.Now;
var time = tellTime.Hour;

if (time < 12)
{
    Console.WriteLine("Good Morning");
}else if (time >= 12 || time < 4)
{
    Console.WriteLine("Good Afternoon");
}else if (time >= 4 || time < 22)
{
    Console.WriteLine("Good Evening");
}
else if(time >= 22 || time < 5)
{
    Console.WriteLine("Good Night");
}