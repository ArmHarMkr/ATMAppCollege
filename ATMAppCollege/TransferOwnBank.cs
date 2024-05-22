using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using ATMAppCollege.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMAppCollege
{
    public partial class TransferOwnBank : Form
    {
        private readonly AppDbContext _db;
        public TransferOwnBank(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private async void MoneyTransfer_Click(object sender, EventArgs e)
        {
            ActionsForm actionForm = new(_db);
            Card currentCard = await _db.Cards.Include(c => c.User).FirstOrDefaultAsync(c => c.User == CurrentUser.User);
            Card receiverCard = _db.Cards.FirstOrDefault(x => x.CardNumbers == CardNumberInput.Text);
            if(receiverCard == null)
            {
                MessageBox.Show("Type valid number");
            }
            if(receiverCard == currentCard)
            {
                MessageBox.Show("You cannot transfer money to yourself!");
            }
            else
            {
                if(currentCard.AccessibleMoney >= Convert.ToDouble(SendAmountInput.Text))
                {
                    currentCard.AccessibleMoney -= Convert.ToDouble(SendAmountInput.Text);
                    receiverCard.AccessibleMoney += Convert.ToDouble(SendAmountInput.Text);
                    await _db.SaveChangesAsync();
                    actionForm.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Not enough money");
                }
            }
        }

        private void TransferOwnBank_Load(object sender, EventArgs e)
        {
        }
    }
}
