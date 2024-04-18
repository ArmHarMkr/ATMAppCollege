using ATMAppCollege.Data;
using ATMAppCollege.Entity;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ATMAppCollege
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _db;
        public User user = new User();
        public List<User> users;
        public Form1(AppDbContext db)
        {
            _db = db;
            users = _db.Users.ToList();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
        }

        bool isValid = true;
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (FullNameInput.Text.Length > 5)
            {
                user.FullName = FullNameInput.Text;
            }
            else
            {
                MessageBox.Show("Not valid name");
                isValid = false;
            }
            if (EmailInput.Text.Length > 3 &&
                EmailInput.Text.Contains("@"))
            {
                user.Email = EmailInput.Text;
            }
            else
            {
                isValid = false;
                MessageBox.Show("Your email is invalid");
            }
            if (PasswordInput.Text.Length > 8)
            {
                user.Password = PasswordInput.Text;
            }
            else
            {
                isValid = false;
                MessageBox.Show("The password must have 8 symbols, contain letters and special symbols");
            }
            if (MaleRadio.Checked)
            {
                FemaleRadio.Checked = false;
                user.Gender = 'M';
            }
            else if (FemaleRadio.Checked)
            {
                isValid = true;
                MaleRadio.Checked = false;
                user.Gender = 'F';
            }
            else
            {
                isValid = false;
                MessageBox.Show("Opt gender");
            }
            if (isValid)
            {
                _db.Add(user);
                _db.SaveChanges();
                AddUserCard addUserCard = new(_db);
                users = _db.Users.ToList();
                addUserCard.Show();
                Form1 form1 = new(_db);
                this.Hide();
            }
        }

        private void LoginReference_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new(_db);
            AddUserCard addUserCard = new(_db);
            loginPage.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}