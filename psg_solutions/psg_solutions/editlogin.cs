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
    public partial class editlogin : Form
    {
        public static string a;
        public static String b;
        public static String c;
        public static String d;
        public editlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             a = textBox1.Text;
             b = textBox2.Text;
            String passw=" ";
            try
            {
                if (a == "" || b == "")
                {
                    MessageBox.Show("Enter all the data");
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select password1,photo,rollno from Table2 where username='" + a + "'";
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=login.mdb");
                    OleDbDataAdapter adapt = new OleDbDataAdapter(query, con);
                    con.Open();
                    adapt.Fill(dt);
                    con.Close();
                    foreach (DataRow entry in dt.Rows)
                    {
                         passw = entry["password1"].ToString();
                         c = entry["photo"].ToString();
                         d = entry["rollno"].ToString();
                    }
                    if (passw == b)
                    {
                        edit obj1 = new edit();
                        this.Hide();
                        obj1.Show();
                    }
                    else
                    {
                        MessageBox.Show("no existing profile : create a new one");
                    }

                }
            }
            catch(Exception ex)
            {
            }
        }
        public String value
        {
            get { return a; }
        }
    }
}
