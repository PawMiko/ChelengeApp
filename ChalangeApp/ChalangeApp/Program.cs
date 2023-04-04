
using ChalangeApp;
using System;
using System.Diagnostics.CodeAnalysis;

var User1 = new UserEmployee(" Pawel", " Muc", 33);
var User2 = new UserEmployee(" Olek", " Kwiat", 43);
var User3 = new UserEmployee(" Tomek", " Wit", 53);
Console.WriteLine("Program dodający oceny pracownikowi ");
Console.WriteLine("========================================================");

int i = 0;
while(true)
{
    Console.WriteLine("podaj kolejną  ocene pracownika");
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
                Console.WriteLine("czy to wszystkie oceny? y or n  ");
                var choise = Console.ReadLine();
                if (choise == "y" || choise == "Y")
                {
                     i = 1;
                    break;
                }
                else if (choise == "n" || choise == "N")
                {
                    Console.WriteLine("wracamy do  wyboru  ");
                }
                else
                    Console.WriteLine("podaj prawidołwą opcje wyboru  ");
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
}

 
    var stat1= User1.GetStat();
Console.WriteLine($"Statystyki: \n " + $" Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");
Console.WriteLine("Letters of average points result: " + stat1.AverageLetter);
Console.WriteLine("--------------------------------------------------------");







