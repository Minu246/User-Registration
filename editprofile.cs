using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class editprofile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLOCALDB;AttachDbFilename=C:\\Users\\Hp\\Desktop\\csharpframe\\miniproject\\Database1.mdf");
        SqlCommand cmd;
        string sql;

        public editprofile()
        {
            InitializeComponent();
        }

        private void editprofile_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                    
                    sql = "update register set Name='" + textBox1.Text + "' , Address='"+textBox2.Text+"'where Username='" + textBox3.Text + "'";
                    cmd = new SqlCommand(sql, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    MessageBox.Show("data updated successfully");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox3.Focus();
                    home obj = new home();
                    obj.Show();



                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home ob = new home();
            ob.Show();
            this.Visible = false;
        }
    }
}

