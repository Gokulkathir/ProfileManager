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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutdeveloper a = new aboutdeveloper();
            this.Hide();
            a.Show(); 
        }

        private void aboutPSGTECHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutpsg a = new aboutpsg();
            this.Hide();
            a.Show(); 
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Developer");
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newprofile c = new newprofile();
            this.Hide();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editlogin obj1 = new editlogin();
            this.Hide();
            obj1.Show();
        }
    
    }
}
