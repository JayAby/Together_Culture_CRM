namespace TCCRM
{
    partial class ViewProjectPlan
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
            this.dataGridViewProjectPlans = new System.Windows.Forms.DataGridView();
            this.PlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectPlans)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.dataGridViewProjectPlans);
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 608);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewProjectPlans
            // 
            this.dataGridViewProjectPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjectPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanID,
            this.Title,
            this.Description});
            this.dataGridViewProjectPlans.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjectPlans.Name = "dataGridViewProjectPlans";
            this.dataGridViewProjectPlans.ReadOnly = true;
            this.dataGridViewProjectPlans.RowHeadersWidth = 51;
            this.dataGridViewProjectPlans.RowTemplate.Height = 24;
            this.dataGridViewProjectPlans.Size = new System.Drawing.Size(813, 323);
            this.dataGridViewProjectPlans.TabIndex = 4;
            this.dataGridViewProjectPlans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjectPlans_CellClick);
            // 
            // PlanID
            // 
            this.PlanID.HeaderText = "Plan ID";
            this.PlanID.MinimumWidth = 6;
            this.PlanID.Name = "PlanID";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.White;
            this.panelEdit.Controls.Add(this.txtDescription);
            this.panelEdit.Controls.Add(this.txtTitle);
            this.panelEdit.Location = new System.Drawing.Point(3, 329);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(810, 276);
            this.panelEdit.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(201, 58);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(224, 89);
            this.txtDescription.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(253, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 5;
            // 
            // ViewProjectPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ViewProjectPlan";
            this.Size = new System.Drawing.Size(813, 608);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectPlans)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProjectPlans;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
    }
}
