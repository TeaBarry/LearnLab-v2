
using System.Reflection.Metadata.Ecma335;

namespace App;

public class Test
{
    private List<Card> _allCards;
    public Card CheckIfHardCodedCardsIsEmpty()
    {
        HardcodedCards hardcodedCards = new HardcodedCards();
        _allCards = hardcodedCards.CreateCards();
        bool isEmpty = !_allCards.Any();
        if (isEmpty)
        {
            throw new ArgumentException(String.Format("The list of cards can not be empty!"));
        }

        return null;

    }
}