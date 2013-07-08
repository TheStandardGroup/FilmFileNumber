using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilmFileNumber
{
    public partial class frmChange : Form
    {
        Form1 myparent = null;
        public frmChange()
        {
            InitializeComponent();
        }

        public frmChange(Form1 myp)
        {
            InitializeComponent();
            myparent = myp;
            lblCurrentDb.Text = myparent.getDbName();
            this.BackColor = Color.FromArgb(28, 63, 119);
            this.ForeColor = Color.White;
            btnOkay.BackColor = Color.FromArgb(231, 185, 1);
            btnCancel.BackColor = Color.FromArgb(231, 185, 1);
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (tbNew.Text == "")
                System.Windows.Forms.MessageBox.Show("You must enter a new Database name", "Error");
            else
            {
                myparent.setDbName(tbNew.Text);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
