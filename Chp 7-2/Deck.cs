
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp_7_2
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        //first constructor, without parameters
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int val = 1; val <= 13; val++)
                {
                    cards.Add(new Card((Suits)suit, (Values)val));
                }
            
            }
        
        }

        //second constructor with parameters
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        //this would return the count of the cards in the deck. 
        public int Count { get { return cards.Count; } }

        //this would add a new card to deck
        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            if (index >= Count)
                throw new ArgumentException("the index is out of range");

            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        //this method will randomly shuffle the cards on the deck... 
        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            int cardToMove;
            while (cards.Count>0)
            { 
                cardToMove=random.Next(cards.Count);
                newCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = newCards;
        }

        //this method will Get the Card Names as an array... 
        public IEnumerable<string> GetCardNames()
        {
            string[] names = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                names[i] = cards[i].Name;
            }
            return names;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        
        }

    }
}
