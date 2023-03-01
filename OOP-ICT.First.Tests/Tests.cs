
using Xunit;
using Xunit.Sdk;
using OOP_ICT;
using Newtonsoft.Json.Linq;

namespace OOP_ICT.Dealer.Tests;

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
    public void CheckForNullException_AssertNullRef()
    {
        var collection = new List<string>() { "я", "люблю", "ооп" };
        Assert.Throws<InvalidOperationException>(() => collection.First(x => x == null));
    }
}