namespace Task_3;

public static class ConsoleRepresentation
{
    public static void AskNumbers()
    {
        Console.WriteLine("Введите не более 15 чисел через пробел:");
    }
    
    public static void PrintErrorMessage(FormatException e)
    {
        Console.WriteLine($"Некорректный ввод. {e.Message}");
    }

    public static string PrintErrorMessage()
    {
        return "Длина массива должна быть меньше 15!";
    }

    public static void PrintMultiplesNumbersMassege()
    {
        Console.WriteLine("Числа кратные трем:");
    }
}
