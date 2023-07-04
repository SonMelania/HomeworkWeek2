/*Read three integer numbers from the user and display the minimum and maximum number.
 * List<int> numere = new List<int>();

Console.WriteLine("introduceti un nr:");
for(int i = 1; i <= 3; i++)
{
    string nr=Console.ReadLine();
    numere.Add(Convert.ToInt32(nr));

}
Console.WriteLine(numere.Max());
Console.WriteLine(numere.Min());*/

/*Resolve exercise 1 using ternary operator. (Find information about the ternary operator in the useful resources and online.)
 * List<int> numere = new List<int>();
Console.WriteLine("introduceti numerele");
for (int i = 1; i <= 3; i++)
{
    string nr=Console.ReadLine();
    numere.Add(Convert.ToInt32(nr));
    }
int result=int.MinValue;
foreach (int i in numere)
{
    result = i > result ? i : result;
}

Console.WriteLine(result);
result = int.MaxValue;
foreach (int i in numere)
{
    result = i < result ? i : result;
}
Console.WriteLine(result);*/

/*Read a number from the keyboard which represents a number of days and convert to years (1 year = 356days), months(1month = 30 days), weeks and days as in example. 
Be careful here because when we have just 1 year, we will display "1 year" and not "1 years". Same for months and days.

Console.WriteLine("introduceti numarul:");
string nr=Console.ReadLine();

int days=Convert.ToInt32(nr);

int years = days / 365;


    int luni = (days%365)/30;
int zile = ((days % 365) % 30);
string textAni = years == 1 ? "1 an" : $"{years} Ani";
string textLuni = luni == 1 ? "1 Luna" : $"{luni} Luni";
string textZile = zile == 1 ? "1 zi" : $"{zile} Zile";

Console.WriteLine($"{textAni} {textLuni} {textZile}");*/

/*Write a program to accept a grade and declare the equivalent description. 

List<string> descriprion = new List<string>() { "Exellent", "Very Good", "Good", "Average", "Fail" };

Console.WriteLine("introdu litera:");
string temp=Console.ReadLine();

/*foreach(string desc in descriprion)
{
    //if (temp == desc.First().ToString()) 
    if (desc.StartsWith(temp)) 
    {
Console.WriteLine(desc);
    }

}

switch(temp){
    case "E":
        Console.WriteLine("Exellent");
        break;
    case "V":
        Console.WriteLine("Verry Good");
        break;
    default: Console.WriteLine("valoare gresita");
        break;
}*/
//Console.WriteLine(descriprion.First(p=>p.StartsWith(temp)));


using System.ComponentModel;
using System.Diagnostics;

/*Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer Science. 
    Calculate percentage and grade according to following:
Percentage >= 90 % : Grade A  

Percentage >= 80% : Grade B  

Percentage >= 70% : Grade C  

Percentage >= 60% : Grade D  

Percentage >= 40% : Grade E  

Percentage < 40% : Grade F  
Console.WriteLine(" Enter the Physics mark:");
int phy=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Chemistry mark:");
int  chemy= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Biology mark:");
int bio= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Mathematics mark:");
int  math= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Computer Science mark:");
int  science= Convert.ToInt32(Console.ReadLine());

List<int> list= new List<int>() { phy,chemy,bio,science, math };
//double med = (phy + chemy + bio + math + science)/5 ;
double med=list.Average();



if (med >= 90)
{
    Console.WriteLine($"Percentage = {med} ang drage is A ");
}
else
{
    if (med >= 80)
    {
        Console.WriteLine($"Percentage = {med} ang drage is B ");
    }
    else
    {
        if (med >= 70)
        {
            Console.WriteLine($"Percentage = {med} ang drage is C ");

        }

    }
}
   */
/*Write a program to read temperature in centigrade and display a suitable message according to temperature state below:  

Temp < 0 then Freezing weather  

Temp 0-10 then Very Cold weather  

Temp 10-20 then Cold weather  

Temp 20-30 then Normal in Temp  

Temp 30-40 then Its Hot  

Temp >=40 then Its Very Hot  


Console.WriteLine("introdu temperatura:");
int temp=Convert.ToInt32(Console.ReadLine());

if (temp < 0)
{
    Console.WriteLine("Freezing weather");
}
else
{
    if (temp>0 && temp<10)
    {
        Console.WriteLine("Very Cold weather");
    }
    else
    {
        if (temp > 10 && temp < 20)
        {
            Console.WriteLine("Cold weathe");
        }
        else
        {
            if(temp>20&&temp< 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else
            {
                if (temp > 30 && temp < 40)
                {
                    Console.WriteLine("Its Hot");
                }
                else 
                {
                   if (temp >= 40)
                    {
                        Console.WriteLine("Its Very Hot");
                    }
                    
                }
            }
        }
    }
}
*/
/*Given an array of integer numbers, print the total of all the values that are even numbers.
 * 
int[] aray=new int[6];
Console.WriteLine("introduceti numerele:");

for (int i= 0; i < aray.Length; i++)
{
     int temp = Convert.ToInt32(Console.ReadLine());
   
     aray[i] = temp;

}
    int[] aray2=aray.Where(x => x%2==0).ToArray();
int sum=aray2.Sum();

Console.WriteLine("suma intregilor din sir este:"+sum);*/

/*Find if an array of integer numbers contains duplicates and display them if so.

int[] ary=new int[6];
Dictionary<int, bool> dic=new Dictionary<int, bool>();

Console.WriteLine("introdu numerele:");
for (int i=0; i<ary.Length; i++)
{
    int temp = Convert.ToInt32(Console.ReadLine());
    ary[i] = temp;

} 
foreach(int i in ary)
{
    if (!dic.ContainsKey(i))
    {
        dic.Add(i, false);
    }else
    {
        dic[i] = true;
    }


}
var result=dic.Where(p=>p.Value==true).ToList();

foreach(var i in result)
{
    Console.WriteLine(i.Key+" ");
}
*/
/*Check if there are duplicates in a list of strings. If yes, remove the them.
 * 
List<string> list = new List<string>();
Console.WriteLine("introduceti literele:");
string s="1";
    do
        {        

     s = Console.ReadLine();
    if (s != "1")
    {
        list.Add(s);
    }
}
    while (s!="1") ;



var temp =list.Distinct().ToList();
temp.ForEach(x => Console.WriteLine(x));
*/

/*Write a program to count the frequency of each element in an array.
int[] ary=new int[6];

Console.WriteLine("introduceti numere:");


for (int i=0; i<ary.Length-1; i++)
{
int temp=Convert.ToInt32(Console.ReadLine());
    ary[i]=temp;
}
var nr = ary.Distinct().ToArray();

for (int i = 0; i < nr.Length-1; i++)
{
    var cnt = ary.Count(e => e == nr[i]);



    Console.WriteLine($"elemntul {nr[i]} --- {cnt} times");
}*/
/*//Read an array from the console and separate odd and even values into 2 arrays. 
using System.Linq;
int[] arry = new int[4];

Console.WriteLine("introduceti numerele:");

for(int i= 0; i<arry.Length; i++)
{
    int temp = Convert.ToInt32(Console.ReadLine());
    arry[i] = temp;
}
var array2= arry.Where(x=>x%2==0).ToArray();

Array.ForEach(array2,j => Console.WriteLine(j));
Console.WriteLine();
var array3=arry.Where(x=>x%2!=0).ToArray();
Array.ForEach(array3, j => Console.WriteLine(j));*/

