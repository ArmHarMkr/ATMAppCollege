using ATMAppCollege.Data;
using System.Drawing.Imaging;

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
            if (selectedFromNominal == "Dollar")
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CaptureAndSaveScreenshot();
        }

        private void CaptureAndSaveScreenshot()
        {
            try
            {
                Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), ClientSize);
                }

                string uniqueName = Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                string filePath = $"C:\\Users\\harmk\\Documents\\{uniqueName}.png";
                bmp.Save(filePath, ImageFormat.Png);

                MessageBox.Show("Screenshot saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving screenshot: {ex.Message}");
            }
        }
    }
}
