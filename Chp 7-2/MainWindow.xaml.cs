using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chp_7_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDeck1.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                    deck2.Add(deck1.Deal(listBoxDeck1.SelectedIndex));
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxDeck2.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                    deck1.Add(deck2.Deal(listBoxDeck2.SelectedIndex));
            }
            RedrawDeck(1);
            RedrawDeck(2);

        }

        private void reset1_Click(object sender, RoutedEventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, RoutedEventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, RoutedEventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, RoutedEventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        //this would reset the deck... 1-deck1, 2-deck2
        private void ResetDeck(int deckNumber)
        {
            List<Card> cards=new List<Card>(); 
            Card card;
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11); // from 2 - 10 cards...  
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    card = new Card((Suits)random.Next(4), (Values)random.Next(14));
                    if (cards.Contains(card))
                        i--;
                    else
                    {
                        cards.Add(card);
                        deck1.Add(card);
                    }

                }
                
                deck1.Sort();

            }
            else
            {
                deck2 = new Deck(); 
            
            }
        
        
        
        }

        //this would redraw the deck... 1-deck1, 2-deck2. 
        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                listBoxDeck1.Items.Clear();
                foreach (var cardName in deck1.GetCardNames())
                {
                    listBoxDeck1.Items.Add(cardName);
                }
                labelDeck1.Content = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                listBoxDeck2.Items.Clear();
                foreach (var cardName in deck2.GetCardNames())
                {
                    listBoxDeck2.Items.Add(cardName);
                }
                labelDeck2.Content = "Deck #2 (" + deck2.Count + " cards)";
            
            }
        
        }
    }
}
