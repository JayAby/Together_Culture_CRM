namespace TCCRM
{
    partial class MemberChat
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
            this.txtChatDisplay = new System.Windows.Forms.TextBox();
            this.cmbLoadMember = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtChatDisplay);
            this.panel1.Controls.Add(this.cmbLoadMember);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 578);
            this.panel1.TabIndex = 0;
            // 
            // txtChatDisplay
            // 
            this.txtChatDisplay.Location = new System.Drawing.Point(194, 275);
            this.txtChatDisplay.Multiline = true;
            this.txtChatDisplay.Name = "txtChatDisplay";
            this.txtChatDisplay.Size = new System.Drawing.Size(337, 44);
            this.txtChatDisplay.TabIndex = 4;
            // 
            // cmbLoadMember
            // 
            this.cmbLoadMember.AllowDrop = true;
            this.cmbLoadMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoadMember.FormattingEnabled = true;
            this.cmbLoadMember.Location = new System.Drawing.Point(301, 63);
            this.cmbLoadMember.Name = "cmbLoadMember";
            this.cmbLoadMember.Size = new System.Drawing.Size(196, 24);
            this.cmbLoadMember.TabIndex = 3;
            this.cmbLoadMember.SelectedIndexChanged += new System.EventHandler(this.cmbLoadMember_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::TCCRM.Properties.Resources.right_arrow;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.Location = new System.Drawing.Point(552, 495);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(194, 486);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(337, 44);
            this.txtMessage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TCCRM.Properties.Resources.boy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(88, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // messageTimer
            // 
            this.messageTimer.Interval = 1000;
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // MemberChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MemberChat";
            this.Size = new System.Drawing.Size(858, 578);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbLoadMember;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.TextBox txtChatDisplay;
    }
}
