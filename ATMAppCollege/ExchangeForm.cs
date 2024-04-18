using ATMAppCollege.Data;

namespace ATMAppCollege
{
    public partial class ExchangeForm : Form
    {
        private readonly AppDbContext _db;
        public ExchangeForm(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string selectedFromNominal = NominalOpt.Text.ToString();
            double exchangingMoney = Convert.ToDouble(ConvertingMoney.Text);
            if(selectedFromNominal == "Dollar")
            {
                double resMoney = exchangingMoney * 404.51;
                ConvertResultLabel.Text = resMoney.ToString();
            }
            else
            {
                double resMoney = exchangingMoney / 404.51;
                ConvertResultLabel.Text = resMoney.ToString();
            }
            
        }

        private void GoToActions_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
