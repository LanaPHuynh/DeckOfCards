using System;
using System.Collections.Generic;

namespace DeckOfCards
{
// Give the Deck class a property called "cards" which is a list of Card objects.
// When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
// Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
// Give the Deck a reset method that resets the cards property to contain the original 52 cards.
// Give the Deck a shuffle method that randomly reorders the deck's cards.
    public class Deck
    {
        public List<Card> cards;
        

        public Deck()
        {
            reset();
            shuffle();
        }

        public Deck reset()
        {
            cards = new List<Card>();
            string[] suits = {"Hearts", "Spades", "Clubs", "Diamonds"};
            string[] cardVals = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            foreach (string suit in suits){
                for(int i = 0; i<cardVals.Length; i++){
                    Card card = new Card(cardVals[i], suit, i+1);
                    cards.Add(card);
                }
            }         
            return this;
        }

        public Deck shuffle()
        {
            Random rand = new Random();
            for(int end = cards.Count-1; end > 0; end--)
            {
                int randVal = rand.Next(end);
                Card temp = cards[randVal];
                cards[randVal] = cards[end];
                cards[end] = temp;
            }
            return this;
        }

        public Card deal()
        {
            if( cards.Count > 0 )
            {
                Card top = cards[0];
                cards.RemoveAt(0);
                return top;
            } else {
                reset();
                return deal();
            }

        }
    }
}
