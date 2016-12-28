using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace psg_solutions
{
    public partial class edit : Form
    {
        public bool TC()
        {
            return false;
        }
        public edit()
        {
            InitializeComponent();
            label1.Text = editlogin.a;
            label2.Text = editlogin.d;
            Image.GetThumbnailImageAbort obj = new Image.GetThumbnailImageAbort(TC);
            Bitmap img = new Bitmap(editlogin.c);
            Image mythumb = img.GetThumbnailImage(96, 96, obj, IntPtr.Zero);
            pictureBox1.Image = mythumb;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String d=" ";
            DataTable dt = new DataTable();
            string query = "select learn1 from Table1 where username='" + editlogin.a + "'";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=login.mdb");
            OleDbDataAdapter adapt = new OleDbDataAdapter(query, con);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            foreach (DataRow entry in dt.Rows)
            {
               d = entry["learn1"].ToString();
            }
            d = d + " " + textBox1.Text;
            string query1 = "update Table1 set learn1 = '" + d + "' where username = '" + editlogin.a + "'";
            OleDbCommand cmd = new OleDbCommand(query1, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void edit_Load(object sender, EventArgs e)
        {

        }
    }
}
