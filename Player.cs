using System.Collections.Generic;

namespace DeckOfCards
{
// Give the Player class a name property.
// Give the Player a hand property that is a List of type Card.
// Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
// Note this method will require reference to a deck object
// Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
    public class Player
    {
        public string name;
        public List<Card> hand;

        public Player(string Name)
        {
            Name = name;
            hand = new List<Card>();
        }
        
        public Card draw(Deck deck)
        {
            Card cardDrawn = deck.deal();
            hand.Add(cardDrawn);
            return cardDrawn;
        }

        public Card discard( int idx )
        {
            if ( idx < 0 || idx > hand.Count ){
                System.Console.WriteLine("You dont have this card!");
                return null;
            } else {
                Card card = hand[idx];
                hand.RemoveAt(idx);
                return card;
            }
        }
    }
}
