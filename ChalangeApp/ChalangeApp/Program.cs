
using ChalangeApp;
using System;
using System.Diagnostics.CodeAnalysis;

var User1 = new UserEmployee(" Pawel", " Muc", 33);
var User2 = new UserEmployee(" Olek", " Kwiat", 43);
var User3 = new UserEmployee(" Tomek", " Wit", 53);
var Dyro = new Supervisor("Roman","Pyć", 40); 
Console.WriteLine("Program dodający oceny pracownikowi ");
Console.WriteLine("========================================================");
Console.WriteLine("Choise evaluation A,B,C,D or value between 0 and 100");
Console.WriteLine("Q = exit\n");

int i = 0;
Console.WriteLine("Employer or supervisor?  Press E or S");
var  inputChoice =Console.ReadLine();
if (inputChoice == "E" || inputChoice == "e")
{
    Console.WriteLine("Enter employee evaluation");
    User();
    var stat1 = User1.GetStat();
    Console.WriteLine("--------------------------------------------------------\n");
    Console.WriteLine($"Statistics: employe \n " + $"Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");
    Console.WriteLine("Letters of average points result: " + stat1.AverageLetter);
    Console.WriteLine("--------------------------------------------------------");
}
else
    if (inputChoice == "S" || inputChoice == "s")
{
    Console.WriteLine("Enter supervisor evaluation");
    Supervisor();
    var stat1 = Dyro.GetStat();
    Console.WriteLine("--------------------------------------------------------\n");
    Console.WriteLine($"Statistics dyro: \n " + $"Max point  {stat1.Max}\n" + $" Min point  {stat1.Min}\n" + $" Average of points  {stat1.Average}\n");
    Console.WriteLine("Letters of average points result: " + stat1.AverageLetter);
    Console.WriteLine("--------------------------------------------------------");

}





void User()
{
    for (; ; )
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
                User1.AddPoint('C');
                break;
            case "D":
            case "d":
                User1.AddPoint('D');
                break;
            case "q":
            case "Q":
                {
                    Console.WriteLine("are these all ratings? y or n  ");
                    var choice = Console.ReadLine();
                    try
                    {
                        if (choice == "y" || choice == "Y")
                        {
                            i = 1;
                            break;
                        }
                        else if (choice == "n" || choice == "N")
                        {
                            throw new Exception("back to the choice\r\n");
                        }
                        else
                            throw new Exception("provide the correct option  ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception catched !!! {ex.Message}");
                    }
                }
                break;
            default:
                {
                    try
                    {
                        User1.AddPoint(input);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception catched!!! {ex.Message}");
                    }
                }
                break;
        }

        if (i == 1)
            break;
        Console.WriteLine("enter the next employee evaluation\n");
    }
}
void Supervisor()
{
    for (; ; )
    {
        var input = Console.ReadLine();

        switch (input)
        {
            case "6":
                Dyro.AddPoint(100);
                break;
            case "5":
                Dyro.AddPoint(80);
                break;
            case "4":
                Dyro.AddPoint(60);
                break;
            case "3":
                Dyro.AddPoint(40);
                break;
            case "2":
                Dyro.AddPoint(20);
                break;
            case "1":
                Dyro.AddPoint(0);
                break;
            case "6-" or "-6":
                Dyro.AddPoint(90);
                break;
            case "5-" or "-5":
                User1.AddPoint(70);
                break;
            case "4-" or "-4":
                Dyro.AddPoint(50);
                break;
            case "3-" or "-3":
                Dyro.AddPoint(30);
                break;
            case "2-" or "-2":
                Dyro.AddPoint(10);
                break;
            case "1+" or "+1":
                Dyro.AddPoint(5);
                break;
            case "5+" or "+5":
                Dyro.AddPoint(85);
                break;
            case "4+" or "+4":
                Dyro.AddPoint(65);
                break;
            case "3+" or "+3":
                Dyro.AddPoint(45);
                break;
            case "2+" or "+2":
                Dyro.AddPoint(25);
                break;
            

            case "q":
            case "Q":
                {
                    Console.WriteLine("are these all ratings? y or n  ");
                    var choice = Console.ReadLine();
                    try
                    {
                        if (choice == "y" || choice == "Y")
                        {
                            i = 1;
                            break;
                        }
                        else if (choice == "n" || choice == "N")
                        {
                            throw new Exception("back to the choice\r\n");
                        }
                        else
                            throw new Exception("provide the correct option  ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception catched !!! {ex.Message}");
                    }
                }
                break;
            default:
                {
                    try
                    {
                        Dyro.AddPoint(input);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception catched!!! {ex.Message}");
                    }
                }
                break;
        }

        if (i == 1)
            break;
        Console.WriteLine("enter the next employee evaluation\n");
    }
}




