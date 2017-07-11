using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BELayer;
using BALayer;

namespace threeTierDesktopApp
{
    public partial class Form1 : Form
    {
        public BAL baobj = new BAL();
        public BEL beobj = new BEL();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beobj.name = tbName.Text;
            beobj.age = Convert.ToInt32(tbAge.Text);

            if (baobj.userdetails(beobj) > 0)
            {
                MessageBox.Show("Insert Successfull");
            }
        }
    }
}
