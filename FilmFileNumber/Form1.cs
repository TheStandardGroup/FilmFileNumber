using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FilmFileNumber
{
    public partial class Form1 : Form
    {
        //private const string sConnection = "Server=SGMISSQL;DataBase=SGlive_dosrun;User Id=;Password=";
        private string sConnection = null;
        private string dataBase = "SGlive_dosrun";
        public static DataTable dt = null;
        public bool bJobNumOK = true;
        public char chBadChar = Convert.ToChar(0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sConnection = "Server=SGMISSQL;DataBase=" + dataBase + "; Integrated Security=SSPI";
            txtJobNumber.KeyPress += new KeyPressEventHandler(txtJobNumber_KeyPress);
            txtJobNumber.TextChanged += new EventHandler(txtJobNumber_TextChanged);
            txtNewPFN.KeyPress +=new KeyPressEventHandler(txtNewPFN_KeyPress);
            txtNewPFN.Enabled = false;
            txtJobNumber.Focus();
            btnUpdate.Enabled = false;
            this.BackColor = Color.FromArgb(28, 63, 119);
            this.ForeColor = Color.White;
            btnExit.BackColor = Color.FromArgb(231, 185, 1);
            btnExit.ForeColor = Color.Black;
            btnJobnumber.BackColor = Color.FromArgb(231, 185, 1);
            btnJobnumber.ForeColor = Color.Black;
            btnUpdate.BackColor = Color.FromArgb(231, 185, 1);
            btnUpdate.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.FromArgb(28, 63, 200);
            menuStrip1.ForeColor = Color.White;
        }

        void txtJobNumber_TextChanged(object sender, EventArgs e)
        {
            if (!bJobNumOK)
            {
                    bJobNumOK = false;
                    MessageBox.Show("The value '" + chBadChar + "' was entered.  The job number may contain numeric values only.", "Numbers Only", MessageBoxButtons.OK);
                    string sBadString = txtJobNumber.Text;
                    bJobNumOK = true;
                    txtJobNumber.Text = sBadString.Replace(chBadChar, Convert.ToChar(0));             
            }

            try
            {
                Int64 iChar = Convert.ToInt64(txtJobNumber.Text);
                bJobNumOK = true;
            }
            catch
            {
                bJobNumOK = false;
            }

            txtJobNumber.Select(txtJobNumber.Text.Length, 0);
        }

        void txtJobNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chCR = Convert.ToChar(13);
            char chBS = Convert.ToChar(8);

            if (e.KeyChar.ToString() == chCR.ToString())
                LookupJobInfo();

            if (e.KeyChar.ToString() != chBS.ToString())
            {
                try
                {
                    Int16 iChar = Convert.ToInt16(e.KeyChar.ToString());
                    bJobNumOK = true;
                }
                catch
                {
                    bJobNumOK = false;
                    chBadChar = e.KeyChar;                   
                }
            }
        }

        void txtNewPFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chCR = Convert.ToChar(13);

            if (e.KeyChar.ToString() == chCR.ToString())
                UpdatePlateFileNumber();
        }

        private void UpdatePlateFileNumber()
        {
            if (txtNewPFN.Text.Length > 8)
            {
                MessageBox.Show("The maximum length of the plate number is 8 characters.  Please enter any alpha-numeric value of 8 characters or less.",
                    "Invalid Plate Number", MessageBoxButtons.OK);
                txtNewPFN.Focus();
                txtNewPFN.Select(txtNewPFN.Text.Length, 0);
            }
            else
            {
                DialogResult drUpdate = MessageBox.Show("Change the Plate Number for" + System.Environment.NewLine +
                    "job number " + lblJobNumber.Text.Trim() + " from \"" + lblCurrentPFN.Text.Trim() + "\" to \"" + txtNewPFN.Text.Trim() + "\"?",
                    "Update Confirmation", MessageBoxButtons.YesNo);

                if (drUpdate == DialogResult.Yes)
                {
                    txtNewPFN.Enabled = false;
                    int iUpdate = UpdateTicket1Table();

                    if (iUpdate == 1)
                    {
                        string sOldPFN = lblCurrentPFN.Text.Trim().ToString();
                        lblCurrentPFN.Text = txtNewPFN.Text;
                        txtNewPFN.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("There was a problem updating the SGlive_dosrun..TICKET1 table. " + System.Environment.NewLine +
                            "Please contact the System Administrator.", "Database Update Error", MessageBoxButtons.OK);
                    }

                    txtNewPFN.Enabled = true;
                    txtJobNumber.Focus();
                    txtJobNumber.Select(txtJobNumber.Text.Length, 0);
                }
            }
        }

        private int UpdateTicket1Table()
        {
            string sSQL = "UPDATE TICKET1 " +
                "SET \"PLATE FILE NO\"='" + txtNewPFN.Text.Trim().ToString() + "' " +
                "WHERE \"ESTIMATE RECNUM\"=" + dt.Rows[0].ItemArray[2].ToString() +
                "AND \"DATAFLEX RECNUM ONE\"=" + dt.Rows[0].ItemArray[3].ToString() +
                "AND \"PLATE FILE NO\"='" + dt.Rows[0].ItemArray[1].ToString() + "'";
            SqlConnection conn = new SqlConnection(sConnection);
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            conn.Open();
            int iUpdate = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return iUpdate;
        }

        private void btnJobnumber_Click(object sender, EventArgs e)
        {
            LookupJobInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePlateFileNumber();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void LookupJobInfo()
        {
            try
            {
                Int64 iChar = Convert.ToInt64(txtJobNumber.Text);
                bJobNumOK = true;
            }
            catch
            {
                bJobNumOK = false;
            }

            if (!String.IsNullOrEmpty(txtJobNumber.Text.Trim().ToString()) && txtJobNumber.Text.Trim().ToString() != "" && 
                txtJobNumber.Text.Trim().ToString().Length > 0  && bJobNumOK)
            {
                txtJobNumber.Enabled = false;
                txtNewPFN.Enabled = true;
                txtNewPFN.Focus();
                txtNewPFN.Select(txtNewPFN.Text.Length, 0);
                dt = QueryForJobInfo();

                if (dt != null && dt.Rows.Count == 1)
                {
                    lblJobNumber.Text = dt.Rows[0].ItemArray[0].ToString();
                    lblCurrentPFN.Text = dt.Rows[0].ItemArray[1].ToString();
                    lblDescription.Text = dt.Rows[0].ItemArray[4].ToString();
                    txtJobNumber.Text = "";
                    txtNewPFN.Enabled = true;
                    txtNewPFN.Text = "";
                    txtNewPFN.Focus();
                    btnUpdate.Enabled = true;
                }
                else
                {
                    DialogResult drResult = MessageBox.Show("Job number does not exist.", "No Matching Job Number", MessageBoxButtons.OK);
                    Form1.dt = null;
                    txtJobNumber.Text = "";
                    txtJobNumber.Focus();
                    txtJobNumber.Select(txtJobNumber.Text.Length, 0);
                }

                txtJobNumber.Enabled = true;
            }
            else
            {
                MessageBox.Show("You have not entered a valid job number.  Please enter the job number you would like to load (must contain numeric values only).", 
                    "No Job Number", MessageBoxButtons.OK);
                txtJobNumber.Focus();
                txtJobNumber.Select(txtJobNumber.Text.Length, 0);
            }
        }

        private DataTable QueryForJobInfo()
        {
            string sSQL = "SELECT e.\"JOB NUMBER\", t1.\"PLATE FILE NO\", e.\"DATAFLEX RECNUM ONE\", t1.\"DATAFLEX RECNUM ONE\", e.\"DETAILS1\" " +
                "FROM Estimate e " +
                "JOIN TICKET1 t1 ON t1.\"ESTIMATE RECNUM\"=e.\"DATAFLEX RECNUM ONE\" " +
                "WHERE e.\"JOB NUMBER\"=" + txtJobNumber.Text.Trim().ToString();

            SqlConnection conn = new SqlConnection(sConnection);
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            conn.Close();
            conn.Dispose();
            return dt;
        }

        public string getDbName() {
            return dataBase;
        }

        public void setDbName(string n) {
            dataBase = n;
            sConnection = sConnection = "Server=SGMISSQL;DataBase=" + dataBase + "; Integrated Security=SSPI";
        }

        private void changeServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChange temp = new frmChange(this);
            btnUpdate.Enabled = false;
            txtJobNumber.Focus();
            txtNewPFN.Text = "";
            temp.ShowDialog();
        }
    }
}
