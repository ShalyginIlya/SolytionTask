string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inpuntNumber = int.Parse(inputLine);

    int startNumber = 1;

    string lineOutput = "0";

    while (startNumber <= inpuntNumber)
    {
        lineOutput = startNumber*(-1) + ", " + lineOutput + ", " + startNumber;
        startNumber++;
    }

    // lineOutput = lineOutput + inpuntNumber;

    // int startNumber = (inpuntNumber * -1);

    // string lineOutput = "";

    // while (startNumber < inpuntNumber)
    // {
    //     lineOutput = lineOutput + startNumber + ", ";
    //     startNumber++;
    // }

    // lineOutput = lineOutput + inpuntNumber;

    Console.WriteLine(lineOutput);

}
