namespace TCCRM
{
    partial class MemberDocument
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKeyPolicies = new System.Windows.Forms.Button();
            this.projectContainer = new System.Windows.Forms.Panel();
            this.btnViewPlans = new System.Windows.Forms.Button();
            this.btnNewPlans = new System.Windows.Forms.Button();
            this.btnProjectPlans = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.projectContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKeyPolicies
            // 
            this.btnKeyPolicies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.btnKeyPolicies.Font = new System.Drawing.Font("Candara", 12F);
            this.btnKeyPolicies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.btnKeyPolicies.Location = new System.Drawing.Point(342, 41);
            this.btnKeyPolicies.Name = "btnKeyPolicies";
            this.btnKeyPolicies.Size = new System.Drawing.Size(272, 197);
            this.btnKeyPolicies.TabIndex = 7;
            this.btnKeyPolicies.Text = "Key Policies";
            this.btnKeyPolicies.UseVisualStyleBackColor = false;
            this.btnKeyPolicies.Click += new System.EventHandler(this.btnKeyPolicies_Click);
            // 
            // projectContainer
            // 
            this.projectContainer.Controls.Add(this.btnViewPlans);
            this.projectContainer.Controls.Add(this.btnNewPlans);
            this.projectContainer.Controls.Add(this.btnProjectPlans);
            this.projectContainer.Location = new System.Drawing.Point(246, 271);
            this.projectContainer.MaximumSize = new System.Drawing.Size(679, 316);
            this.projectContainer.MinimumSize = new System.Drawing.Size(401, 316);
            this.projectContainer.Name = "projectContainer";
            this.projectContainer.Size = new System.Drawing.Size(401, 316);
            this.projectContainer.TabIndex = 12;
            // 
            // btnViewPlans
            // 
            this.btnViewPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPlans.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPlans.ForeColor = System.Drawing.Color.White;
            this.btnViewPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPlans.Location = new System.Drawing.Point(415, 184);
            this.btnViewPlans.Name = "btnViewPlans";
            this.btnViewPlans.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnViewPlans.Size = new System.Drawing.Size(211, 40);
            this.btnViewPlans.TabIndex = 11;
            this.btnViewPlans.Text = "View Existing Plans";
            this.btnViewPlans.UseVisualStyleBackColor = true;
            // 
            // btnNewPlans
            // 
            this.btnNewPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlans.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlans.ForeColor = System.Drawing.Color.White;
            this.btnNewPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPlans.Location = new System.Drawing.Point(415, 108);
            this.btnNewPlans.Name = "btnNewPlans";
            this.btnNewPlans.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNewPlans.Size = new System.Drawing.Size(211, 40);
            this.btnNewPlans.TabIndex = 10;
            this.btnNewPlans.Text = "Create New Plans";
            this.btnNewPlans.UseVisualStyleBackColor = true;
            // 
            // btnProjectPlans
            // 
            this.btnProjectPlans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.btnProjectPlans.Font = new System.Drawing.Font("Candara", 12F);
            this.btnProjectPlans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(60)))));
            this.btnProjectPlans.Location = new System.Drawing.Point(95, 64);
            this.btnProjectPlans.Name = "btnProjectPlans";
            this.btnProjectPlans.Size = new System.Drawing.Size(272, 197);
            this.btnProjectPlans.TabIndex = 9;
            this.btnProjectPlans.Text = "Project Plans";
            this.btnProjectPlans.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Candara", 12F);
            this.btnReturn.Location = new System.Drawing.Point(392, 656);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 52);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // MemberDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.projectContainer);
            this.Controls.Add(this.btnKeyPolicies);
            this.Name = "MemberDocument";
            this.Size = new System.Drawing.Size(1031, 745);
            this.projectContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeyPolicies;
        private System.Windows.Forms.Panel projectContainer;
        private System.Windows.Forms.Button btnViewPlans;
        private System.Windows.Forms.Button btnNewPlans;
        private System.Windows.Forms.Button btnProjectPlans;
        private System.Windows.Forms.Button btnReturn;
    }
}
