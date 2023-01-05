// Вводим любое число и проверяем является ли оно палиндромом.

public static class Extensions
{
    public static string Reverse(this string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
 
public class Example
{
    public static void Main()
    {
        Console.WriteLine("Введите число");
        string str = Console.ReadLine();
 
        string reverse = str.Reverse();
        if (str == reverse)
        {
            Console.WriteLine("Это число является Полиндромом");
        }
        else
        {
            Console.WriteLine("Набрали неверное число");
        }
    }
}