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

                for (int j = 2; j < 14; j++)
                {

                    //Console.Write((Suits)card.suit);
                    //Console.WriteLine((CardsValue)card.value);
                    deck[k] = new Card((CardsValue)j + 1, (Suits)i);
                    ////Console.WriteLine(card.value);
                    //Console.Write(k);
                    //Console.Write((CardsValue)deck[k].value);
                    k++;

                }

            }


            int shaflCount = 20;
            for (int j = 0; j < shaflCount; j++)
            {


                for (int i = 0; i < 52; i++)
                {
                    int randNumber = rnd.Next(0, 51);
                    Card card = deck[i];
                    deck[i] = deck[randNumber];
                    deck[randNumber] = card;
                }


            }

            //Перемешивание колоды, вынести в отдельный метод(сверху)




            Stack<Card> cardStack = new Stack<Card>();
            for (int i = 0; i < 52; i++)
            {
                cardStack.Push(deck[i]); //заполнение стека
            }

            Player player = new Player();
            player.hand = new List<Card>();//создали и получили игрока 


            Player dealer = new Player();
            dealer.hand = new List<Card>();

            player.GetCard(cardStack.Pop());
            player.GetCard(cardStack.Pop());
            dealer.GetCard(cardStack.Pop());
            dealer.GetCard(cardStack.Pop());

            //начальные карты разданы.

            Console.WriteLine("Игра началась! \nВаша рука:");
            player.PushHand(player);
            Console.WriteLine("\nРука диллера:");
            dealer.PushDealerHand();

            Playing1();

            void Playing1()
            {
                Console.WriteLine("1 чтобы взять карту, 2 чтобы вскрыться.");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Ваша новая карта:" + cardStack.Peek().value +  " " + cardStack.Peek().suit);
                        player.hand.Add(cardStack.Pop());
                        Console.WriteLine("Сумма:" + player.SumValue());
                        CheckSum();
                        Playing1();
                        break;
                    case "2":
                        Console.WriteLine("Вскрываемся! \nВаша рука:");
                        player.PushHand(player);
                        Console.WriteLine("Рука диллера:");
                        dealer.PushHand(dealer);

                        CheckSum();

                        if (player.SumValue() > dealer.SumValue())
                        {
                            Console.WriteLine("Игрок победил! \nСумма очков игрока:" + player.SumValue() + "Сумма очков диллера:" + dealer.SumValue());
                        }
                        else if (player.SumValue() < dealer.SumValue())
                        {
                            Console.WriteLine("Диллер победил! \nСумма очков игрока:" + player.SumValue() + "Сумма очков диллера:" + dealer.SumValue());
                        }
                        else
                        {
                            Console.WriteLine("Ничья!");
                        }



                        break;
                    default:
                        Console.WriteLine("Введено неверное число");
                        Playing1();
                        break;
                }

                void CheckSum()
                {
                    if (player.SumValue() > 21)
                    {
                        Console.WriteLine("Перебор! Игрок проиграл");
                    }
                    else if (dealer.SumValue() > 21)
                    {
                        Console.WriteLine("У диллера перебор! Игрок победил");
                    }

                }
            }

        }

    }

}
