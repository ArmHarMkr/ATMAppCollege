using ATMAppCollege.Data;
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
            await BankActions.CashOut(actionForm.currentCard, Convert.ToDouble(cashOutMasked));
            actionForm.Show();
            Close();
        }

        private void CashOut_Load(object sender, EventArgs e)
        {
        }
    }
}
