namespace Core.CdsHooks.Cards;
public interface ICardBuilder
{
    public IEnumerable<CardModel> GetCardResult();
}