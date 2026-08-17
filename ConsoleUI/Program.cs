using App;

namespace ConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        Card card = new Card();
        card.Title = "What is the capital of BG?";
        card.Text = "Sofia";
        card.Category = "Geography";

        DisplayCard(card);
    }

    public static void DisplayCard(Card card)
    {
        Console.WriteLine(card.Title);
        Console.ReadKey();
        Console.WriteLine(card.Text);
    }
}