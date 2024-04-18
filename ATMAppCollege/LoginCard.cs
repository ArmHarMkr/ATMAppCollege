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
    public partial class LoginCard : Form
    {
        private readonly AppDbContext _db;
        public LoginCard()
        {
            InitializeComponent();
        }

        private async void LoginCardButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new(_db);
            User currentUser = form1.user;
            Card card = await _db.Cards.FirstOrDefaultAsync(c => c.User == currentUser);
            if (card.CardPassword == cardLoginInput.Text)
            {
                ActionsForm actionForm = new(_db);
                actionForm.Show();
                this.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new(_db);
            form1.Close();
        }
    }
}
