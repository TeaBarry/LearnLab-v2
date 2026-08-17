using App;

namespace ConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        CardService cardService = new CardService();
        var currentCard = cardService.GetNextCard();
        DisplayCard(currentCard);
    }

    public static void DisplayCard(Card card)
    {
        Console.WriteLine(card.Title);
        Console.ReadKey();
        Console.WriteLine(card.Text);
    }
}