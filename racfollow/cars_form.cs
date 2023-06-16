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
    public partial class cars_form : Form
    {
        public cars_form()
        {
            InitializeComponent();
        }

        private void addcar_Click(object sender, EventArgs e)
        {
            addcar ekle = new addcar();
            ekle.Show();
        }
      
        private void listcar_Click_1(object sender, EventArgs e)
        {
            arabalist ekle = new arabalist();
            ekle.Show();
        }
    }
}