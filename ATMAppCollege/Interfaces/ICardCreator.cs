using ATMAppCollege.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAppCollege.Interfaces
{
    public interface ICardCreator
    {
        Card CreateNewCard(Card card, User cardUser, string cardPassword);
    }
}
