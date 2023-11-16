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
    public partial class login : Form
    {   SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLOCALDB;AttachDbFilename=C:\\Users\\Hp\\Desktop\\csharpframe\\miniproject\\Database1.mdf");
        SqlCommand cmd;
        string sql;


        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            sql="select * from login where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'";
            cmd=new SqlCommand(sql,con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                MessageBox.Show("login success");
                textBox1.Clear();
                textBox2.Clear();
                home obj = new home();
                obj.Show();
                    this.Visible = false;
                }
            else
            {
                MessageBox.Show("user name or password is incorrect,try again ");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                  
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
