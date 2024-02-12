using System.Linq;
using System.Numerics;

namespace BlackJack
{
    internal class Player()
    {
        public List<Card> hand;

        public Player(List<Card> hand_) : this()
        {
            hand = hand_;
        }
        internal void GetCard(Card newCard)
        {
            this.hand.Add(newCard);
        }
        public void PushHand(Player player)
        {
            for (int i = 0; i < player.hand.Count; i++)
            {
                Console.WriteLine(player.hand[i].value + " " + player.hand[i].suit);
            }
        }
        public void PushDealerHand()
        {
            for (int i = 1; i < this.hand.Count; i++)
            {
                Console.WriteLine("**** ****");
                Console.WriteLine(this.hand[i].value + " " + this.hand[i].suit);
            }
        }
        public int SumValue()
        {
            int a = 0;
            for (int i = 0; i < this.hand.Count; i++)
            {

                if (Convert.ToInt32(this.hand[i].value) >= 10)
                    a = a + 10;
                else
                    a = a + Convert.ToInt32(this.hand[i].value);   
            }

            for (int i = 0; i < this.hand.Count; i++)
            {
                Card card1 = new Card(CardsValue.Туз, Suits.Пики);
                Card card2 = new Card(CardsValue.Туз, Suits.Черви);
                Card card3 = new Card(CardsValue.Туз, Suits.Трефы);
                Card card4 = new Card(CardsValue.Туз, Suits.Бубе);

                if ((this.hand.Contains(card1)) || (this.hand.Contains(card2)) || (this.hand.Contains(card3)) || (this.hand.Contains(card4)))
                {
                    Console.WriteLine(10000000);
                    if (a > 21)
                    {
                        a = a - 10;
                    }
                }

            }
            return a;
        }
    }

}
