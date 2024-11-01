namespace GUI_Testing
{
    partial class Home
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.profileContainer = new System.Windows.Forms.Panel();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEvents = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.connectionContainer = new System.Windows.Forms.Panel();
            this.btnChats = new System.Windows.Forms.Button();
            this.btnConnections = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.connectionsTimer = new System.Windows.Forms.Timer(this.components);
            this.profileTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.profileContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.connectionContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.splitContainer1.Panel1.Controls.Add(this.profileContainer);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.splitContainer1.Panel2.Controls.Add(this.sidebar);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1345, 768);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 2;
            // 
            // profileContainer
            // 
            this.profileContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.profileContainer.Controls.Add(this.btnDocuments);
            this.profileContainer.Controls.Add(this.button4);
            this.profileContainer.Controls.Add(this.button3);
            this.profileContainer.Controls.Add(this.button1);
            this.profileContainer.Controls.Add(this.btnProfile);
            this.profileContainer.Location = new System.Drawing.Point(67, 3);
            this.profileContainer.MaximumSize = new System.Drawing.Size(284, 158);
            this.profileContainer.MinimumSize = new System.Drawing.Size(130, 158);
            this.profileContainer.Name = "profileContainer";
            this.profileContainer.Size = new System.Drawing.Size(284, 158);
            this.profileContainer.TabIndex = 4;
            // 
            // btnDocuments
            // 
            this.btnDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDocuments.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocuments.ForeColor = System.Drawing.Color.White;
            this.btnDocuments.Location = new System.Drawing.Point(129, 122);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(150, 32);
            this.btnDocuments.TabIndex = 8;
            this.btnDocuments.Text = "Documents";
            this.btnDocuments.UseVisualStyleBackColor = false;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(129, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Membership";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(129, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Interests";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(129, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Personal Info";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImage = global::GUI_Testing.Properties.Resources.hacker;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Location = new System.Drawing.Point(0, 8);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(123, 92);
            this.btnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnProfile.TabIndex = 1;
            this.btnProfile.TabStop = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_Testing.Properties.Resources.channels4_profile_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1072, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.connectionContainer);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Location = new System.Drawing.Point(53, 3);
            this.sidebar.MaximumSize = new System.Drawing.Size(228, 601);
            this.sidebar.MinimumSize = new System.Drawing.Size(93, 601);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(228, 601);
            this.sidebar.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuLabel);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 100);
            this.panel2.TabIndex = 8;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(88, 43);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(68, 21);
            this.menuLabel.TabIndex = 12;
            this.menuLabel.Text = "    Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::GUI_Testing.Properties.Resources.list;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Location = new System.Drawing.Point(10, 26);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(72, 47);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 51);
            this.panel3.TabIndex = 9;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::GUI_Testing.Properties.Resources.rome;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(8, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(211, 40);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnEvents);
            this.panel4.Location = new System.Drawing.Point(3, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 51);
            this.panel4.TabIndex = 10;
            // 
            // btnEvents
            // 
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Image = global::GUI_Testing.Properties.Resources.calendar__1_;
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(8, 8);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEvents.Size = new System.Drawing.Size(211, 40);
            this.btnEvents.TabIndex = 8;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.btnLibrary);
            this.panel5.Location = new System.Drawing.Point(3, 223);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 51);
            this.panel5.TabIndex = 11;
            // 
            // btnLibrary
            // 
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.Color.White;
            this.btnLibrary.Image = global::GUI_Testing.Properties.Resources.digitallibrary;
            this.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.Location = new System.Drawing.Point(11, 8);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLibrary.Size = new System.Drawing.Size(208, 40);
            this.btnLibrary.TabIndex = 8;
            this.btnLibrary.Text = "      Digital Library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            // 
            // connectionContainer
            // 
            this.connectionContainer.Controls.Add(this.btnChats);
            this.connectionContainer.Controls.Add(this.btnConnections);
            this.connectionContainer.Controls.Add(this.btnPosts);
            this.connectionContainer.Controls.Add(this.panel9);
            this.connectionContainer.Location = new System.Drawing.Point(3, 280);
            this.connectionContainer.MaximumSize = new System.Drawing.Size(222, 182);
            this.connectionContainer.MinimumSize = new System.Drawing.Size(222, 45);
            this.connectionContainer.Name = "connectionContainer";
            this.connectionContainer.Size = new System.Drawing.Size(222, 45);
            this.connectionContainer.TabIndex = 12;
            // 
            // btnChats
            // 
            this.btnChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChats.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChats.ForeColor = System.Drawing.Color.White;
            this.btnChats.Image = global::GUI_Testing.Properties.Resources.chatting;
            this.btnChats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChats.Location = new System.Drawing.Point(11, 95);
            this.btnChats.Name = "btnChats";
            this.btnChats.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnChats.Size = new System.Drawing.Size(208, 40);
            this.btnChats.TabIndex = 8;
            this.btnChats.Text = "Chats";
            this.btnChats.UseVisualStyleBackColor = true;
            // 
            // btnConnections
            // 
            this.btnConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnections.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnections.ForeColor = System.Drawing.Color.White;
            this.btnConnections.Image = global::GUI_Testing.Properties.Resources.connection;
            this.btnConnections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnections.Location = new System.Drawing.Point(11, 3);
            this.btnConnections.Name = "btnConnections";
            this.btnConnections.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConnections.Size = new System.Drawing.Size(208, 40);
            this.btnConnections.TabIndex = 8;
            this.btnConnections.Text = "      Connections";
            this.btnConnections.UseVisualStyleBackColor = true;
            this.btnConnections.Click += new System.EventHandler(this.btnConnections_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosts.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosts.ForeColor = System.Drawing.Color.White;
            this.btnPosts.Image = global::GUI_Testing.Properties.Resources.post;
            this.btnPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosts.Location = new System.Drawing.Point(11, 49);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPosts.Size = new System.Drawing.Size(208, 40);
            this.btnPosts.TabIndex = 8;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.button2);
            this.panel9.Location = new System.Drawing.Point(3, 595);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(222, 51);
            this.panel9.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::GUI_Testing.Properties.Resources.digitallibrary;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 8);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(208, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "      Digital Library";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnNotifications);
            this.panel7.Location = new System.Drawing.Point(3, 331);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 51);
            this.panel7.TabIndex = 13;
            // 
            // btnNotifications
            // 
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Image = global::GUI_Testing.Properties.Resources.notifcations;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(8, 8);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNotifications.Size = new System.Drawing.Size(211, 40);
            this.btnNotifications.TabIndex = 10;
            this.btnNotifications.Text = "      Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnLogout);
            this.panel8.Location = new System.Drawing.Point(3, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(222, 51);
            this.panel8.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::GUI_Testing.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(8, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(211, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "  Sign Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(-63, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 768);
            this.panel1.TabIndex = 0;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 3;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // connectionsTimer
            // 
            this.connectionsTimer.Interval = 3;
            this.connectionsTimer.Tick += new System.EventHandler(this.connectionsTimer_Tick);
            // 
            // profileTimer
            // 
            this.profileTimer.Interval = 10;
            this.profileTimer.Tick += new System.EventHandler(this.profileTimer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.Text = "TogetherCulture - Home";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.profileContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.connectionContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel connectionContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnConnections;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Button btnChats;
        private System.Windows.Forms.Timer connectionsTimer;
        private System.Windows.Forms.Panel profileContainer;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer profileTimer;
    }
}

