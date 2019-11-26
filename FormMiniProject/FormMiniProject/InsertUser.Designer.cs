namespace FormMiniProject
{
    partial class InsertUser
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbNRIC = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbNRICvalidate = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbNamevalidate = new System.Windows.Forms.Label();
            this.lbAddressvalidate = new System.Windows.Forms.Label();
            this.lbEmailvalidate = new System.Windows.Forms.Label();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.datePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.lbAltAddress = new System.Windows.Forms.Label();
            this.lbAltEmail = new System.Windows.Forms.Label();
            this.tbAltAddress = new System.Windows.Forms.TextBox();
            this.tbAltEmail = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.lbPhoneNovalidate = new System.Windows.Forms.Label();
            this.lbAltAddressvalidate = new System.Windows.Forms.Label();
            this.lbAltEmailvalidate = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(51, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name* :";
            // 
            // lbNRIC
            // 
            this.lbNRIC.AutoSize = true;
            this.lbNRIC.Location = new System.Drawing.Point(51, 26);
            this.lbNRIC.Name = "lbNRIC";
            this.lbNRIC.Size = new System.Drawing.Size(43, 13);
            this.lbNRIC.TabIndex = 1;
            this.lbNRIC.Text = "NRIC* :";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(51, 52);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(78, 13);
            this.lbDOB.TabIndex = 2;
            this.lbDOB.Text = "Date Of Birth* :";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(51, 104);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(55, 13);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Address* :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(51, 159);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email* :";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(84, 217);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(148, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(148, 29);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(100, 20);
            this.tbNRIC.TabIndex = 2;
            this.tbNRIC.TextChanged += new System.EventHandler(this.tbNRIC_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(148, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbNRICvalidate
            // 
            this.lbNRICvalidate.AutoSize = true;
            this.lbNRICvalidate.ForeColor = System.Drawing.Color.Red;
            this.lbNRICvalidate.Location = new System.Drawing.Point(342, 26);
            this.lbNRICvalidate.Name = "lbNRICvalidate";
            this.lbNRICvalidate.Size = new System.Drawing.Size(16, 13);
            this.lbNRICvalidate.TabIndex = 12;
            this.lbNRICvalidate.Text = "   ";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(148, 107);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(188, 20);
            this.tbAddress.TabIndex = 5;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(148, 162);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(188, 20);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbNamevalidate
            // 
            this.lbNamevalidate.AutoSize = true;
            this.lbNamevalidate.Location = new System.Drawing.Point(342, 0);
            this.lbNamevalidate.Name = "lbNamevalidate";
            this.lbNamevalidate.Size = new System.Drawing.Size(13, 13);
            this.lbNamevalidate.TabIndex = 15;
            this.lbNamevalidate.Text = "  ";
            // 
            // lbAddressvalidate
            // 
            this.lbAddressvalidate.AutoSize = true;
            this.lbAddressvalidate.Location = new System.Drawing.Point(342, 104);
            this.lbAddressvalidate.Name = "lbAddressvalidate";
            this.lbAddressvalidate.Size = new System.Drawing.Size(13, 13);
            this.lbAddressvalidate.TabIndex = 16;
            this.lbAddressvalidate.Text = "  ";
            // 
            // lbEmailvalidate
            // 
            this.lbEmailvalidate.AutoSize = true;
            this.lbEmailvalidate.Location = new System.Drawing.Point(342, 159);
            this.lbEmailvalidate.Name = "lbEmailvalidate";
            this.lbEmailvalidate.Size = new System.Drawing.Size(13, 13);
            this.lbEmailvalidate.TabIndex = 17;
            this.lbEmailvalidate.Text = "  ";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(439, 107);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(44, 23);
            this.btnAddAddress.TabIndex = 18;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Visible = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Location = new System.Drawing.Point(439, 162);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(44, 23);
            this.btnAddEmail.TabIndex = 19;
            this.btnAddEmail.Text = " Add";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Visible = false;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 5;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableMain.Controls.Add(this.tbName, 2, 0);
            this.tableMain.Controls.Add(this.lbName, 1, 0);
            this.tableMain.Controls.Add(this.lbNRICvalidate, 3, 1);
            this.tableMain.Controls.Add(this.tbNRIC, 2, 1);
            this.tableMain.Controls.Add(this.lbNRIC, 1, 1);
            this.tableMain.Controls.Add(this.btnInsert, 1, 8);
            this.tableMain.Controls.Add(this.btnClear, 2, 8);
            this.tableMain.Controls.Add(this.lbDOB, 1, 2);
            this.tableMain.Controls.Add(this.lbAddress, 1, 4);
            this.tableMain.Controls.Add(this.tbEmail, 2, 6);
            this.tableMain.Controls.Add(this.lbEmail, 1, 6);
            this.tableMain.Controls.Add(this.tbAddress, 2, 4);
            this.tableMain.Controls.Add(this.datePickerDOB, 2, 2);
            this.tableMain.Controls.Add(this.btnAddAddress, 4, 4);
            this.tableMain.Controls.Add(this.btnAddEmail, 4, 6);
            this.tableMain.Controls.Add(this.lbAddressvalidate, 3, 4);
            this.tableMain.Controls.Add(this.lbEmailvalidate, 3, 6);
            this.tableMain.Controls.Add(this.lbNamevalidate, 3, 0);
            this.tableMain.Controls.Add(this.lbPhoneNumber, 1, 3);
            this.tableMain.Controls.Add(this.tbPhoneNum, 2, 3);
            this.tableMain.Controls.Add(this.lbAltAddress, 1, 5);
            this.tableMain.Controls.Add(this.lbAltEmail, 1, 7);
            this.tableMain.Controls.Add(this.tbAltAddress, 2, 5);
            this.tableMain.Controls.Add(this.tbAltEmail, 2, 7);
            this.tableMain.Controls.Add(this.lb, 3, 2);
            this.tableMain.Controls.Add(this.lbPhoneNovalidate, 3, 3);
            this.tableMain.Controls.Add(this.lbAltAddressvalidate, 3, 5);
            this.tableMain.Controls.Add(this.lbAltEmailvalidate, 3, 7);
            this.tableMain.Location = new System.Drawing.Point(21, 37);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 9;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.Size = new System.Drawing.Size(486, 357);
            this.tableMain.TabIndex = 20;
            this.tableMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tableMain_Paint);
            // 
            // datePickerDOB
            // 
            this.datePickerDOB.Location = new System.Drawing.Point(148, 55);
            this.datePickerDOB.Name = "datePickerDOB";
            this.datePickerDOB.Size = new System.Drawing.Size(188, 20);
            this.datePickerDOB.TabIndex = 3;
            this.datePickerDOB.ValueChanged += new System.EventHandler(this.datePickerDOB_ValueChanged_1);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(51, 78);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(68, 13);
            this.lbPhoneNumber.TabIndex = 21;
            this.lbPhoneNumber.Text = "Phone No.* :";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(148, 81);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(188, 20);
            this.tbPhoneNum.TabIndex = 4;
            this.tbPhoneNum.TextChanged += new System.EventHandler(this.tbPhoneNum_TextChanged);
            // 
            // lbAltAddress
            // 
            this.lbAltAddress.AutoSize = true;
            this.lbAltAddress.Location = new System.Drawing.Point(51, 133);
            this.lbAltAddress.Name = "lbAltAddress";
            this.lbAltAddress.Size = new System.Drawing.Size(90, 26);
            this.lbAltAddress.TabIndex = 23;
            this.lbAltAddress.Text = "Alternate Address :";
            // 
            // lbAltEmail
            // 
            this.lbAltEmail.AutoSize = true;
            this.lbAltEmail.Location = new System.Drawing.Point(51, 188);
            this.lbAltEmail.Name = "lbAltEmail";
            this.lbAltEmail.Size = new System.Drawing.Size(77, 13);
            this.lbAltEmail.TabIndex = 24;
            this.lbAltEmail.Text = "Alternate Email";
            // 
            // tbAltAddress
            // 
            this.tbAltAddress.Location = new System.Drawing.Point(148, 136);
            this.tbAltAddress.Name = "tbAltAddress";
            this.tbAltAddress.Size = new System.Drawing.Size(188, 20);
            this.tbAltAddress.TabIndex = 6;
            this.tbAltAddress.TextChanged += new System.EventHandler(this.tbAltAddress_TextChanged);
            // 
            // tbAltEmail
            // 
            this.tbAltEmail.Location = new System.Drawing.Point(148, 191);
            this.tbAltEmail.Name = "tbAltEmail";
            this.tbAltEmail.Size = new System.Drawing.Size(188, 20);
            this.tbAltEmail.TabIndex = 8;
            this.tbAltEmail.TextChanged += new System.EventHandler(this.tbAltEmail_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(342, 52);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 13);
            this.lb.TabIndex = 27;
            // 
            // lbPhoneNovalidate
            // 
            this.lbPhoneNovalidate.AutoSize = true;
            this.lbPhoneNovalidate.Location = new System.Drawing.Point(342, 78);
            this.lbPhoneNovalidate.Name = "lbPhoneNovalidate";
            this.lbPhoneNovalidate.Size = new System.Drawing.Size(13, 13);
            this.lbPhoneNovalidate.TabIndex = 28;
            this.lbPhoneNovalidate.Text = "  ";
            // 
            // lbAltAddressvalidate
            // 
            this.lbAltAddressvalidate.AutoSize = true;
            this.lbAltAddressvalidate.Location = new System.Drawing.Point(342, 133);
            this.lbAltAddressvalidate.Name = "lbAltAddressvalidate";
            this.lbAltAddressvalidate.Size = new System.Drawing.Size(0, 13);
            this.lbAltAddressvalidate.TabIndex = 29;
            // 
            // lbAltEmailvalidate
            // 
            this.lbAltEmailvalidate.AutoSize = true;
            this.lbAltEmailvalidate.Location = new System.Drawing.Point(342, 188);
            this.lbAltEmailvalidate.Name = "lbAltEmailvalidate";
            this.lbAltEmailvalidate.Size = new System.Drawing.Size(16, 13);
            this.lbAltEmailvalidate.TabIndex = 30;
            this.lbAltEmailvalidate.Text = "   ";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // InsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableMain);
            this.Name = "InsertUser";
            this.Size = new System.Drawing.Size(556, 452);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNRIC;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbNRICvalidate;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbNamevalidate;
        private System.Windows.Forms.Label lbAddressvalidate;
        private System.Windows.Forms.Label lbEmailvalidate;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.DateTimePicker datePickerDOB;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label lbAltAddress;
        private System.Windows.Forms.Label lbAltEmail;
        private System.Windows.Forms.TextBox tbAltAddress;
        private System.Windows.Forms.TextBox tbAltEmail;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbPhoneNovalidate;
        private System.Windows.Forms.Label lbAltAddressvalidate;
        private System.Windows.Forms.Label lbAltEmailvalidate;
    }
}
