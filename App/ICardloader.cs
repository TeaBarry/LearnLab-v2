namespace App;

public interface ICardLoader
{
    IReadOnlyList<Card> GetAllCards();
}