using Sharprompt;
namespace Testing;


public static class Program
{
    public static void Main()
    {
        int total = Prompt.Input<int>("Enter a number");
        while (true)
        {
            string choice = Prompt.Select("Enter the choice", ["Add", "Subtract", "Multiply", "Divide","Quit"]).ToUpper();
            if (choice == "QUIT")
            {
                break;
            }
            switch (choice)
            {
                case "ADD":
                    total += Prompt.Input<int>("Enter the amount you want to add");
                    break;
                case "SUBTRACT":
                    total -= Prompt.Input<int>("Enter the amount you want to subtract");
                    break;
                case "MULTIPLY":
                    total *= Prompt.Input<int>("Enter the amount you want to multiply");
                    break;
                case "DIVIDE":
                    total /= Prompt.Input<int>("Enter the amount you want to divide");;
                    break;
            }
            
        }
        Console.WriteLine($"The total is {total}.");
    }
}