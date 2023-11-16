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
    public partial class regviewcs : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLOCALDB;AttachDbFilename=C:\\Users\\Hp\\Desktop\\csharpframe\\miniproject\\Database1.mdf");
        SqlCommand cmd;
        string sql;

        public regviewcs()
        {
            InitializeComponent();
        }

        private void regviewcs_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "select Name,Address,Mobile,Place,District,Email,Username from Register where username='" + textBox1.Text + "' ";
            cmd = new SqlCommand(sql, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                label8.Text = rdr.GetString(0);
                label9.Text = rdr.GetString(1);
                label10.Text = rdr.GetString(2);
                label11.Text = rdr.GetString(3);
                label12.Text = rdr.GetString(4);
                label13.Text = rdr.GetString(5);

                
            }
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home obj = new home();
            obj.Show();
            this.Visible = false;
        }
    }
}
