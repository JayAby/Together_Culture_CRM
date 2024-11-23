namespace TCCRM
{
    partial class MemberPosts
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMakePost = new System.Windows.Forms.Button();
            this.txtPosts = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 578);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(76, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 305);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMakePost);
            this.panel2.Controls.Add(this.txtPosts);
            this.panel2.Location = new System.Drawing.Point(228, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 203);
            this.panel2.TabIndex = 1;
            // 
            // btnMakePost
            // 
            this.btnMakePost.BackgroundImage = global::TCCRM.Properties.Resources.right_arrow;
            this.btnMakePost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMakePost.Location = new System.Drawing.Point(271, 173);
            this.btnMakePost.Name = "btnMakePost";
            this.btnMakePost.Size = new System.Drawing.Size(95, 27);
            this.btnMakePost.TabIndex = 2;
            this.btnMakePost.UseVisualStyleBackColor = true;
            // 
            // txtPosts
            // 
            this.txtPosts.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosts.Location = new System.Drawing.Point(3, 13);
            this.txtPosts.Multiline = true;
            this.txtPosts.Name = "txtPosts";
            this.txtPosts.Size = new System.Drawing.Size(363, 140);
            this.txtPosts.TabIndex = 0;
            this.txtPosts.Text = "Make a Post...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 217);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 217);
            this.textBox2.TabIndex = 1;
            // 
            // MemberPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MemberPosts";
            this.Size = new System.Drawing.Size(891, 578);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtPosts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMakePost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
