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
    public partial class TransferForm : Form
    {
        private readonly AppDbContext _db;
        public TransferForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void MoneyTransfer_Click(object sender, EventArgs e)
        {
            ActionsForm actionsForm = new(_db);
            BankActions.TransferOtherBank(actionsForm.currentCard, Convert.ToDouble(SendAmountInput.Text));

        }
    }
}
