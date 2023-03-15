/*int[] grades= new int[5];
//string[] dayOfWeeks=new string[7];
List<string> dayOfWeeks = new List<string>();
List<string>weeks=new List<string>();

dayOfWeeks.Add  ("poniedziałek");
dayOfWeeks.Add ("wtorek");
dayOfWeeks.Add ("środa");
dayOfWeeks.Add  ("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add ( "niedziela");
//string[] dayOfWeeks2 = { "pon", "wto", "sro", "czwa", "pia", "sob", "nie" };

foreach (var day in dayOfWeeks)
{ 
    Console.WriteLine (day);
}*/

int number = 4579;
//int digit = 0;

string numberInString = number.ToString();
char[] letters=numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;   
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;   
int counter7 = 0;   
int counter8 = 0;   
int counter9 = 0;


foreach(char OnelLetter in letters)
{

    if (OnelLetter == '0')
    {
      
        counter0++;
    }
    else if(OnelLetter =='1')
    {
       
        counter1++;
    }
    else if(OnelLetter=='2')
    {
     
        counter2++; 
    }
    if (OnelLetter == '3')
    {
       
        counter3++;
    }
    else if (OnelLetter == '4')
    {
       
        counter4++;
    }
    else if (OnelLetter == '5')
    {
       
        counter5++;
    }
    if (OnelLetter == '6')
    {
        
        counter6++;
    }
    else if (OnelLetter == '7')
    {
        
        counter7++;
    }
    else if (OnelLetter == '8')
    {
       
        counter8++;
    }
    else if (OnelLetter == '9')
    {
        
        counter9++;
    }

}

Console.WriteLine(" liczba 0 jest w ilości " + counter0 );
Console.WriteLine(" liczba 1 jest w ilości " + counter1 );
Console.WriteLine(" liczba 2 jest w ilości " + counter2 );
Console.WriteLine(" liczba 3 jest w ilości " + counter3 );
Console.WriteLine(" liczba 4 jest w ilości " + counter4 );
Console.WriteLine(" liczba 5 jest w ilości " + counter5 );
Console.WriteLine(" liczba 6 jest w ilości " + counter6 );
Console.WriteLine(" liczba 7 jest w ilości " + counter7 );
Console.WriteLine(" liczba 8 jest w ilości " + counter8 );
Console.WriteLine(" liczba 9 jest w ilości " + counter9 );


