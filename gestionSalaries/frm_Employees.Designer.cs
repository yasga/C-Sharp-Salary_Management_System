namespace gestionSalaries
{
    partial class frm_Employees
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
            this.btnsupp = new System.Windows.Forms.Button();
            this.Label46 = new System.Windows.Forms.Label();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modif = new System.Windows.Forms.Button();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.btnempnv = new System.Windows.Forms.Button();
            this.btnempenregis = new System.Windows.Forms.Button();
            this.txtbplace = new System.Windows.Forms.RichTextBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.txtemerg = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtpmethod = new System.Windows.Forms.ComboBox();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.txtworkstatus = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtdrate = new System.Windows.Forms.TextBox();
            this.dtpdhired = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.TabPage7.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsupp
            // 
            this.btnsupp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.ForeColor = System.Drawing.Color.White;
            this.btnsupp.Location = new System.Drawing.Point(940, 49);
            this.btnsupp.Margin = new System.Windows.Forms.Padding(4);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(172, 42);
            this.btnsupp.TabIndex = 22;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = false;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location = new System.Drawing.Point(15, 69);
            this.Label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(105, 17);
            this.Label46.TabIndex = 3;
            this.Label46.Text = "Rechercher :";
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.Location = new System.Drawing.Point(4, 98);
            this.dtgemplist.Margin = new System.Windows.Forms.Padding(4);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.RowHeadersWidth = 51;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(1115, 428);
            this.dtgemplist.TabIndex = 0;
            // 
            // TabPage7
            // 
            this.TabPage7.Controls.Add(this.label1);
            this.TabPage7.Controls.Add(this.btn_modif);
            this.TabPage7.Controls.Add(this.btnsupp);
            this.TabPage7.Controls.Add(this.Label46);
            this.TabPage7.Controls.Add(this.txtempsearch);
            this.TabPage7.Controls.Add(this.dtgemplist);
            this.TabPage7.Location = new System.Drawing.Point(4, 25);
            this.TabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage7.Size = new System.Drawing.Size(1121, 610);
            this.TabPage7.TabIndex = 1;
            this.TabPage7.Text = "Liste des employées";
            this.TabPage7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Employées";
            // 
            // btn_modif
            // 
            this.btn_modif.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.ForeColor = System.Drawing.Color.White;
            this.btn_modif.Location = new System.Drawing.Point(760, 49);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(172, 42);
            this.btn_modif.TabIndex = 23;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // txtempsearch
            // 
            this.txtempsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsearch.Location = new System.Drawing.Point(128, 64);
            this.txtempsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(283, 26);
            this.txtempsearch.TabIndex = 2;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // btnempnv
            // 
            this.btnempnv.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnempnv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempnv.Location = new System.Drawing.Point(666, 507);
            this.btnempnv.Margin = new System.Windows.Forms.Padding(4);
            this.btnempnv.Name = "btnempnv";
            this.btnempnv.Size = new System.Drawing.Size(115, 45);
            this.btnempnv.TabIndex = 15;
            this.btnempnv.Text = "Nouveau";
            this.btnempnv.UseVisualStyleBackColor = false;
            this.btnempnv.Click += new System.EventHandler(this.btnempnv_Click);
            // 
            // btnempenregis
            // 
            this.btnempenregis.BackColor = System.Drawing.Color.Lime;
            this.btnempenregis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempenregis.Location = new System.Drawing.Point(419, 507);
            this.btnempenregis.Margin = new System.Windows.Forms.Padding(4);
            this.btnempenregis.Name = "btnempenregis";
            this.btnempenregis.Size = new System.Drawing.Size(119, 45);
            this.btnempenregis.TabIndex = 16;
            this.btnempenregis.Text = "Enregistrer";
            this.btnempenregis.UseVisualStyleBackColor = false;
            this.btnempenregis.Click += new System.EventHandler(this.btnempenregis_Click);
            // 
            // txtbplace
            // 
            this.txtbplace.Location = new System.Drawing.Point(159, 158);
            this.txtbplace.Margin = new System.Windows.Forms.Padding(4);
            this.txtbplace.Name = "txtbplace";
            this.txtbplace.Size = new System.Drawing.Size(220, 66);
            this.txtbplace.TabIndex = 17;
            this.txtbplace.Text = "";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(159, 74);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(220, 66);
            this.txtaddress.TabIndex = 17;
            this.txtaddress.Text = "";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(2, 161);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(148, 17);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "Lieu de naissance :";
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdbirth.Location = new System.Drawing.Point(835, 117);
            this.dtpdbirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(160, 25);
            this.dtpdbirth.TabIndex = 12;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(676, 123);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(151, 17);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "Date de naissance :";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(469, 41);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(236, 25);
            this.txtlname.TabIndex = 0;
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.Color.CadetBlue;
            this.GroupBox9.Controls.Add(this.txtbplace);
            this.GroupBox9.Controls.Add(this.txtaddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtlname);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.txtcontact);
            this.GroupBox9.Controls.Add(this.txtage);
            this.GroupBox9.Controls.Add(this.txtfname);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtmname);
            this.GroupBox9.Controls.Add(this.rdofemale);
            this.GroupBox9.Controls.Add(this.txtemerg);
            this.GroupBox9.Controls.Add(this.rdomale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtstatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox9.Location = new System.Drawing.Point(32, 110);
            this.GroupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox9.Size = new System.Drawing.Size(1055, 233);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Informations personnelles";
            this.GroupBox9.Enter += new System.EventHandler(this.GroupBox9_Enter);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(412, 166);
            this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(46, 17);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "Age :";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(469, 73);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontact.MaxLength = 11;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(236, 25);
            this.txtcontact.TabIndex = 0;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(469, 161);
            this.txtage.Margin = new System.Windows.Forms.Padding(4);
            this.txtage.MaxLength = 2;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(76, 25);
            this.txtage.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(159, 41);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(225, 25);
            this.txtfname.TabIndex = 0;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(406, 123);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(53, 17);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "Sexe :";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(835, 39);
            this.txtmname.Margin = new System.Windows.Forms.Padding(4);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(207, 25);
            this.txtmname.TabIndex = 0;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(541, 121);
            this.rdofemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(86, 21);
            this.rdofemale.TabIndex = 6;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Femelle";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // txtemerg
            // 
            this.txtemerg.Location = new System.Drawing.Point(835, 161);
            this.txtemerg.Margin = new System.Windows.Forms.Padding(4);
            this.txtemerg.MaxLength = 11;
            this.txtemerg.Name = "txtemerg";
            this.txtemerg.Size = new System.Drawing.Size(205, 25);
            this.txtemerg.TabIndex = 0;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(469, 121);
            this.rdomale.Margin = new System.Windows.Forms.Padding(4);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(63, 21);
            this.rdomale.TabIndex = 6;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Mâle";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(396, 78);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(64, 17);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "Mobile :";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(71, 44);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(74, 17);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "Prénom :";
            this.Label26.Click += new System.EventHandler(this.Label26_Click);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(767, 75);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(60, 17);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "Statut :";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Marrié(e)",
            "Célibataire"});
            this.txtstatus.Location = new System.Drawing.Point(835, 72);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(160, 25);
            this.txtstatus.TabIndex = 2;
            this.txtstatus.Text = "Célibataire";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(408, 39);
            this.Label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(50, 17);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "Nom :";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(67, 81);
            this.Label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(78, 17);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "Adresse :";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(622, 166);
            this.Label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(205, 17);
            this.Label30.TabIndex = 1;
            this.Label30.Text = "Numéro en cas d\'urgence :";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(720, 41);
            this.Label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(107, 17);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "Second nom :";
            this.Label31.Click += new System.EventHandler(this.Label31_Click);
            // 
            // txtpmethod
            // 
            this.txtpmethod.FormattingEnabled = true;
            this.txtpmethod.Items.AddRange(new object[] {
            "Hebdomadaire",
            "Mensuel"});
            this.txtpmethod.Location = new System.Drawing.Point(159, 56);
            this.txtpmethod.Margin = new System.Windows.Forms.Padding(4);
            this.txtpmethod.Name = "txtpmethod";
            this.txtpmethod.Size = new System.Drawing.Size(220, 25);
            this.txtpmethod.TabIndex = 0;
            this.txtpmethod.Text = "Mensuel";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(1129, 639);
            this.TabControl2.TabIndex = 2;
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.Color.CadetBlue;
            this.TabPage6.Controls.Add(this.label2);
            this.TabPage6.Controls.Add(this.btnempupdate);
            this.TabPage6.Controls.Add(this.txtcode);
            this.TabPage6.Controls.Add(this.Label20);
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Controls.Add(this.btnempnv);
            this.TabPage6.Controls.Add(this.btnempenregis);
            this.TabPage6.Location = new System.Drawing.Point(4, 25);
            this.TabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage6.Size = new System.Drawing.Size(1121, 610);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Informations";
            this.TabPage6.Click += new System.EventHandler(this.TabPage6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "Informations";
            // 
            // btnempupdate
            // 
            this.btnempupdate.BackColor = System.Drawing.Color.Gold;
            this.btnempupdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempupdate.Location = new System.Drawing.Point(546, 507);
            this.btnempupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(112, 45);
            this.btnempupdate.TabIndex = 21;
            this.btnempupdate.Text = "Modifier";
            this.btnempupdate.UseVisualStyleBackColor = false;
            this.btnempupdate.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(191, 78);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(265, 25);
            this.txtcode.TabIndex = 15;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(38, 81);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(145, 17);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "Attribuer un code :";
            this.Label20.Click += new System.EventHandler(this.Label20_Click);
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.txtworkstatus);
            this.GroupBox10.Controls.Add(this.Label37);
            this.GroupBox10.Controls.Add(this.Label36);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.txtposition);
            this.GroupBox10.Controls.Add(this.txtdrate);
            this.GroupBox10.Controls.Add(this.dtpdhired);
            this.GroupBox10.Controls.Add(this.txtpmethod);
            this.GroupBox10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox10.Location = new System.Drawing.Point(32, 350);
            this.GroupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox10.Size = new System.Drawing.Size(1047, 137);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Informations professionnelles";
            // 
            // txtworkstatus
            // 
            this.txtworkstatus.FormattingEnabled = true;
            this.txtworkstatus.Items.AddRange(new object[] {
            "Active",
            "Résigné(e)",
            "Retraité(e)"});
            this.txtworkstatus.Location = new System.Drawing.Point(469, 56);
            this.txtworkstatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtworkstatus.Name = "txtworkstatus";
            this.txtworkstatus.Size = new System.Drawing.Size(207, 25);
            this.txtworkstatus.TabIndex = 8;
            this.txtworkstatus.Text = "Active";
            this.txtworkstatus.SelectedIndexChanged += new System.EventHandler(this.txtworkstatus_SelectedIndexChanged);
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(28, 27);
            this.Label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(117, 17);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "Tarif par jour  :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(385, 26);
            this.Label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(75, 17);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "Position :";
            this.Label36.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(400, 59);
            this.Label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(60, 17);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "Statut :";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(32, 59);
            this.Label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(113, 17);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "Mode de paie :";
            this.Label34.Click += new System.EventHandler(this.Label34_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(696, 22);
            this.Label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(168, 17);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "Date de recrutement :";
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(469, 23);
            this.txtposition.Margin = new System.Windows.Forms.Padding(4);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(207, 25);
            this.txtposition.TabIndex = 2;
            // 
            // txtdrate
            // 
            this.txtdrate.Location = new System.Drawing.Point(159, 23);
            this.txtdrate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdrate.MaxLength = 3;
            this.txtdrate.Name = "txtdrate";
            this.txtdrate.Size = new System.Drawing.Size(220, 25);
            this.txtdrate.TabIndex = 2;
            // 
            // dtpdhired
            // 
            this.dtpdhired.CustomFormat = "yyyy-MM-dd";
            this.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdhired.Location = new System.Drawing.Point(835, 43);
            this.dtpdhired.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdhired.Name = "dtpdhired";
            this.dtpdhired.Size = new System.Drawing.Size(204, 25);
            this.dtpdhired.TabIndex = 1;
            // 
            // frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 639);
            this.Controls.Add(this.TabControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employées";
            this.Load += new System.EventHandler(this.frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnsupp;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.TabPage TabPage7;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.Button btnempnv;
        internal System.Windows.Forms.Button btnempenregis;
        internal System.Windows.Forms.RichTextBox txtbplace;
        internal System.Windows.Forms.RichTextBox txtaddress;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtcontact;
        internal System.Windows.Forms.TextBox txtage;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtmname;
        internal System.Windows.Forms.RadioButton rdofemale;
        internal System.Windows.Forms.TextBox txtemerg;
        internal System.Windows.Forms.RadioButton rdomale;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.ComboBox txtstatus;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.ComboBox txtpmethod;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Button btnempupdate;
        internal System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.ComboBox txtworkstatus;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox txtposition;
        internal System.Windows.Forms.TextBox txtdrate;
        internal System.Windows.Forms.DateTimePicker dtpdhired;
        internal System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}