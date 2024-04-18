using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using ATMAppCollege.Implementations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMAppCollege
{
    public partial class CashOut : Form
    {
        private readonly AppDbContext _db;
        public CashOut(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private async void CashOutButton_Click(object sender, EventArgs e)
        {
            ActionsForm actionForm = new(_db);
            Card currentCard = await _db.Cards.Include(c => c.User).FirstOrDefaultAsync(c => c.User == CurrentUser.User);
            await BankActions.CashOut(currentCard, Convert.ToDouble(cashOutTextBox.Text));
            actionForm.Show();
            Close();
        }

        private void CashOut_Load(object sender, EventArgs e)
        {
        }
    }
}
