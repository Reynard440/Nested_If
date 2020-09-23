using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nested_If
{
    public partial class frmNested : Form
    {
        public frmNested()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(txtTemp.Text);
            if(temp <= 15)
            {
                lblFirstMessageBox.BackColor = Color.Green;
                lblSecondMessageBox.BackColor = Color.DimGray;
                lblNested.Text = "if(" + temp.ToString() + " <= 15)";
                MessageBox.Show("It's cold, wear a jacket", "Result: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear.Focus();
            }
            else
            {
                lblFirstMessageBox.BackColor = Color.DimGray;
                lblSecondMessageBox.BackColor = Color.Green;
                lblNested.Text = "if(" + temp.ToString() + " <= 15)";
                MessageBox.Show("It's warm, no jecket needed", "Result: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear.Focus();
            }
        }

        private void frmNested_Load(object sender, EventArgs e)
        {
            txtTemp.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblNested.Text = "if(lblTemp <= 15)";
            lblFirstMessageBox.BackColor = Color.DimGray;
            lblSecondMessageBox.BackColor = Color.DimGray;
            txtTemp.Clear();
            txtTemp.Focus();
        }
    }
}
