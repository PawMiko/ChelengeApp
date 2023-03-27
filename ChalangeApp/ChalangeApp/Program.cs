
using ChalangeApp;
using System.Drawing;
using System.Runtime.CompilerServices;

Employee User1 = new Employee(" Pawel", " Muc", 33);
Employee User2 = new Employee(" Olek", " Kwiat", 43);
Employee User3 = new Employee(" Tomek", " Wit", 53);




Console.WriteLine("NAME " + User1.LoginName);
Console.WriteLine("LASTNAME " + User1.Lastname);
Console.WriteLine("AGE " + User1.age);
User1.AddPoint(1);
User1.AddPoint(1);
User1.AddPoint(1);
User1.RemovePoint(1);
User1.AddPoint(13);
User1.AddPoint(1);
Console.WriteLine("POINT " + User1.Result  );
Console.WriteLine("Remove point is " + User1.ResultRemovePoint + "\n");

Console.WriteLine("NAME " + User2.LoginName);
Console.WriteLine("LASTNAME " + User2.Lastname);
Console.WriteLine("AGE " + User2.age);
User2.AddPoint(1);
User2.AddPoint(1);
User2.RemovePoint(1);
User2.AddPoint(14);
User2.AddPoint(1);
User2.AddPoint(1);
Console.WriteLine("POINT " + User2.Result );
Console.WriteLine("Remove point is " + User2.ResultRemovePoint + "\n");

Console.WriteLine("NAME " + User3.LoginName);
Console.WriteLine("LASTNAME " + User3.Lastname);
Console.WriteLine("AGE " + User3.age);
User3.AddPoint(14);
User3.AddPoint(1);
User3.AddPoint(1);
User3.RemovePoint(2);
User3.AddPoint(1);
User3.AddPoint(1);
Console.WriteLine("POINT " + User3.Result  );
Console.WriteLine("Remove point is " + User3.ResultRemovePoint + "\n");



List<Employee> emploers = new List<Employee>()
{
    User1,User2,User3
};
int maxResult = -1;


Employee userWithMaxResult = null;

foreach (var emp in emploers)
{
    if (emp.Result >= maxResult)
    {
        userWithMaxResult = emp;
        maxResult = userWithMaxResult.Result;

    }

}


if ((User1.Result == User2.Result) && (User1.Result == User3.Result) && (User2.Result == User2.Result))
{
    Console.WriteLine("\t" + " najwiecej punktow mają wszyscy ");
}
else
if (User1.Result == maxResult)
{

    Console.WriteLine("\t" + " najwiecej punktow mają ");
    Console.WriteLine(User1.LoginName); ;
    Console.WriteLine(User1.Lastname);
    Console.WriteLine(User1.age);
    Console.WriteLine(User1.Result);
    Console.WriteLine("Remove point is " + User1.ResultRemovePoint + "\n");
    if (User1 != userWithMaxResult)
    {
        Console.WriteLine(userWithMaxResult.LoginName);
        Console.WriteLine(userWithMaxResult.Lastname);
        Console.WriteLine(userWithMaxResult.age);
        Console.WriteLine(userWithMaxResult.Result);
        Console.WriteLine("Remove point is " + userWithMaxResult.ResultRemovePoint + "\n");
    }
}
else if (User2.Result == User3.Result)
{
    Console.WriteLine("\t" + " najwiecej punktow mają ");
    Console.WriteLine(User2.LoginName); ;
    Console.WriteLine(User2.Lastname);
    Console.WriteLine(User2.age);
    Console.WriteLine(User2.Result);
    Console.WriteLine("Remove point is " + User2.ResultRemovePoint + "\n");

    Console.WriteLine("\t" + " I równierz ");
    Console.WriteLine(User3.LoginName); ;
    Console.WriteLine(User3.Lastname);
    Console.WriteLine(User3.age);
    Console.WriteLine(User3.Result);
    Console.WriteLine("Remove point is " + User3.ResultRemovePoint + "\n");

}
else
{
    Console.WriteLine("\t" + " najwiecej punktow ma ");
    Console.WriteLine(userWithMaxResult.LoginName);
    Console.WriteLine(userWithMaxResult.Lastname);
    Console.WriteLine(userWithMaxResult.age);
    Console.WriteLine(userWithMaxResult.Result);
    Console.WriteLine("Remove point is " + userWithMaxResult.ResultRemovePoint + "\n");
    
}

