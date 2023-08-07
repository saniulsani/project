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
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.txtOutputUsername.Text = this.txtUsername.Text;
            this.lblPassword.Text = this.txtPassword.Text;
            this.lblDepartment.Text = this.cmbDepartment.Text;
            this.lblDOB.Text = this.dtpDOB.Text;
            if (this.rbUndergrad.Checked)
                this.lblProgram.Text = "Under Graduate";
            else if (this.rbGrad.Checked)
                this.lblProgram.Text = this.rbGrad.Text;

            MessageBox.Show("Showing Data");
            this.pnlOutput.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "";
            this.txtPassword.Clear();
            this.cmbDepartment.SelectedIndex = -1;//this.cmbDepartment.Text = "";
            this.dtpDOB.Text = "";
            this.rbUndergrad.Checked = false;
            this.rbGrad.Checked = false;

            this.txtOutputUsername.Clear();
            this.lblPassword.Text = "";
            this.lblDepartment.Text = "oDepartment";
            this.lblDOB.Text = "";
            this.lblProgram.Text = "";

            this.pnlOutput.Visible = false;

        }
    }
}
