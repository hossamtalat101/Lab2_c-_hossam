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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = z = x + y;
                textBox3.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("تحذير", "أدخل قيم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
            //=============================================
            //double x = Convert.ToDouble(textBox1.Text);
            //double y = Convert.ToDouble(textBox2.Text);
            //double z = z = x + y;
            //textBox3.Text = z.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48) || (e.KeyChar>57)) && (e.KeyChar!=8))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48) || (e.KeyChar > 57)) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
            //button1.Enabled = (textBox1.Text != "" && textBox2.Text != "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
