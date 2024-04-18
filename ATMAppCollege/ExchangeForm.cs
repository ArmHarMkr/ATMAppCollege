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
            string selectedToNominal = ToNominalOpt.Text.ToString();
            double exchangingMoney = Convert.ToDouble(ConvertingMoney);
            if(selectedFromNominal == "Dollar")
            {
                ToNominalOpt.Text = "AMD";
            }
            else
            {
                ToNominalOpt.Text = "Dollar";
            }

            if(selectedFromNominal == "Dollar")
            {
                double resMoney = exchangingMoney * 404.51;
                label1.Text = resMoney.ToString();
            }
            else
            {
                double resMoney = exchangingMoney / 404.51;
                label1.Text = resMoney.ToString();
            }
            
        }

        private void GoToActions_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
