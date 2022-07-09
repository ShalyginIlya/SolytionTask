string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();

if(inputLine1 != null && inputLine2 != null)
{
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);

    //if(inputNumber2 == inputNumber1*inputNumber1) - 1 вариант решения задачи
    if(inputNumber2 == Math.Sqrt(inputNumber1))
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }

}
 