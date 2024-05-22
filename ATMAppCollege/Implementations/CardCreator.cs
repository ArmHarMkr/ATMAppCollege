using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using ATMAppCollege.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAppCollege.Implementations
{
    public class CardCreator : ICardCreator
    {
        public CardCreator()
        {
        }

        public Card CreateNewCard(Card card, User cardUser, string cardPassword)
        {
            Random random = new();
            card.User = cardUser;
            card.CardNumbers = random.NextInt64(1000, 10000).ToString();
            card.CardPassword = cardPassword;
            card.AccessibleMoney = 0;
            return card;
        }
    }
}
