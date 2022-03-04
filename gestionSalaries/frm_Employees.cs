using gestionSalaries.Includes;
using System;
using System.Data;
using System.Windows.Forms;


namespace gestionSalaries
{
    public partial class frm_Employees : Form
    {
        public frm_Employees()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        Fonctionutil funct = new Fonctionutil();
        string sql;
        string rdo;
        private void btnempenregis_Click(object sender, EventArgs e)
        {

            if (txtcode.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtmname.Text == ""
                || txtaddress.Text == "" || txtcontact.Text == "" || txtstatus.Text == "" || txtbplace.Text == ""
                || txtage.Text == "" || txtemerg.Text == "" || txtdrate.Text == "" || txtposition.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rdomale.Checked)
                {
                    rdo = "Mâle";
                }
                else
                {
                    rdo = "Femelle";
                }
                sql = "INSERT INTO `employee_workinfo` (`emp_code`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`)"
                        + " VALUES ('" + txtcode.Text + "','" + txtdrate.Text + "','" + txtpmethod.Text + "','" + txtposition.Text
                        + "','" + txtworkstatus.Text + "','" + dtpdhired.Text + "')";
                config.Execute_Query(sql);

                sql = "INSERT INTO `employee` (`emp_code`, `emp_fname`, `emp_lname`, `emp_mname`"
                   + ", `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`"
                   + ", `emerg_contct`) VALUES ('" + txtcode.Text + "','" + txtfname.Text + "','" + txtlname.Text
                   + "','" + txtmname.Text + "','" + txtaddress.Text + "'," + txtcontact.Text + ",'" + txtstatus.Text
                   + "','" + dtpdbirth.Text + "','" + txtbplace.Text + "','" + rdo + "'," + txtage.Text + ",'" + txtcontact.Text + "')";
                config.Execute_CUD(sql, "Error to execute.", "Les données ont étaient modifiées !");
                btnempnv_Click(sender, e);
            }

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew  WHERE e.`emp_code`=ew.`emp_code` AND e.emp_code ='" + txtcode.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtdrate.Text = config.dt.Rows[0].Field<int>("d_rate").ToString();
                txtpmethod.Text = config.dt.Rows[0].Field<string>("p_method").ToString();
                txtposition.Text = config.dt.Rows[0].Field<string>("position").ToString();
                txtworkstatus.Text = config.dt.Rows[0].Field<string>("w_status").ToString();
                dtpdhired.Text = config.dt.Rows[0].Field<DateTime>("d_hired").ToString();

                txtfname.Text = config.dt.Rows[0].Field<string>("emp_fname").ToString();
                txtlname.Text = config.dt.Rows[0].Field<string>("emp_lname").ToString();
                txtmname.Text = config.dt.Rows[0].Field<string>("emp_mname").ToString();
                txtaddress.Text = config.dt.Rows[0].Field<string>("address").ToString();
                txtcontact.Text = config.dt.Rows[0].Field<int>("contact").ToString();
                txtstatus.Text = config.dt.Rows[0].Field<string>("status").ToString();
                dtpdbirth.Text = config.dt.Rows[0].Field<DateTime>("birth_date").ToString();
                txtbplace.Text = config.dt.Rows[0].Field<string>("birth_place").ToString();

                if (config.dt.Rows[0].Field<string>("emp_sex").ToString() == "Mâle")
                {
                    rdomale.Checked = true;
                }
                else
                {
                    rdofemale.Checked = true;

                }

                txtage.Text = config.dt.Rows[0].Field<int>("emp_age").ToString();
                txtcontact.Text = config.dt.Rows[0].Field<int>("emerg_contct").ToString();

                btnempenregis.Enabled = false;
                btnempupdate.Enabled = true;

            }
            else
            {
                funct.clearTxt(GroupBox10);
                funct.clearTxt(GroupBox9);
                btnempenregis.Enabled = true;
                btnempupdate.Enabled = false;
            }

        }

        private void btnempnv_Click(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox10);
            funct.clearTxt(GroupBox9);

            btnempenregis.Enabled = true;
            btnempupdate.Enabled = false;
            txtcode.Clear();

            list_Employee();
            funct.ResponsiveDtg(dtgemplist);
        }

        private void btnmodifier_Click(object sender, EventArgs e)

        {
            if (txtcode.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtmname.Text == ""
              || txtaddress.Text == "" || txtcontact.Text == "" || txtstatus.Text == "" || txtbplace.Text == ""
              || txtage.Text == "" || txtemerg.Text == "" || txtdrate.Text == "" || txtposition.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rdomale.Checked)
                {
                    rdo = "Mâle";
                }
                else
                {
                    rdo = "Femelle";
                }

                sql = "UPDATE `employee_workinfo` SET  `d_rate`='" + txtdrate.Text
                  + "', `p_method`='" + txtpmethod.Text + "', `position`='" + txtposition.Text
                  + "', `w_status`='" + txtworkstatus.Text + "', `d_hired`='" + dtpdhired.Text + "' WHERE `emp_code`='" + txtcode.Text + "'";
                config.Execute_Query(sql);

                sql = "UPDATE `employee` SET  `emp_fname`='" + txtfname.Text
                + "', `emp_lname`='" + txtlname.Text + "', `emp_mname`='" + txtmname.Text
                + "', `address`='" + txtaddress.Text + "', `contact`='" + txtcontact.Text + "', `status`='" + txtstatus.Text
                + "', `birth_date`='" + dtpdbirth.Text + "', `birth_place`='" + txtbplace.Text + "', `emp_sex`='" + rdo
                + "', `emp_age`='" + txtage.Text + "', `emerg_contct`='" + txtcontact.Text
                + "' WHERE `emp_code`='" + txtcode.Text + "'";
                config.Execute_CUD(sql, "Error to execute.", "Les données ont étaient modifiées !");
                

            }
        }

        private void list_Employee()
        {
            sql = "SELECT `emp_code` AS 'CODE',CONCAT( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) AS 'NOM'"
             + ", `emp_age` AS 'AGE', `emp_sex` AS 'SEXE', `status` AS 'STATUT', `address` AS 'ADRESSE'"
             + ", `contact` AS 'MOBILE'  FROM `employee` WHERE `emp_code` LIKE '%" + txtempsearch.Text + "%'"
             + " OR emp_fname LIKE '%" + txtempsearch.Text + "%' OR emp_lname LIKE '%" + txtempsearch.Text + "%'";
            config.Load_DTG(sql, dtgemplist);
        }

        private void frm_Employees_Load(object sender, EventArgs e)
        {
            btnempnv_Click(sender, e);
        }

        private void txtempsearch_TextChanged(object sender, EventArgs e)
        {
            list_Employee();
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM employee WHERE emp_code = '" + dtgemplist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM employee_workinfo  WHERE emp_code = '" + dtgemplist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM other_deduction WHERE emp_code = '" + dtgemplist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.Execute_Query(sql);

            MessageBox.Show("L\'employée à été supprimé avec succes !.", "Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnempnv_Click(sender, e);
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            txtcode.Text = dtgemplist.CurrentRow.Cells[0].Value.ToString();
            TabControl2.SelectedTab = TabPage6;
            btnempenregis.Enabled = false;
            btnempupdate.Enabled = true;


        }

        private void Label26_Click(object sender, EventArgs e)
        {

        }

        private void Label31_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void txtworkstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Label34_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void Label36_Click(object sender, EventArgs e)
        {

        }
    }
}
