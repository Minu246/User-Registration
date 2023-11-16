using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            
        }

        private void pASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepass obj=new changepass();
            obj.Show();
            this.Visible = false;
        }

        private void pROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editprofile obj=new editprofile();
            obj.Show();
            this.Visible = false;
        }

        private void rEGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regviewcs obj= new regviewcs();
                obj.Show();
            this.Visible = false;
        }
    }
}
