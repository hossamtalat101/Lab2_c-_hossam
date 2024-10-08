﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            enabled(false);
          
        }
        public void enabled(bool Choice)
        {
            btnSum.Enabled = Choice;
            btnSub.Enabled = Choice;
            btnMult.Enabled = Choice;
            btnDiv.Enabled = Choice;
        }
        public void Operation(double Num1, double Num2, string op)
        {
            switch(op)
            {
                case "+":
                    txtResult.Text = (Num1 + Num2).ToString();
                    break;
                case "-":
                    txtResult.Text = (Num1 - Num2).ToString();
                    break;
                case "*":
                    txtResult.Text = (Num1 * Num2).ToString();
                    break;
                case "/":
                    if (Num2 != 0)
                        txtResult.Text = (Num1 / Num2).ToString();
                    else
                        MessageBox.Show("خطأ", "قسمة على صفر", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    break;
                default:
                    MessageBox.Show("تحذير", "خطأ في العملية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    break;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtNum2.TextChanged += txtNum1_TextChanged;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Operation(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Operation(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Operation(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Operation(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "/");
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Text = "";
            txtResult.Text = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            bool F = (txtNum1.Text.Trim() != "" && txtNum2.Text.Trim() != "");
            enabled(F);
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && ((e.KeyChar!='-') || ((TextBox)sender).Text.Length != 0))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') >-1))
                e.Handled = true;
            
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && ((e.KeyChar != '-') || ((TextBox)sender).Text.Length != 0))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

        }
    }
}
