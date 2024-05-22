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
            // Create a bitmap of the same size as the form's client area
            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);

            // Get the graphics object of the bitmap
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Copy the form's client area to the bitmap
                g.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), ClientSize);
            }

            string uniqueName = Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString();

            // Save the bitmap as a PNG file
            string filePath = $"C:\\Users\\harmk\\Documents\\{uniqueName}.png";
            bmp.Save(filePath, ImageFormat.Png);

            MessageBox.Show("Screenshot saved successfully!");
        }
    }
}
