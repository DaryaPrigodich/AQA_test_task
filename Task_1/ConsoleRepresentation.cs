namespace Task_1;

public static class ConsoleRepresentation
{
    public static void AskNumber()
    {
        Console.WriteLine("Введите число:");
    }
    
    public static void PrintGreeting()
    {
        Console.WriteLine("Привет!");
    }
    
    public static void AskNumberAgain()
    {
        Console.WriteLine("Введите число ещё раз:");
    }

    public static string PrintErrorMessage()
    {
        return "Некорректный ввод.";
    }
}
