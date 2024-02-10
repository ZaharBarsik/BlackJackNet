namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] deck = new Card[52];
            int k = 0;
            Random rnd = new Random();
            


            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 13; j++)
                {

                    //Console.Write((Suits)card.suit);
                    //Console.WriteLine((CardsValue)card.value);
                    deck[k] = new Card((CardsValue)j + 1, (Suits)i);
                    //Console.WriteLine(card.value);
                    Console.WriteLine(k);
                    Console.WriteLine((CardsValue)deck[k].value);
                    k++;

                }

            }

            for (int i = 0; i < 52; i++)
            {
                int randNumber = rnd.Next(0, 51);
                new Card((CardsValue)1, (Suits)1) = deck[i] ;
                Console.WriteLine(i);
                Console.WriteLine((CardsValue)deck[i].value);
            }
        }
    }
}
