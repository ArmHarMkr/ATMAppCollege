using ATMAppCollege.Data;
using ATMAppCollege.Entity;
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
    public partial class LoginPage : Form
    {
        private readonly AppDbContext _db;
        public LoginPage(AppDbContext db)
        {
            _db = db;   
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new(_db);
            LoginPage loginPage = new(_db);
            loginPage.Hide();
            registerForm.Show();
        }

        private void LoginReference_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new(_db);
            IEnumerable<User> users = _db.Users; 
            foreach (var user in users)
            {
                if(user.Email == EmailInput.Text)
                {
                    if(user.Password == PasswordInput.Text && 
                        RulesCheckBox.Checked)
                    {
                        LoginCard login = new(_db);
                        login.Show();
                        CurrentUser.User = user;
                        Close();
                        break;
                    }
                    else
                    {
                        if (!RulesCheckBox.Checked)
                        {
                            MessageBox.Show("Check the Rules text box");
                        }
                        else
                        {
                            MessageBox.Show("Wrong password");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Email found. Register");
                }
                
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }
       
    }
   
}
