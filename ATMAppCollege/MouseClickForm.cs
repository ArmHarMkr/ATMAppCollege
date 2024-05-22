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
    public partial class MouseClickForm : Form
    {
        public MouseClickForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click");
        }

        private void button1_MouseHover(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.White;
        }
    }
}
