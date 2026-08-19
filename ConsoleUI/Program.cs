using App;

namespace ConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        CardService cardService = new CardService();
        while (true)
        {
            var currentCard = cardService.GetNextCard();
            DisplayCard(currentCard);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Press any key to continue... Press Backspace if you wish to Exit!)");
            Console.ResetColor();
            if (Console.ReadKey(true).Key == ConsoleKey.Backspace)
            {
                break;
            }
        }
    }

    public static void DisplayCard(Card card)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Press any key to reveal the answer!");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Question                                ║");
        Console.WriteLine("║                    (Press any key to reveal the answer)                 ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(card.Title);
        Console.ReadKey(true);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                  Answer                                 ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(card.Text);
    }
}