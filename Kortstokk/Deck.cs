using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortstokk {
    public class Deck {
        List<PlayingCard> cards { get; } = new();
        public int Decks{ get; set; }



        public Deck(int decks = 1) {
            Decks = decks;
            CreateDeck();
        }
        
        public void CreateDeck() {

            for (int x = 0; x < Decks; x++) {
                for (int i = 0; i < 4; i++){
                    for (int j = 0; j < 13; j++) {
                     
                        cards.Add(new(i, j));
                    }       
                }
            }
            foreach (var item in cards) {
                Console.WriteLine("Suit: " + item.Suit + " " + "Value: " + item.Value);
            }
        }

        public void RandDeck(int shuffle) {
            int count = 0;
            Random rand = new();
            for (int i = 0; i < cards.Count()*shuffle; i++) {
                int random = rand.Next(0, cards.Count());
                cards.Add(cards[random-1]);
                cards.RemoveAt(random-1);
            }
            foreach (var item in cards) {
                Console.WriteLine("Suit: " + item.Suit + " Value: " + item.Value);
                if (item.Suit == 0 || item.Suit == 1) {
                    count++;
                }
            }
                Console.WriteLine(count + " " + cards.Count());


        }


    }
}
