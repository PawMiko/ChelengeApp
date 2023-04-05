
using ChalangeApp;
using System;
using System.Diagnostics.CodeAnalysis;

var User1 = new UserEmployee(" Pawel", " Muc", 33);
var User2 = new UserEmployee(" Olek", " Kwiat", 43);
var User3 = new UserEmployee(" Tomek", " Wit", 53);
Console.WriteLine("Program dodający oceny pracownikowi ");
Console.WriteLine("========================================================");
Console.WriteLine("Choise evaluation A,B,C,D or value between 0 and 100");
Console.WriteLine("Q = exit\n");

//try
//{
//    UserEmployee User4 = null;
//    var name = User4.Lastname;


//}
//catch(Exception Ex)
//{
//    Console.WriteLine(Ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally");
//}

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
                    Console.WriteLine($"Expection catched !!! {ex.Message}");
                }
            }break;
            default:
            {
                try 
                {
                    User1.AddPoint(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception catched !!! {ex.Message}");
                }
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







