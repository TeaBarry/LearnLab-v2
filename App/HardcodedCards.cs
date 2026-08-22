namespace App;

public class HardcodedCards : ICardLoader
{
  private readonly List<Card> _allCardsList = new()
  {
    new Card
    {
      Title = "What is the Capital of BG?",
      Text = "Sofia",
      Category = "Geography"
    },
    new Card
    {
      Title = "What is the Capital of Luxembourg",
      Text = "Luxembourg",
      Category = "Geography"
    }
  };

  public IReadOnlyList<Card> GetAllCards()
  {
    return _allCardsList;
  }
  
}