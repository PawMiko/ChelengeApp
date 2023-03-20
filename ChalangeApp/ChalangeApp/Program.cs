
using ChalangeApp;
using System.Drawing;
using System.Runtime.CompilerServices;

Employee eployee1 = new Employee(" Pawel"," Muc",33);
Employee eployee2 = new Employee(" Olek", " Kwiat", 43);
Employee eployee3 = new Employee(" Tomek", " Wit", 53);




Console.WriteLine("NAME " + eployee1.Name);
Console.WriteLine("LASTNAME "+ eployee1.Lastname);
Console.WriteLine("AGE " + eployee1.age);
eployee1.ADDPOINT(1);
eployee1.ADDPOINT(1);
eployee1.ADDPOINT(1);
eployee1.ADDPOINT(14);
eployee1.ADDPOINT(1);
Console.WriteLine("POINT " + eployee1.Result + "\n");

Console.WriteLine("NAME "+ eployee2.Name);
Console.WriteLine("LASTNAME " + eployee2.Lastname);
Console.WriteLine("AGE " + eployee2.age);
eployee2.ADDPOINT(1);
eployee2.ADDPOINT(1);
eployee2.ADDPOINT(14);
eployee2.ADDPOINT(1);
eployee2.ADDPOINT(1);
Console.WriteLine("POINT " + eployee2.Result + "\n");

Console.WriteLine("NAME " + eployee3.Name);
Console.WriteLine("LASTNAME " + eployee3.Lastname);
Console.WriteLine("AGE " + eployee3.age);
eployee3.ADDPOINT(14);
eployee3.ADDPOINT(1);
eployee3.ADDPOINT(1);
eployee3.ADDPOINT(1);
eployee3.ADDPOINT(1);
Console.WriteLine("POINT " + eployee3.Result + "\n");


 
List<Employee> emploers = new List<Employee>()
{
    eployee1,eployee2,eployee3
};
int maxResult = -1;


Employee userWithMaxResult=null;

foreach (var emp in emploers)
{
      if (emp.Result >= maxResult)
    {
        userWithMaxResult = emp;
        maxResult = userWithMaxResult.Result;
             
    }
    
}


if ((eployee1.Result == eployee2.Result) && (eployee1.Result == eployee3.Result) && (eployee2.Result == eployee2.Result))
{
    Console.WriteLine("\t" + " najwiecej punktow mają wszyscy ");
}
else
if (eployee1.Result == maxResult )
{

    Console.WriteLine("\t" + " najwiecej punktow mają ");
    Console.WriteLine(eployee1.Name); ;
    Console.WriteLine(eployee1.Lastname);
    Console.WriteLine(eployee1.age);
    Console.WriteLine(eployee1.Result);
    if (eployee1 != userWithMaxResult)
    {
        Console.WriteLine(userWithMaxResult.Name);
        Console.WriteLine(userWithMaxResult.Lastname);
        Console.WriteLine(userWithMaxResult.age);
        Console.WriteLine(userWithMaxResult.Result);
    }
}
else if (eployee2.Result == eployee3.Result)
{
    Console.WriteLine("\t" + " najwiecej punktow mają ");
    Console.WriteLine(eployee2.Name); ;
    Console.WriteLine(eployee2.Lastname);
    Console.WriteLine(eployee2.age);
    Console.WriteLine(eployee2.Result);

    Console.WriteLine("\t" + " I równierz ");
    Console.WriteLine(eployee3.Name); ;
    Console.WriteLine(eployee3.Lastname);
    Console.WriteLine(eployee3.age);
    Console.WriteLine(eployee3.Result);

}else
{
    Console.WriteLine("\t" + " najwiecej punktow ma ");
    Console.WriteLine(userWithMaxResult.Name);
    Console.WriteLine(userWithMaxResult.Lastname);
    Console.WriteLine(userWithMaxResult.age);
    Console.WriteLine(userWithMaxResult.Result);
}



