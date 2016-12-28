using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psg_solutions
{
    public partial class aboutdeveloper : Form
    {
        public aboutdeveloper()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutdeveloper_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnClosed(EventArgs e)
        {
          Form1 a = new Form1();
            a.Show();
        }
    }
}
