using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMAppCollege.Implementations
{
    public static class BankActions
    {
        static readonly AppDbContext _db;
        public static void TransferOtherBank(Card senderCard, double sendAmount)
        {
            if (senderCard.AccessibleMoney > sendAmount)
            {
                senderCard.AccessibleMoney -= (sendAmount - sendAmount * 0.1);
                _db.Cards.Update(senderCard);
                _db.SaveChangesAsync();
            }
        }

        public async static Task TransferOurBank(Card senderCard, Card receiverCard, double sendAmount)
        {
            if(senderCard.AccessibleMoney > sendAmount)
            {
                senderCard.AccessibleMoney -= sendAmount;
                receiverCard.AccessibleMoney += sendAmount;
                _db.Cards.Update(senderCard);
                _db.Cards.Update(receiverCard);
                await _db.SaveChangesAsync();
            }
        }

        public async static Task CashIn(Card currentCard, double addingAmount)
        {
            currentCard.AccessibleMoney += addingAmount;
            _db.Cards.Update(currentCard);
            await _db.SaveChangesAsync();
        }

        public async static Task CashOut(Card currentCard, double withdrawAmount)
        {
            currentCard.AccessibleMoney -= withdrawAmount;
            _db.Cards.Update(currentCard);
            await _db.SaveChangesAsync();
        }
    }
}
