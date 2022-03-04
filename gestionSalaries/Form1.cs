using System;
using System.Windows.Forms;


namespace gestionSalaries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void enable_menu()
        {
            tsLogin.Text = "Déconnexion";
            tsEmployee.Enabled = true;
            tsPayroll.Enabled = true;
            tsUser.Enabled = true;
            tsContact.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void closeChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_Employees());
        }

        private void tsPayroll_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_Paie());
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_utilisateur());
        }

        private void tsContact_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_Contact());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if (tsLogin.Text == "Login")
            {
                closeChildForm();
                showFrm(new frm_login(this));
            }
            else
            {
                tsLogin.Text = "Login";
                tsEmployee.Enabled = false;
                tsPayroll.Enabled = false;
                tsUser.Enabled = false;
                tsContact.Enabled = false;
            }
        }
       
        private void AdminName_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
