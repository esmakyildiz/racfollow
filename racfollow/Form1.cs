using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace racfollow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usersbutton_Click_1(object sender, EventArgs e)
        {
            user_form ekle = new user_form();
            ekle.ShowDialog();
        }

        private void cars_button_Click(object sender, EventArgs e)
        {
            cars_form ekle = new cars_form();
            ekle.ShowDialog();
        }
    }
}
