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
            Console.WriteLine("Press Backspace if you wish to Exit!");
            if (Console.ReadKey().Key == ConsoleKey.Backspace)
            {
                break;
            }
        }
    }

    public static void DisplayCard(Card card)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Press Enter to reveal the answer!");
        Console.WriteLine(" ");
        Console.WriteLine(card.Title);
        Console.ReadKey();
        Console.WriteLine(card.Text);
    }
}