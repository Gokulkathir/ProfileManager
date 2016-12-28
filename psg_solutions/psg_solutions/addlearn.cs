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
    public partial class addlearn : Form
    {
        public static int flag = 0;
        public addlearn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                string query = "insert into Table1(username,learn1) values ('" + newprofile.a1 + "','" + textBox1.Text + "')";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=login.mdb");
                OleDbCommand cmd = new OleDbCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                flag = 1;
            }
            else
            {
                String d=" ";
                DataTable dt = new DataTable();
                string query = "select learn1 from Table1 where username='"+newprofile.a1+"'";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=login.mdb");
                OleDbDataAdapter cmd = new OleDbDataAdapter(query, con);
                con.Open();
                cmd.Fill(dt);
                con.Close();
                foreach (DataRow entry in dt.Rows)
                {
                    d = entry["learn1"].ToString();
                }
                d = d + " " + textBox1.Text;
                textBox1.Text = "";
                string query1 = "update Table1 set learn1 = '" + d + "' where username = '" + newprofile.a1 + "'";
                OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=login.mdb");
                OleDbCommand cmd1 = new OleDbCommand(query1, con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
            }
        }
    }
}
