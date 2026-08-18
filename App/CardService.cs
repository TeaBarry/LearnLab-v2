namespace App;

public class CardService
{
    private List<Card> _allCards; //property
    private int _currentIndex = 0;

    public CardService() // constructor
    {
        // init allcards property

        HardcodedCards hardcodedCards = new HardcodedCards();

        _allCards = hardcodedCards.CreateCards();
        //_allCards.Count;

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
