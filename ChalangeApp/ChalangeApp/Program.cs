using System.ComponentModel.Design;

string name = "Ewa";
bool sex = true;
int age = 33;


if (sex)
{
    if (age < 30)
        Console.WriteLine("kobieta ponieżej 30 lat");
    else if ( age==33 && name=="Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (!sex )
{
    Console.WriteLine("niepełnoletni Mężczyzna");
}




