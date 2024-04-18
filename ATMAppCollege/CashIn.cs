using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using ATMAppCollege.Implementations;

namespace ATMAppCollege
{
    public partial class CashIn : Form
    {
        private readonly AppDbContext _db;
        public CashIn(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void CashIn_Load(object sender, EventArgs e)
        {
            CashInProgress.Visible = false;
        }

        private void CashInButton_Click(object sender, EventArgs e)
        {
            ActionsForm actionForm = new(_db);
            Card currentCard = actionForm.currentCard;
            if (ChashInAmount != null)
            {
                BankActions.CashIn(currentCard, Convert.ToDouble(ChashInAmount.Text));
                actionForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Input valid amount");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
