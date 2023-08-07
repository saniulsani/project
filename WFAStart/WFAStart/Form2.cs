using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAStart
{
    public partial class Form2 : Form
    {
        private Form1 F1 { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string input, Form1 f1)
        {
            InitializeComponent();
            this.lblOutput.Text += input.ToUpper();
            this.F1 = f1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.Show();
            this.F1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            this.F1.Show();
            this.Hide();
        }
    }
}
