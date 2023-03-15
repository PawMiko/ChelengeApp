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
/*List<int> numery = new List<int>();
for(int i = 10;i<=19;i++)
{
    numery.Add(i);
    
}
//foreach(var licz in numery)
//{
    numery[4] += 1;
    Console.WriteLine(numery[4]);
//}
*/


int number = 3333;


string numberInString = number.ToString();
char[] letters=numberInString.ToArray();

List<int> counter=new List<int>();
for(var i=0;i<=9;i++)
{
    counter.Add(0);
}

foreach(char OnelLetter in letters)
{

    if (OnelLetter == '0')
    {
        counter[0] += 1;
       
    }
    else if(OnelLetter =='1')
    {
        counter[1] +=1;
       
    }
    else if(OnelLetter=='2')
    {
        counter[2] +=1;
         
    }
    else if (OnelLetter == '3')
    {
        counter[3] +=1;
        
    }
    else if (OnelLetter == '4')
    {
        counter[4] += 1;
        
    }
    else if (OnelLetter == '5')
    {
        counter[5] += 1;
        
    }
    else if (OnelLetter == '6')
    {
        counter[6] += 1;
        
    }
    else if (OnelLetter == '7')
    {
        counter[7] += 1;
        
    }
    else if (OnelLetter == '8')
    {
        counter[8] += 1;
        
    }
    else if (OnelLetter == '9')
    {
        counter[9] += 1;
        
    }

}

for (var x = 0; x < counter.Count; x++)
{
    Console.WriteLine("Cyfra "+ x + " jest w ilosci " + counter[x]);
}
