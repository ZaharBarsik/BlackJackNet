﻿namespace BlackJack
{
    internal class Card
    {
        public CardsValue value;
        public Suits suit;

        public Card(CardsValue value, Suits suit)
        {
            this.value = value;
            this.suit = suit;
        }
        //public void GetCard(Player player)
        //{
        //    Random rnd = new Random();
        //    player.hand

        //}
    }
}
