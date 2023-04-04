
using ChalangeApp;
using System.Drawing;
using System.Runtime.CompilerServices;


var User1 = new UserEmployee(" Pawel", " Muc", 33);
var User2 = new UserEmployee(" Olek", " Kwiat", 43);
var User3 = new UserEmployee(" Tomek", " Wit", 53);




Console.WriteLine("NAME " + User1.LoginName);
Console.WriteLine("LASTNAME " + User1.Lastname);
Console.WriteLine("AGE " + User1.age + "\n");
User1.AddPoint("adam");
User1.AddPoint("4000");
User1.AddPoint('a');
User1.AddPoint('5');
User1.AddPoint(5.777777777777777777777777777777777777777777);
User1.AddPoint(18446744073709551615);
User1.RemovePoint(-1);
User1.RemovePoint(-1);
User1.RemovePoint(-1);
User1.AddPoint(12f);
User1.AddPoint(3);
Console.WriteLine("POINT " + User1.Result  );
Console.WriteLine("All points removed is:  " + User1.ResultRemovePoint + "\n");
var stat1 = User1.GetStat();
Console.WriteLine($"Dla pętli Foreach:\n " + $" Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");
Console.WriteLine("--------------------------------------------------------");
stat1 = User1.GetStatFor();
User1.AddPoint(3);
Console.WriteLine($"Dla pętli For:\n " + $" Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");
Console.WriteLine("--------------------------------------------------------");
User1.AddPoint(14);
stat1 = User1.GetStatWhile();
Console.WriteLine($"Dla pętli while:\n " + $" Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");
Console.WriteLine("--------------------------------------------------------");
User1.AddPoint(15);
User1.RemovePoint(-5);
stat1 = User1.GetStatDoWhile();
Console.WriteLine($"Dla pętli do while:\n " + $" Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");



Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");


