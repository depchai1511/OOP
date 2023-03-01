
using Xunit;
using Xunit.Sdk;
using OOP_ICT;
using Newtonsoft.Json.Linq;

public class Tests
{
    // TODO: Обратите внимание, что для коллекций и проверок есть разные виды Assert
    [Fact]
    public void TestCardConstructor()
    {
        string suit = "Hearts";
        string value = "Ace";

        Card card = new Card(suit, value);

        Assert.Equal(suit, card.Suit);
        Assert.Equal(value, card.FaceValue);
    }

    [Fact]
    public void TestCardDeckConstructor()
    {
        CardDeck cardDeck = new CardDeck();
        Assert.Equal(52, cardDeck.Count());
    }


    [Fact]
    public void TestCardDeckShuffle()
    {

        CardDeck cardDeck = new CardDeck();
        CardDeck originalDeck = new CardDeck();

        cardDeck.Shuffle();
        Assert.NotEqual(originalDeck, cardDeck);

    }

    [Fact]
    public void TestDealerCreateShuffledUserDeck()
    {
        Dealer dealer = new Dealer();

        UserDeck userdeck = dealer.CreateShuffledUserDeck(13);

        
        Assert.Equal(52-13, dealer.CountCard());
    }

    [Fact]
    public void TestUserDeckAddCard()
    {

        UserDeck userDeck = new UserDeck();
        Card card = new Card("Clubs","King");

        userDeck.AddCard(card);
        Assert.Equal(1, userDeck.Count());
    }
}