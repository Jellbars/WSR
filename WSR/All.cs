using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR
{
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
        }

        private void входToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
        }

        private void итоговойРазмерПлатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager_koef koef = new Manager_koef();
            koef.Show();
            koef.MdiParent = this;
        }
    }
}
