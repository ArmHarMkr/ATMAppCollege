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
    public partial class UserInfoForm : Form
    {
        private readonly AppDbContext _db;
        public User currentUser;
        public Card? currentCard;
        public UserInfoForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }


        private async void UserInfoForm_Load(object sender, EventArgs e)
        {
            currentCard = await _db.Cards.Include(c => c.User).FirstOrDefaultAsync(c => c.User == CurrentUser.User);
            NameLabel.Text = CurrentUser.User.FullName;
            CardNumberLabel.Text = currentCard.CardNumbers;
            EmailLabel.Text = CurrentUser.User.Email;
            PasswordLabel.Text = CurrentUser.User.Password;
            PinCodeLabel.Text = currentCard.CardPassword;
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ActionsForm af = new(_db);
            af.Show();
            Close();
        }
    }
}
