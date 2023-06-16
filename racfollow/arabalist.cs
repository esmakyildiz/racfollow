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
    public partial class arabalist : Form
    {
        public arabalist()
        {
            InitializeComponent();
        }

        private void arabalist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'racfollow_maindbDataSet.arabalar_bilgi' table. You can move, or remove it, as needed.
            this.arabalar_bilgiTableAdapter.Fill(this.racfollow_maindbDataSet.arabalar_bilgi);

        }
    }
}
