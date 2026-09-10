using Sharprompt;
namespace Testing;


public static class Program
{
    public static void Main()
    {
        int total = 0;
        while (true)
        {
            string choice = Prompt.Select("Enter the choice", ["Add", "Subtract", "Multiply", "Divide","Quit"]).ToUpper();
            
            
            if (choice == "ADD")
            {
                int num1 = Prompt.Input<int>("Enter the amount you want to add:");
                total += num1;
            }
            else if (choice == "SUBTRACT")
            {
                int num1 = Prompt.Input<int>("Enter the amount you want to subtract:");
                total -= num1;
            }
            else if (choice == "MULTIPLY")
            {
                int num1 = Prompt.Input<int>("Enter the amount you want to multiply:");
                total *= num1;
            }
            else if (choice == "DIVIDE")
            {
                int num1 = Prompt.Input<int>("Enter the amount you want to divide:");
                total /= num1;
            }
            else if (choice == "QUIT")
            {
                break;
            }
            
        }
        Console.WriteLine($"The total is {total}.");
    }
}