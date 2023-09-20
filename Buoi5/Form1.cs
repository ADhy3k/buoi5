using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider1;
        public Form1()
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My Name is: " + textBox1.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(textBox2.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat", "Thoat", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                    MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider2.SetError(ctr, "This is not avalid number");
            else
                this.errorProvider2.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider2.SetError(ctr, "You must enter Your Name");
            else
                this.errorProvider2.Clear();
        }

    }
}
