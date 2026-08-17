namespace App;

public class CardService
{
    // get it working here fist and then move 
    public List<Card> AllCards; //property

    public CardService() // constructor
    {
        // init allcards property
        // 
    }
    public Card GetNextCard()
    {
        // Make it so it gets the next card
        // need list and counter that increments to know next card 
        Card card = new Card();
        
        card.Title = "What is the capital of BG?";
        card.Text = "Sofia";
        card.Category = "Geography";
        
        return card;
    }
}