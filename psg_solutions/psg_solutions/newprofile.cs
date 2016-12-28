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
    public partial class newprofile : Form
    {
        String file = "null";
        public static string a1;
        public newprofile()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.InitialDirectory = @"C:\Users\HP PC\Desktop\psg_solutions\psg_solutions\bin\Debug";
            a.RestoreDirectory = true;
            a.Title = "Choose Profile picture";
            a.DefaultExt = "jpg";
            a.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            a.FilterIndex = 2;
            a.CheckFileExists = true;
            a.CheckPathExists = true;
            DialogResult dr = a.ShowDialog();
            if(dr==System.Windows.Forms.DialogResult.OK)
            {
                file= a.FileName;
                Image.GetThumbnailImageAbort obj = new Image.GetThumbnailImageAbort(TC);
                Bitmap img = new Bitmap(file);
                Image mythumb = img.GetThumbnailImage(96, 96, obj, IntPtr.Zero);
                pictureBox1.Image = mythumb;
            }
        }
        public bool TC()
        {
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.SelectedItem.ToString() == "" || (richTextBox1.Text == "") || file=="")
                {
                    MessageBox.Show("Enter all the data");
                }
                else
                {
                    a1 = textBox1.Text;
                    string query = "insert into Table2(username,password1,age,rollno,semno,department,phoneno,email,address,photo) values ('" + textBox1.Text +"','"+textBox7.Text+"','"+ textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox5.Text + "','" + textBox6.Text + "','" + richTextBox1.Text +"','"+file +"')";
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=login.mdb");
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                addlearn obj1 = new addlearn();
                this.Hide();
                obj1.Show();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.ToString();
            }
        }
    }
}
