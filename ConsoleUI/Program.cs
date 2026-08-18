using App;

namespace ConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        CardService cardService = new CardService();
        Test test = new Test();
        test.CheckIfHardCodedCardsIsEmpty();
        while (true)
        {
            var currentCard = cardService.GetNextCard();
            DisplayCard(currentCard);
            if (Console.ReadKey().Key == ConsoleKey.Backspace)
            {
                break;
            }
        }
    }

    public static void DisplayCard(Card card)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Press Enter to reveal the answer! (Press Backspace to Exit)");
        Console.WriteLine(" ");
        Console.WriteLine(card.Title);
        Console.ReadKey();
        Console.WriteLine(card.Text);
    }
}