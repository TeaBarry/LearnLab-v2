namespace App;

public class CardService
{
    private List<Card> _allCards; //field
    private int _currentIndex = 0;

    public CardService() // constructor
    {
        // init allcards property

        HardcodedCards hardcodedCards = new HardcodedCards();
        
        _allCards = hardcodedCards.CreateCards();
        
        bool isEmpty = !_allCards.Any();
        if (isEmpty)
        {
            throw new ArgumentException(String.Format("The list of cards can not be empty!"));
        }

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
