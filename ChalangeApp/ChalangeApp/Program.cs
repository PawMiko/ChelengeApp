
using System.Xml.Schema;

int number = 98765432;
Console.WriteLine("liczba do odwrocenia to "+ number);
string numberInString2=number.ToString();
char[] digit=numberInString2.ToCharArray();
char temp;
int meter = 0;


List<char> digitList=new List<char>();


for (var i = 0; i < digit.Length; i++)
{
  digitList.Add(digit[i]);
 
  meter++;
}

for (var i = 0; i < digitList.Count; i++)
{
    meter--;
   
    if(meter>i)
    {
        temp = digitList[i];
        digitList[i] = digitList[meter];
        digitList[meter] = temp;
    }
    
}
var result =string.Join("", digitList);
Console.WriteLine("liczba po odwroceniu "+ result);

