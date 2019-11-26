namespace FormMiniProject
{
    partial class DisplaySearch
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
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbInputSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(34, 28);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Search";
            // 
            // tbInputSearch
            // 
            this.tbInputSearch.Location = new System.Drawing.Point(81, 21);
            this.tbInputSearch.Name = "tbInputSearch";
            this.tbInputSearch.Size = new System.Drawing.Size(166, 20);
            this.tbInputSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(266, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 257);
            this.dataGridView1.TabIndex = 3;
            
           
         
            // 
            // DisplaySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbInputSearch);
            this.Controls.Add(this.lbSearch);
            this.Name = "DisplaySearch";
            this.Size = new System.Drawing.Size(713, 367);
            this.Load += new System.EventHandler(this.DisplaySearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbInputSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource utilBindingSource;
        private System.Windows.Forms.BindingSource personObjectBindingSource;
        private System.Windows.Forms.BindingSource utilBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
