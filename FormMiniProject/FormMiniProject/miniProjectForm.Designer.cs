namespace FormMiniProject
{
    partial class miniProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miniProjectForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicateSidePanel = new System.Windows.Forms.Panel();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.insertUser1 = new FormMiniProject.InsertUser();
            this.displaySearch1 = new FormMiniProject.DisplaySearch();
            this.sidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.indicateSidePanel);
            this.sidePanel.Controls.Add(this.btnInsertUser);
            this.sidePanel.Controls.Add(this.btnSearchUser);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(188, 556);
            this.sidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 60);
            this.panel1.TabIndex = 4;
            // 
            // indicateSidePanel
            // 
            this.indicateSidePanel.BackColor = System.Drawing.Color.Red;
            this.indicateSidePanel.ForeColor = System.Drawing.Color.Coral;
            this.indicateSidePanel.Location = new System.Drawing.Point(0, 125);
            this.indicateSidePanel.Name = "indicateSidePanel";
            this.indicateSidePanel.Size = new System.Drawing.Size(10, 54);
            this.indicateSidePanel.TabIndex = 2;
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.FlatAppearance.BorderSize = 0;
            this.btnInsertUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertUser.ForeColor = System.Drawing.Color.White;
            this.btnInsertUser.Location = new System.Drawing.Point(0, 200);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(188, 54);
            this.btnInsertUser.TabIndex = 3;
            this.btnInsertUser.Text = "Insert User";
            this.btnInsertUser.UseVisualStyleBackColor = true;
            this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchUser.Image")));
            this.btnSearchUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.Location = new System.Drawing.Point(12, 125);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(176, 54);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(188, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(731, 60);
            this.topPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.insertUser1);
            this.mainPanel.Controls.Add(this.displaySearch1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainPanel.Location = new System.Drawing.Point(188, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(731, 496);
            this.mainPanel.TabIndex = 4;
            // 
            // insertUser1
            // 
            this.insertUser1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.insertUser1.Location = new System.Drawing.Point(0, 0);
            this.insertUser1.Name = "insertUser1";
            this.insertUser1.Size = new System.Drawing.Size(728, 508);
            this.insertUser1.TabIndex = 1;
            // 
            // displaySearch1
            // 
            this.displaySearch1.Location = new System.Drawing.Point(3, 6);
            this.displaySearch1.Name = "displaySearch1";
            this.displaySearch1.Size = new System.Drawing.Size(716, 528);
            this.displaySearch1.TabIndex = 0;
            // 
            // miniProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 556);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "miniProjectForm";
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel indicateSidePanel;
        private System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Button btnInsertUser;
        public System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Panel mainPanel;
        private InsertUser insertUser1;
        private DisplaySearch displaySearch1;
        private System.Windows.Forms.Panel panel1;
    }
}

