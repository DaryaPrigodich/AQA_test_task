namespace Task_1;

public static class ResultsAnalyzer
{
    public static void CheckNumber()
    {
        var isNumber = int.TryParse(Console.ReadLine(), out var number);

        if (isNumber && number >= 7)
        {
            ConsoleRepresentation.PrintGreeting();
        }
        else if (isNumber && number < 7)
        {
            ConsoleRepresentation.AskNumberAgain();
            CheckNumber(); 
        }
        else
        {
            throw new FormatException(ConsoleRepresentation.PrintErrorMessage());
        }
    }
}
