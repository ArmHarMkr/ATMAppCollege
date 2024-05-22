using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using ATMAppCollege.Implementations;
using Microsoft.EntityFrameworkCore;

namespace ATMAppCollege
{
    public partial class CashIn : Form
    {
        private readonly AppDbContext _db;
        public CashIn(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private async void CashInButton_Click(object sender, EventArgs e)
        {
            ActionsForm actionForm = new(_db);
            Card currentCard = await _db.Cards.Include(c => c.User).FirstOrDefaultAsync(c => c.User == CurrentUser.User);
            if (CashInAmount.Text != string.Empty && currentCard != null)
            {
                currentCard.AccessibleMoney += Convert.ToDouble(CashInAmount.Text);
                _db.Cards.Update(currentCard);
                await _db.SaveChangesAsync();
                actionForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Input valid amount or Card Not Found");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ChashInAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
