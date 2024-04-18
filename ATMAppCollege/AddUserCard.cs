using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using ATMAppCollege.Implementations;
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
    public partial class AddUserCard : Form
    {
        private readonly AppDbContext _db;
        public AddUserCard(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private async void CreateCardButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_db);
            User user = form1.user;
            Card card = new Card();
            card.User = user;
            card.CardPassword = passwordTextBox.Text;
            await _db.AddAsync(card);
            _db.AddAsync(CardCreator.CreateNewCard(card, user, passwordTextBox.Text));
            await _db.SaveChangesAsync();
            MessageBox.Show("Your password was created successfully");
            ActionsForm actionsForm = new(_db);
            actionsForm.Show();
            this.Close();
        }

        private void AddUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
