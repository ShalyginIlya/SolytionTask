string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inpuntNumber = int.Parse(inputLine);

    int startNumber = (2);

    string lineOutput = "";

    while (startNumber < inpuntNumber)
    {
        lineOutput = lineOutput + startNumber + ", ";
        startNumber = startNumber + 2;
    }
    
    lineOutput = lineOutput + inpuntNumber;

    Console.WriteLine(lineOutput);

}
