namespace gestionSalaries
{
    partial class frm_utilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.GroupBox12 = new System.Windows.Forms.GroupBox();
            this.dtg_userList = new System.Windows.Forms.DataGridView();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_userList)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox11
            // 
            this.GroupBox11.BackColor = System.Drawing.Color.LightBlue;
            this.GroupBox11.Controls.Add(this.btn_supprimer);
            this.GroupBox11.Controls.Add(this.cbotype);
            this.GroupBox11.Controls.Add(this.Label38);
            this.GroupBox11.Controls.Add(this.txtname);
            this.GroupBox11.Controls.Add(this.btn_modifier);
            this.GroupBox11.Controls.Add(this.Button6);
            this.GroupBox11.Controls.Add(this.Label39);
            this.GroupBox11.Controls.Add(this.Label40);
            this.GroupBox11.Controls.Add(this.Label41);
            this.GroupBox11.Controls.Add(this.txtpass);
            this.GroupBox11.Controls.Add(this.txtuser);
            this.GroupBox11.Controls.Add(this.btnenregistrer);
            this.GroupBox11.Controls.Add(this.lbl_id);
            this.GroupBox11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox11.Location = new System.Drawing.Point(111, 28);
            this.GroupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox11.Size = new System.Drawing.Size(644, 245);
            this.GroupBox11.TabIndex = 7;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "Ajouter un nouvel utilisateur";
            this.GroupBox11.Enter += new System.EventHandler(this.GroupBox11_Enter);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(437, 196);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(109, 41);
            this.btn_supprimer.TabIndex = 15;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // cbotype
            // 
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Administrateur",
            "Personnel",
            "Visiteur"});
            this.cbotype.Location = new System.Drawing.Point(217, 138);
            this.cbotype.Margin = new System.Windows.Forms.Padding(4);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(167, 28);
            this.cbotype.TabIndex = 2;
            this.cbotype.Text = "Administrateur";
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cbotype_SelectedIndexChanged);
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.BackColor = System.Drawing.Color.Transparent;
            this.Label38.ForeColor = System.Drawing.Color.Black;
            this.Label38.Location = new System.Drawing.Point(134, 45);
            this.Label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(56, 20);
            this.Label38.TabIndex = 14;
            this.Label38.Text = "Nom :";
            this.Label38.Click += new System.EventHandler(this.Label38_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(217, 42);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(289, 27);
            this.txtname.TabIndex = 13;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.Yellow;
            this.btn_modifier.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(209, 196);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(112, 41);
            this.btn_modifier.TabIndex = 10;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(329, 197);
            this.Button6.Margin = new System.Windows.Forms.Padding(4);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 40);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "Nouveau";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.BackColor = System.Drawing.Color.Transparent;
            this.Label39.ForeColor = System.Drawing.Color.Black;
            this.Label39.Location = new System.Drawing.Point(34, 141);
            this.Label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(156, 20);
            this.Label39.TabIndex = 6;
            this.Label39.Text = "type d\'utilisateur :";
            this.Label39.Click += new System.EventHandler(this.Label39_Click);
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.BackColor = System.Drawing.Color.Transparent;
            this.Label40.ForeColor = System.Drawing.Color.Black;
            this.Label40.Location = new System.Drawing.Point(64, 109);
            this.Label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(126, 20);
            this.Label40.TabIndex = 4;
            this.Label40.Text = "Mot de passe :";
            this.Label40.Click += new System.EventHandler(this.Label40_Click);
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.BackColor = System.Drawing.Color.Transparent;
            this.Label41.ForeColor = System.Drawing.Color.Black;
            this.Label41.Location = new System.Drawing.Point(111, 78);
            this.Label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(79, 20);
            this.Label41.TabIndex = 5;
            this.Label41.Text = "Pseudo :";
            this.Label41.Click += new System.EventHandler(this.Label41_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(217, 106);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(289, 27);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(217, 73);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(289, 27);
            this.txtuser.TabIndex = 1;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.Lime;
            this.btnenregistrer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.Location = new System.Drawing.Point(105, 196);
            this.btnenregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(96, 41);
            this.btnenregistrer.TabIndex = 0;
            this.btnenregistrer.Text = "Ajouter";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(359, 78);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(25, 20);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "id";
            // 
            // GroupBox12
            // 
            this.GroupBox12.Controls.Add(this.dtg_userList);
            this.GroupBox12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox12.ForeColor = System.Drawing.Color.Black;
            this.GroupBox12.Location = new System.Drawing.Point(13, 281);
            this.GroupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox12.Size = new System.Drawing.Size(877, 231);
            this.GroupBox12.TabIndex = 6;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "Listes des utilisateurs";
            this.GroupBox12.Enter += new System.EventHandler(this.GroupBox12_Enter);
            // 
            // dtg_userList
            // 
            this.dtg_userList.AllowUserToAddRows = false;
            this.dtg_userList.AllowUserToDeleteRows = false;
            this.dtg_userList.AllowUserToResizeColumns = false;
            this.dtg_userList.AllowUserToResizeRows = false;
            this.dtg_userList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_userList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_userList.Location = new System.Drawing.Point(4, 24);
            this.dtg_userList.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_userList.Name = "dtg_userList";
            this.dtg_userList.RowHeadersVisible = false;
            this.dtg_userList.RowHeadersWidth = 51;
            this.dtg_userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_userList.Size = new System.Drawing.Size(869, 203);
            this.dtg_userList.TabIndex = 0;
            // 
            // frm_utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(908, 545);
            this.Controls.Add(this.GroupBox11);
            this.Controls.Add(this.GroupBox12);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_utilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer les utilisateur";
            this.Load += new System.EventHandler(this.frm_utilisateur_Load);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_userList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox11;
        internal System.Windows.Forms.Button btn_supprimer;
        internal System.Windows.Forms.ComboBox cbotype;
        internal System.Windows.Forms.Label Label38;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Button btn_modifier;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtuser;
        internal System.Windows.Forms.Button btnenregistrer;
        internal System.Windows.Forms.Label lbl_id;
        internal System.Windows.Forms.GroupBox GroupBox12;
        internal System.Windows.Forms.DataGridView dtg_userList;
    }
}