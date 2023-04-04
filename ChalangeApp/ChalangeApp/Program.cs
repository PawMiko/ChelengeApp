
using ChalangeApp;
using System;
using System.Diagnostics.CodeAnalysis;

var User1 = new UserEmployee(" Pawel", " Muc", 33);
var User2 = new UserEmployee(" Olek", " Kwiat", 43);
var User3 = new UserEmployee(" Tomek", " Wit", 53);
Console.WriteLine("Program dodający oceny pracownikowi ");
Console.WriteLine("========================================================");
Console.WriteLine("Choise evaluation A,B,C,D or value betwen 0 and 100");
Console.WriteLine("Q = exit\n");


int i = 0;
Console.WriteLine("Enter employee evaluation");
for (;;)
{
   var input = Console.ReadLine();

    switch (input)
    {
        case "A":
        case "a":
            User1.AddPoint('a');
            break;
        case "B":
        case "b":
            User1.AddPoint('b');
            break;
        case "C":
        case "c":
            User1.AddPoint('c');
            break;
        case "D":
        case "d":
            User1.AddPoint('d');
            break;
        case "q":
        case "Q":
            {
                Console.WriteLine("are these all ratings? y or n  ");
                var choise = Console.ReadLine();
                if (choise == "y" || choise == "Y")
                {
                     i = 1;
                    break;
                }
                else if (choise == "n" || choise == "N")
                {
                    Console.WriteLine("back to the choice\r\n  ");
                }
                else
                    Console.WriteLine("provide the correct option  ");
            }
            break;
        default:
            {
                User1.AddPoint(input);
            }
            break;


    }

    if (i == 1)
        break;
    Console.WriteLine("enter the next employee evaluation\n");
}

 
    var stat1= User1.GetStat();
Console.WriteLine("--------------------------------------------------------\n");
Console.WriteLine($"Statistics: \n " + $"Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");
Console.WriteLine("Letters of average points result: " + stat1.AverageLetter);
Console.WriteLine("--------------------------------------------------------");







