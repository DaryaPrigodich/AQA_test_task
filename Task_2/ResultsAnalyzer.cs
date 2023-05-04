namespace Task_2;

public static class ResultsAnalyzer
{
    public static void CheckName()
    {
        const string ComparisonName = "Вячеслав";
        
        var userName = Console.ReadLine();

        var isSameName = string.Equals(ComparisonName, userName, StringComparison.OrdinalIgnoreCase);

        if (isSameName) 
        {
            ConsoleRepresentation.PrintGreeting();
        }
        else
        {
            ConsoleRepresentation.PrintNameNotExist();
        }
    }
}
