/*int CutNumber()
{
    int num;
    Console.Write("Input a number from 100 to 1000  ");
    num = Convert.ToInt32(Console.ReadLine());
    

    int sotni = num / 100;
    int des = num / 10;
    int ed = num % 10;

    int result = des % 10;
    return  result;

}

int number = CutNumber();
Console.WriteLine("Second number is " + number);
*/

/*void DayWeekVoid()
{
    int num;
    Console.Write("Input a day's number from 1 to 7 ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num>=6) 
    {
        Console.WriteLine("Yes, it is a weekend");  
    }
    
     else
     {
        Console.WriteLine("No, it is not a weekend");  
     }
         
}

DayWeekVoid();
*/


/*void CutThirdNumberVoid()
{
    int num;
    Console.Write("Input a number  ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num < 99 && num > 0)
    { 
        Console.WriteLine("Третьей цифры нет");
    }
    if ( num < 1000 && num > 99)
    {
        int result = num%10;
        Console.WriteLine(result);
    }
    if (num > 1000)
    {
        while (num > 1000)
        {
            int step = 0;
            num = num /10;
            step = step + 1;
        }
   Console.WriteLine (num %10);
    }
}
CutThirdNumberVoid();
*/


 