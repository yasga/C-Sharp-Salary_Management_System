namespace gestionSalaries
{
    partial class Form1
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
            this.tsEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsPayroll = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.AdminName = new System.Windows.Forms.ToolStripLabel();
            this.tsContact = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsEmployee
            // 
            this.tsEmployee.AutoSize = false;
            this.tsEmployee.Enabled = false;
            this.tsEmployee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(110, 80);
            this.tsEmployee.Text = "Employées";
            this.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsPayroll
            // 
            this.tsPayroll.AutoSize = false;
            this.tsPayroll.Enabled = false;
            this.tsPayroll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsPayroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPayroll.Name = "tsPayroll";
            this.tsPayroll.Size = new System.Drawing.Size(110, 80);
            this.tsPayroll.Text = "Paiements";
            this.tsPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPayroll.Click += new System.EventHandler(this.tsPayroll_Click);
            // 
            // tsUser
            // 
            this.tsUser.AutoSize = false;
            this.tsUser.Enabled = false;
            this.tsUser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(110, 80);
            this.tsUser.Text = "Utilisateurs";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.AutoSize = false;
            this.tsLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(110, 80);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // AdminName
            // 
            this.AdminName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AdminName.AutoSize = false;
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(108, 15);
            this.AdminName.Text = "Admin";
            this.AdminName.Click += new System.EventHandler(this.AdminName_Click);
            // 
            // tsContact
            // 
            this.tsContact.AutoSize = false;
            this.tsContact.Enabled = false;
            this.tsContact.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsContact.Name = "tsContact";
            this.tsContact.Size = new System.Drawing.Size(110, 80);
            this.tsContact.Text = "Contact";
            this.tsContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsContact.Click += new System.EventHandler(this.tsContact_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmployee,
            this.tsPayroll,
            this.tsUser,
            this.tsContact,
            this.tsLogin,
            this.AdminName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(133, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(160, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(160, 622);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 622);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion des salariés";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsEmployee;
        private System.Windows.Forms.ToolStripButton tsPayroll;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripLabel AdminName;
        private System.Windows.Forms.ToolStripButton tsContact;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

