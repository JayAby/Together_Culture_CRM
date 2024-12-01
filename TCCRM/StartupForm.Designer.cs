namespace TCCRM
{
    partial class StartupForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.adminContainer = new System.Windows.Forms.Panel();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.memberContainer = new System.Windows.Forms.Panel();
            this.btnMemberLogin = new System.Windows.Forms.Button();
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.lblMemberPassword = new System.Windows.Forms.Label();
            this.txtMemberUsername = new System.Windows.Forms.TextBox();
            this.lblMemberUsername = new System.Windows.Forms.Label();
            this.adminTimer = new System.Windows.Forms.Timer(this.components);
            this.memberTimer = new System.Windows.Forms.Timer(this.components);
            this.adminContainer.SuspendLayout();
            this.memberContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(240, 23);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(141, 73);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(240, 27);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(141, 73);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Members";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // adminContainer
            // 
            this.adminContainer.Controls.Add(this.btnAdminLogin);
            this.adminContainer.Controls.Add(this.txtAdminPassword);
            this.adminContainer.Controls.Add(this.lblPassword);
            this.adminContainer.Controls.Add(this.txtAdminUsername);
            this.adminContainer.Controls.Add(this.lblAdmin);
            this.adminContainer.Controls.Add(this.btnAdmin);
            this.adminContainer.Location = new System.Drawing.Point(129, 12);
            this.adminContainer.MaximumSize = new System.Drawing.Size(600, 276);
            this.adminContainer.MinimumSize = new System.Drawing.Size(600, 103);
            this.adminContainer.Name = "adminContainer";
            this.adminContainer.Size = new System.Drawing.Size(600, 103);
            this.adminContainer.TabIndex = 2;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(252, 220);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(271, 181);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(100, 22);
            this.txtAdminPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(178, 184);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(271, 123);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(100, 22);
            this.txtAdminUsername.TabIndex = 2;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(178, 126);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(73, 16);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Username:";
            // 
            // memberContainer
            // 
            this.memberContainer.Controls.Add(this.btnMemberLogin);
            this.memberContainer.Controls.Add(this.txtMemberPassword);
            this.memberContainer.Controls.Add(this.lblMemberPassword);
            this.memberContainer.Controls.Add(this.btnMember);
            this.memberContainer.Controls.Add(this.txtMemberUsername);
            this.memberContainer.Controls.Add(this.lblMemberUsername);
            this.memberContainer.Location = new System.Drawing.Point(129, 323);
            this.memberContainer.MaximumSize = new System.Drawing.Size(600, 276);
            this.memberContainer.MinimumSize = new System.Drawing.Size(600, 103);
            this.memberContainer.Name = "memberContainer";
            this.memberContainer.Size = new System.Drawing.Size(600, 276);
            this.memberContainer.TabIndex = 5;
            // 
            // btnMemberLogin
            // 
            this.btnMemberLogin.Location = new System.Drawing.Point(252, 229);
            this.btnMemberLogin.Name = "btnMemberLogin";
            this.btnMemberLogin.Size = new System.Drawing.Size(75, 23);
            this.btnMemberLogin.TabIndex = 6;
            this.btnMemberLogin.Text = "Login";
            this.btnMemberLogin.UseVisualStyleBackColor = true;
            this.btnMemberLogin.Click += new System.EventHandler(this.btnMemberLogin_Click);
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.Location = new System.Drawing.Point(271, 188);
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.Size = new System.Drawing.Size(100, 22);
            this.txtMemberPassword.TabIndex = 4;
            // 
            // lblMemberPassword
            // 
            this.lblMemberPassword.AutoSize = true;
            this.lblMemberPassword.Location = new System.Drawing.Point(178, 188);
            this.lblMemberPassword.Name = "lblMemberPassword";
            this.lblMemberPassword.Size = new System.Drawing.Size(70, 16);
            this.lblMemberPassword.TabIndex = 3;
            this.lblMemberPassword.Text = "Password:";
            // 
            // txtMemberUsername
            // 
            this.txtMemberUsername.Location = new System.Drawing.Point(271, 126);
            this.txtMemberUsername.Name = "txtMemberUsername";
            this.txtMemberUsername.Size = new System.Drawing.Size(100, 22);
            this.txtMemberUsername.TabIndex = 2;
            // 
            // lblMemberUsername
            // 
            this.lblMemberUsername.AutoSize = true;
            this.lblMemberUsername.Location = new System.Drawing.Point(178, 126);
            this.lblMemberUsername.Name = "lblMemberUsername";
            this.lblMemberUsername.Size = new System.Drawing.Size(73, 16);
            this.lblMemberUsername.TabIndex = 1;
            this.lblMemberUsername.Text = "Username:";
            // 
            // adminTimer
            // 
            this.adminTimer.Interval = 5;
            this.adminTimer.Tick += new System.EventHandler(this.AdminTimer_Tick);
            // 
            // memberTimer
            // 
            this.memberTimer.Interval = 5;
            this.memberTimer.Tick += new System.EventHandler(this.memberTimer_Tick);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 658);
            this.Controls.Add(this.memberContainer);
            this.Controls.Add(this.adminContainer);
            this.Name = "StartupForm";
            this.Text = "StartupForm";
            this.adminContainer.ResumeLayout(false);
            this.adminContainer.PerformLayout();
            this.memberContainer.ResumeLayout(false);
            this.memberContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Panel adminContainer;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Panel memberContainer;
        private System.Windows.Forms.Button btnMemberLogin;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.Label lblMemberPassword;
        private System.Windows.Forms.TextBox txtMemberUsername;
        private System.Windows.Forms.Label lblMemberUsername;
        private System.Windows.Forms.Timer adminTimer;
        private System.Windows.Forms.Timer memberTimer;
    }
}