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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace miniproject
{

    
    public partial class changepass : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLOCALDB;AttachDbFilename=C:\\Users\\Hp\\Desktop\\csharpframe\\miniproject\\Database1.mdf");
        SqlCommand cmd;
        string sql;
       


        public changepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                string newPass = textBox2.Text;
                string confirm = textBox3.Text;
                if (newPass == confirm)
                { 
                sql = "update login set Password='" + textBox2.Text + "' where Username='" + textBox1.Text + "' and Usertype='customer'";
                cmd = new SqlCommand(sql, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                      MessageBox.Show("password changed succeessfully");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox1.Focus();
                        home obj = new home();
                        obj.Show();

                
             
                }
                else
                {
                    MessageBox.Show("new password and confirm password doesn't match");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changepass_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home ob= new home();
            ob.Show();
            this.Visible = false;
        }
    }
}

        