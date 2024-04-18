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
        public LoginCard(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private async void LoginCardButton_Click(object sender, EventArgs e)
        {
            Card card = await _db.Cards.FirstOrDefaultAsync(c => c.User == CurrentUser.User);
            try
            {
                if (card.CardPassword == cardLoginInput.Text)
                {
                    ActionsForm actionForm = new(_db);
                    actionForm.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong password, try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new(_db);
            form1.Close();
        }
    }
}
