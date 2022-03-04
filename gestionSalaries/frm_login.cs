using gestionSalaries.Includes;
using System;
using System.Windows.Forms;


namespace gestionSalaries
{
    public partial class frm_login : Form
    {
        private Form1 frm;
        public frm_login(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from user WHERE username = '" + txt_username.Text + "' and Pass = '" + txt_password.Text + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                frm.enable_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrects !", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }
    private void label3_Click(object sender, EventArgs e)
    {
        Application.Exit();
            this.Close();
    }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
