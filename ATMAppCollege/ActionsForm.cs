using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using ATMAppCollege.Implementations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMAppCollege
{
    public partial class ActionsForm : Form
    {
        private readonly AppDbContext _db;
        public User currentUser;
        public Card? currentCard;
        public ActionsForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExchangeButton_Click(object sender, EventArgs e)
        {
            ExchangeForm exchangeForm = new ExchangeForm(_db);
            exchangeForm.Show();
        }

        private void TransOtherButton_Click(object sender, EventArgs e)
        {
        }

        private async void ActionsForm_Load(object sender, EventArgs e)
        {
            currentCard = await _db.Cards.FirstOrDefaultAsync(c => c.User == CurrentUser.User);
            testCardLabel.Text = currentCard.CardNumbers;
            testNameLabel.Text = CurrentUser.User.FullName;
        }

        private async void TransOwnBank_Click(object sender, EventArgs e)
        {
            TransferOwnBank transferOwnBank = new(_db);
            transferOwnBank.Show();
            this.Close();
        }

        private void CashInButton_Click(object sender, EventArgs e)
        {
            CashIn cashIn = new(_db);
            cashIn.Show();
            Close();
        }

        private void CashOutButton_Click(object sender, EventArgs e)
        {
            CashOut cashOut = new(_db);
            cashOut.Show();
            Close();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            BalanceForm bf = new(_db);
            bf.Show();
            Close();
        }

        private void testNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void UserInfoBtn_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfo = new(_db);
            userInfo.Show();
            Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new(_db);
            form1.Show();
            this.Close();
        }
    }
}
