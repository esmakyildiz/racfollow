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
    public partial class user_form : Form
    {
        public user_form()
        {
            InitializeComponent();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            adduserform ekle = new adduserform();
            ekle.Show();
        }

        private void listuser_Click(object sender, EventArgs e)
        {
            kullanıcılist ekle = new kullanıcılist();
            ekle.Show();
        }
    }
}
