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
        private Random rnd = new();
        public AddUserCard(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private async void CreateCardButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_db);
            User user = form1.user;
            Card card = new();
            try
            {
                card.User = user;
                card.CardNumbers = rnd.Next(100000, 999999).ToString();
                card.CardPassword = passwordTextBox.Text;
                await _db.AddAsync(card);
                await _db.SaveChangesAsync();
                MessageBox.Show("Your password was created successfully");
                ActionsForm actionsForm = new(_db);
                actionsForm.Show();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddUserCard_Load(object sender, EventArgs e)
        {

        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_db);
            form1.Close();
        }
    }
}
