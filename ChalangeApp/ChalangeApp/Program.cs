
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
User1.AddPoint(12);
User1.AddPoint(3);
Console.WriteLine("POINT " + User1.Result  );
Console.WriteLine("All points removed is:  " + User1.ResultRemovePoint + "\n");
var stat1 = User1.GetStat();
Console.WriteLine($" Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");


Console.WriteLine("NAME " + User2.LoginName);
Console.WriteLine("LASTNAME " + User2.Lastname);
Console.WriteLine("AGE " + User2.age + "\n");
User2.AddPoint(1);
User2.AddPoint(3);
User2.RemovePoint(1);
User2.AddPoint(1);
User2.AddPoint(4);
User2.AddPoint(2);
Console.WriteLine("POINT " + User2.Result );
Console.WriteLine("All points removed is:  " + User2.ResultRemovePoint + "\n");
    var stat2 = User2.GetStat();
Console.WriteLine($" Max point {stat2.Max}\n"+$" Min point {stat2.Min}\n"+ $" Average of points {stat2.Average}\n");



Console.WriteLine("NAME " + User3.LoginName);
Console.WriteLine("LASTNAME " + User3.Lastname);
Console.WriteLine("AGE " + User3.age + "\n");
User3.AddPoint(9);
User3.AddPoint(3);
User3.AddPoint(1);
User3.RemovePoint(5);
User3.RemovePoint(2);
User3.AddPoint(2);
User3.AddPoint(2);
Console.WriteLine("POINT " + User3.Result  );
Console.WriteLine("All points removed is:  " + User3.ResultRemovePoint + "\n");
var stat3 = User3.GetStat();
Console.WriteLine($" Max point {stat3.Max} \n"+$" Min point {stat3.Min} \n"+$" Average of points {stat3.Average}\n");
Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");

metoda();



void metoda() // weryfikacja  jedna czy więcej osób ma tyle samo punktów
{


    List<UserEmployee> emploers = new List<UserEmployee>()
{
    User1,User2,User3
};
    float maxResult = -1;


    UserEmployee userWithMaxResult = null;

    foreach (var emp in emploers)
    {
        if (emp.Result >= maxResult)
        {
            userWithMaxResult = emp;
            maxResult = userWithMaxResult.Result;

        }

    }

    var stat4 = userWithMaxResult.GetStat();
    if ((User1.Result == User2.Result) && (User1.Result == User3.Result) && (User2.Result == User2.Result))
    {
        Console.WriteLine("\t" + " najwiecej punktow mają wszyscy ");
    }
    else
    if (User1.Result == maxResult)
    {

        Console.WriteLine("\t" + " najwiecej punktow ma \n");
        Console.WriteLine($"Name{User1.LoginName} \n"+$"Lastname {User1.Lastname} \n"+$"Age {User1.age}  \n"+$"Result {User1.Result}  \n"+$"All points removed is:  {User1.ResultRemovePoint}\n" + $"All points other methot removed is:  {User1.ResultMinusPoint}\n"); 
        Console.WriteLine($" Max point {stat1.Max}  \n"+ $" Min point {stat1.Min}  \n"+ $" Average of points {stat1.Average}\n");
        
        if (User1 != userWithMaxResult)
        {
            Console.WriteLine($"Name {userWithMaxResult.LoginName}  \n"+$"Lastname {userWithMaxResult.Lastname}");
            Console.WriteLine($"Age {userWithMaxResult.age}  \n"+$"Result {userWithMaxResult.Result}  \n"+$"All points removed is:  {userWithMaxResult.ResultRemovePoint}"+ "\n");
            Console.WriteLine($" Max point {stat4.Max}\n"+ $" Min point {stat4.Min}  \n"+ $" Average of points {stat4.Average}\n");
           
        }
    }
    else if (User2.Result == User3.Result)
    {
        Console.WriteLine("\t" + " najwiecej punktow mają ");
        Console.WriteLine("Name "+User2.LoginName); 
        Console.WriteLine("Lastname "+User2.Lastname);
        Console.WriteLine("Age "+User2.age + "\n");
        Console.WriteLine("Points "+User2.Result);
        Console.WriteLine("All points removed is:  " + User2.ResultRemovePoint + "\n");
        Console.WriteLine($" Max point {stat2.Max}\n" + $" Min point {stat2.Min}\n" + $" Average of points {stat2.Average}\n");
  

        Console.WriteLine("\t" + " I równierz ");
        Console.WriteLine("Name " + User3.LoginName); 
        Console.WriteLine("Lastname" + User3.Lastname);
        Console.WriteLine("Name " + User3.age + "\n");
        Console.WriteLine("Points " + User3.Result);
        Console.WriteLine("All points removed is:  " + User3.ResultRemovePoint + "\n");
        Console.WriteLine($" Max point  {stat3.Max} \n"+ $" Min point  {stat3.Min} \n"+ $" Average of points  {stat3.Average}\n");

    }
    else
    {
        Console.WriteLine("\t" + " najwiecej punktow ma \n ");
        Console.WriteLine("Name "+userWithMaxResult.LoginName);
        Console.WriteLine("Lastname "+userWithMaxResult.Lastname);
        Console.WriteLine("Age "+userWithMaxResult.age + "\n");
        Console.WriteLine("Points " + userWithMaxResult.Result);
        Console.WriteLine("All points removed is:  " + userWithMaxResult.ResultRemovePoint + "\n");
        Console.WriteLine($" Max point {stat4.Max} \n" + $" Min point {stat4.Min} \n" + $" Average of points {stat4.Average}\n");


    }
}

