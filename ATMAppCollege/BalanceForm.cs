using ATMAppCollege.Data;
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

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            ActionsForm actionsForm = new(_db);
            BalanceLabel.Text = "You have: $" + actionsForm.currentCard.AccessibleMoney.ToString();
        }
    }
}
