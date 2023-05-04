namespace Task_3;

public static class ResultsAnalyzer
{
    private static IEnumerable<double> GetConvertedUserArray()
    {
        var userInput = Console.ReadLine();
        
        var arrayInput = userInput.Split(' ').Select(num => num.Replace(".", ","));
        
        if (arrayInput.Count() > 15)
        {
            throw new FormatException(ConsoleRepresentation.PrintErrorMessage());
        }

        try
        {
            return arrayInput.Select(double.Parse).ToArray();
        }
        catch (FormatException e)
        {
            ConsoleRepresentation.PrintErrorMessage(e);
            throw;
        }
    }

    public static void GetMultiplesOfThree()
    {
        var convertedUserArray = GetConvertedUserArray();

        var multiplesOfThree = convertedUserArray.Where(number => number % 3 == 0);
        
        ConsoleRepresentation.PrintMultiplesNumbersMassege();
        
        foreach (var number in multiplesOfThree)
        {
            Console.Write(number + " ");
        }
    }
}
