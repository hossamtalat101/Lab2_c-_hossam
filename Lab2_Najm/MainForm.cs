using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Najm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form frm1 = new Form1();
        private void btnClose_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }

        Form frm2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        Form frm3 = new Form3();
        private void button2_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }

       
    }
}
