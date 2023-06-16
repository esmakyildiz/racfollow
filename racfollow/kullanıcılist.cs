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
    public partial class kullanıcılist : Form
    {
        public kullanıcılist()
        {
            InitializeComponent();
        }

        private void kullanıcılist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'racfollow_maindbDataSet.kullanıcılar_bilgi' table. You can move, or remove it, as needed.
            this.kullanıcılar_bilgiTableAdapter.Fill(this.racfollow_maindbDataSet.kullanıcılar_bilgi);

        }
    }
}
