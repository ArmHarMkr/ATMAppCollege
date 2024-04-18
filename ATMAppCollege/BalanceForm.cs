using ATMAppCollege.Data;
using ATMAppCollege.Entity;
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
    public partial class BalanceForm : Form
    {
        private readonly AppDbContext _db;
        public BalanceForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            ActionsForm actionsForm = new(_db);
            actionsForm.Show();
            Close();
        }

        private async void BalanceForm_Load(object sender, EventArgs e)
        {
            ActionsForm actionsForm = new(_db);
            try
            {
                Card currentCard = await _db.Cards.Include(c => c.User).FirstOrDefaultAsync(c => c.User == CurrentUser.User);
                if(currentCard != null)
                    BalanceLabel.Text = "You have: $" + currentCard.AccessibleMoney.ToString();
                else
                    MessageBox.Show("No card found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
