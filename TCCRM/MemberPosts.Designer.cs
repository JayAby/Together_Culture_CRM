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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMakePost = new System.Windows.Forms.Button();
            this.txtPosts = new System.Windows.Forms.TextBox();
            this.updatePostsTimer = new System.Windows.Forms.Timer(this.components);
            this.postTemplate = new System.Windows.Forms.Panel();
            this.lblUsernameTemplate = new System.Windows.Forms.Label();
            this.lblDateTemplate = new System.Windows.Forms.Label();
            this.txtContentTemplate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPosts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.postTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.flowLayoutPosts);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 578);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPosts
            // 
            this.flowLayoutPosts.AutoScroll = true;
            this.flowLayoutPosts.Controls.Add(this.postTemplate);
            this.flowLayoutPosts.Location = new System.Drawing.Point(93, 254);
            this.flowLayoutPosts.Name = "flowLayoutPosts";
            this.flowLayoutPosts.Size = new System.Drawing.Size(737, 299);
            this.flowLayoutPosts.TabIndex = 3;
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
            this.btnMakePost.Click += new System.EventHandler(this.btnMakePost_Click);
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
            // updatePostsTimer
            // 
            this.updatePostsTimer.Interval = 5000;
            this.updatePostsTimer.Tick += new System.EventHandler(this.updatePostsTimer_Tick);
            // 
            // postTemplate
            // 
            this.postTemplate.BackColor = System.Drawing.Color.White;
            this.postTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postTemplate.Controls.Add(this.txtContentTemplate);
            this.postTemplate.Controls.Add(this.lblDateTemplate);
            this.postTemplate.Controls.Add(this.lblUsernameTemplate);
            this.postTemplate.Location = new System.Drawing.Point(3, 3);
            this.postTemplate.Name = "postTemplate";
            this.postTemplate.Size = new System.Drawing.Size(734, 280);
            this.postTemplate.TabIndex = 0;
            this.postTemplate.Visible = false;
            // 
            // lblUsernameTemplate
            // 
            this.lblUsernameTemplate.AutoSize = true;
            this.lblUsernameTemplate.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTemplate.Location = new System.Drawing.Point(40, 34);
            this.lblUsernameTemplate.Name = "lblUsernameTemplate";
            this.lblUsernameTemplate.Size = new System.Drawing.Size(88, 24);
            this.lblUsernameTemplate.TabIndex = 0;
            this.lblUsernameTemplate.Text = "Username";
            // 
            // lblDateTemplate
            // 
            this.lblDateTemplate.AutoSize = true;
            this.lblDateTemplate.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTemplate.Location = new System.Drawing.Point(149, 34);
            this.lblDateTemplate.Name = "lblDateTemplate";
            this.lblDateTemplate.Size = new System.Drawing.Size(49, 24);
            this.lblDateTemplate.TabIndex = 1;
            this.lblDateTemplate.Text = "Date";
            // 
            // txtContentTemplate
            // 
            this.txtContentTemplate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContentTemplate.Location = new System.Drawing.Point(43, 98);
            this.txtContentTemplate.Multiline = true;
            this.txtContentTemplate.Name = "txtContentTemplate";
            this.txtContentTemplate.ReadOnly = true;
            this.txtContentTemplate.Size = new System.Drawing.Size(405, 130);
            this.txtContentTemplate.TabIndex = 2;
            // 
            // MemberPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MemberPosts";
            this.Size = new System.Drawing.Size(891, 578);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPosts.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.postTemplate.ResumeLayout(false);
            this.postTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtPosts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMakePost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPosts;
        private System.Windows.Forms.Timer updatePostsTimer;
        private System.Windows.Forms.Panel postTemplate;
        private System.Windows.Forms.TextBox txtContentTemplate;
        private System.Windows.Forms.Label lblDateTemplate;
        private System.Windows.Forms.Label lblUsernameTemplate;
    }
}
