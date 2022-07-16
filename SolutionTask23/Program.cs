// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.1


string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int NumberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNNN = string.Empty; // = "";
    int s = 1;
    while (s <= NumberN)
    {
        lineN = lineN + s+ " ";
        lineNNN = lineNNN + (s * s * s).ToString() + " ";
        s++;
    }

    Console.WriteLine(lineN);
    Console.WriteLine(lineNNN);
}
