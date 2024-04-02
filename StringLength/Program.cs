public class PalidromeLength
{
    public static void Main()
    {
        string palindrome;

        Console.WriteLine("Enter a palindrome: ");
        palindrome = Console.ReadLine();

        Console.WriteLine($"The palindrome \"{ palindrome}\" is" + $" {palindrome.Length} characters.");
    }
}