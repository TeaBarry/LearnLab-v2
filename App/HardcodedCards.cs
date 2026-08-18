namespace App;

public class HardcodedCards
{
  public List<Card> CreateCards()
  { 
    List<Card> cards = new List<Card>();
  
    cards.Add(new Card() {Title = "What is the capital of BG?", Text = "Sofia"});
    cards.Add(new Card() {Title = "What is the capital of Luxembourg?", Text = "Luxembourg"});

    return cards;
  }
}