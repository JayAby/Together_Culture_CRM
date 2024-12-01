namespace TCCRM
{
    partial class CreateNewPlans
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblPolicyTitle = new System.Windows.Forms.Label();
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPolicyTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 646);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtProjectTitle);
            this.panel2.Controls.Add(this.txtProjectDescription);
            this.panel2.Location = new System.Drawing.Point(88, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 383);
            this.panel2.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 46);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(19, 57);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(505, 312);
            this.txtProjectDescription.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Candara", 12F);
            this.btnReturn.Location = new System.Drawing.Point(25, 31);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(89, 62);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblPolicyTitle
            // 
            this.lblPolicyTitle.AutoSize = true;
            this.lblPolicyTitle.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyTitle.Location = new System.Drawing.Point(217, 40);
            this.lblPolicyTitle.Name = "lblPolicyTitle";
            this.lblPolicyTitle.Size = new System.Drawing.Size(277, 37);
            this.lblPolicyTitle.TabIndex = 6;
            this.lblPolicyTitle.Text = "CREATE NEW PLANS";
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(210, 17);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(100, 22);
            this.txtProjectTitle.TabIndex = 1;
            this.txtProjectTitle.Text = "Title";
            // 
            // CreateNewPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateNewPlans";
            this.Size = new System.Drawing.Size(746, 646);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtProjectTitle;
        private System.Windows.Forms.Label lblPolicyTitle;
    }
}
