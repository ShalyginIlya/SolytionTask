string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    //int outNumber = inputNumber*inputNumber; - 1 вариант решения задачи
    int outNumber  = (int)Math.Pow(inputNumber,2);

    Console.WriteLine(outNumber);
}