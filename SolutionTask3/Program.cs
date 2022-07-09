string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inpuntNumber = int.Parse(inputLine);

    int startNumber = (inpuntNumber * -1);

    string lineOutput = "";

    while (startNumber < inpuntNumber)
    {
        lineOutput = lineOutput + startNumber + ", ";
        startNumber++;
    }

    lineOutput = lineOutput + inpuntNumber;

    Console.WriteLine(lineOutput);

}
