namespace App;

public class CardService
{
    //private List<Card> _allCards; //field
    private IReadOnlyList<Card> _allCards;
    private int _currentIndex = 0;

    public CardService(ICardLoader cardLoader) // constructor
    {
        _allCards = cardLoader.GetAllCards();        
        
    }
    public Card GetNextCard()
    {
        var currentCard = _allCards[_currentIndex];
        _currentIndex++;
        if (_currentIndex == _allCards.Count)
        {
            _currentIndex = 0;
        }
        return currentCard;

    }
        
}
