using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            Player bob = new Player("bob");
            bob.draw(newDeck);
            bob.draw(newDeck);
            bob.draw(newDeck);
            bob.draw(newDeck);
            bob.draw(newDeck);
            bob.draw(newDeck);
            bob.hand[2].printCard();
            bob.discard(2);
            Console.WriteLine("Player's hand: ");
            for( int i = 0; i<bob.hand.Count; i++)
            {
                bob.hand[i].printCard();
            }
        }
    }
}
