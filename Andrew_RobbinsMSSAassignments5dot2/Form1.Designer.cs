namespace MSSAassignment5dot2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstNameC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkC4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressC5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.sveToExcellBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.fNameTxtbx = new System.Windows.Forms.TextBox();
            this.lasNameTxtbx = new System.Windows.Forms.TextBox();
            this.adrssTxtbx = new System.Windows.Forms.TextBox();
            this.mPhneTxtbx = new System.Windows.Forms.TextBox();
            this.wPhneTxtbx = new System.Windows.Forms.TextBox();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.searchTxtbx = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.mPhneLbl = new System.Windows.Forms.Label();
            this.wPhneLbl = new System.Windows.Forms.Label();
            this.addrssLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameC1,
            this.LastNameC2,
            this.MobileC3,
            this.WorkC4,
            this.AddressC5});
            this.dataGridView1.Location = new System.Drawing.Point(16, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(962, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // FirstNameC1
            // 
            this.FirstNameC1.HeaderText = "First Name";
            this.FirstNameC1.MinimumWidth = 8;
            this.FirstNameC1.Name = "FirstNameC1";
            // 
            // LastNameC2
            // 
            this.LastNameC2.HeaderText = "Last Name";
            this.LastNameC2.MinimumWidth = 8;
            this.LastNameC2.Name = "LastNameC2";
            // 
            // MobileC3
            // 
            this.MobileC3.HeaderText = "Mobile Phone";
            this.MobileC3.MinimumWidth = 8;
            this.MobileC3.Name = "MobileC3";
            // 
            // WorkC4
            // 
            this.WorkC4.HeaderText = "Work Phone";
            this.WorkC4.MinimumWidth = 8;
            this.WorkC4.Name = "WorkC4";
            // 
            // AddressC5
            // 
            this.AddressC5.HeaderText = "Address";
            this.AddressC5.MinimumWidth = 8;
            this.AddressC5.Name = "AddressC5";
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Location = new System.Drawing.Point(832, 21);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(146, 46);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Contact";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Remove
            // 
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remove.Location = new System.Drawing.Point(832, 152);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(146, 44);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            this.Remove.MouseHover += new System.EventHandler(this.Remove_MouseHover);
            // 
            // sveToExcellBtn
            // 
            this.sveToExcellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sveToExcellBtn.Location = new System.Drawing.Point(832, 86);
            this.sveToExcellBtn.Name = "sveToExcellBtn";
            this.sveToExcellBtn.Size = new System.Drawing.Size(146, 43);
            this.sveToExcellBtn.TabIndex = 1;
            this.sveToExcellBtn.Text = "Save";
            this.sveToExcellBtn.UseVisualStyleBackColor = true;
            this.sveToExcellBtn.Click += new System.EventHandler(this.sveToExcellBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(832, 212);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(146, 44);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // fNameTxtbx
            // 
            this.fNameTxtbx.Location = new System.Drawing.Point(221, 9);
            this.fNameTxtbx.Name = "fNameTxtbx";
            this.fNameTxtbx.Size = new System.Drawing.Size(418, 26);
            this.fNameTxtbx.TabIndex = 1;
            // 
            // lasNameTxtbx
            // 
            this.lasNameTxtbx.Location = new System.Drawing.Point(221, 47);
            this.lasNameTxtbx.Name = "lasNameTxtbx";
            this.lasNameTxtbx.Size = new System.Drawing.Size(418, 26);
            this.lasNameTxtbx.TabIndex = 2;
            // 
            // adrssTxtbx
            // 
            this.adrssTxtbx.Location = new System.Drawing.Point(221, 170);
            this.adrssTxtbx.Name = "adrssTxtbx";
            this.adrssTxtbx.Size = new System.Drawing.Size(418, 26);
            this.adrssTxtbx.TabIndex = 5;
            // 
            // mPhneTxtbx
            // 
            this.mPhneTxtbx.Location = new System.Drawing.Point(221, 86);
            this.mPhneTxtbx.Name = "mPhneTxtbx";
            this.mPhneTxtbx.Size = new System.Drawing.Size(418, 26);
            this.mPhneTxtbx.TabIndex = 3;
            // 
            // wPhneTxtbx
            // 
            this.wPhneTxtbx.Location = new System.Drawing.Point(221, 129);
            this.wPhneTxtbx.Name = "wPhneTxtbx";
            this.wPhneTxtbx.Size = new System.Drawing.Size(418, 26);
            this.wPhneTxtbx.TabIndex = 4;
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Location = new System.Drawing.Point(12, 9);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(82, 20);
            this.fNameLbl.TabIndex = 3;
            this.fNameLbl.Text = "FirstName";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Location = new System.Drawing.Point(12, 47);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(82, 20);
            this.lNameLbl.TabIndex = 3;
            this.lNameLbl.Text = "LastName";
            // 
            // searchTxtbx
            // 
            this.searchTxtbx.Location = new System.Drawing.Point(221, 212);
            this.searchTxtbx.Name = "searchTxtbx";
            this.searchTxtbx.Size = new System.Drawing.Size(418, 26);
            this.searchTxtbx.TabIndex = 6;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(12, 212);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(60, 20);
            this.searchLbl.TabIndex = 3;
            this.searchLbl.Text = "Search";
            // 
            // mPhneLbl
            // 
            this.mPhneLbl.AutoSize = true;
            this.mPhneLbl.Location = new System.Drawing.Point(12, 86);
            this.mPhneLbl.Name = "mPhneLbl";
            this.mPhneLbl.Size = new System.Drawing.Size(165, 20);
            this.mPhneLbl.TabIndex = 3;
            this.mPhneLbl.Text = "Mobile Phone Number";
            // 
            // wPhneLbl
            // 
            this.wPhneLbl.AutoSize = true;
            this.wPhneLbl.Location = new System.Drawing.Point(12, 129);
            this.wPhneLbl.Name = "wPhneLbl";
            this.wPhneLbl.Size = new System.Drawing.Size(156, 20);
            this.wPhneLbl.TabIndex = 3;
            this.wPhneLbl.Text = "Work Phone Number";
            // 
            // addrssLbl
            // 
            this.addrssLbl.AutoSize = true;
            this.addrssLbl.Location = new System.Drawing.Point(12, 170);
            this.addrssLbl.Name = "addrssLbl";
            this.addrssLbl.Size = new System.Drawing.Size(68, 20);
            this.addrssLbl.TabIndex = 3;
            this.addrssLbl.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 646);
            this.Controls.Add(this.addrssLbl);
            this.Controls.Add(this.wPhneLbl);
            this.Controls.Add(this.mPhneLbl);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.lNameLbl);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.wPhneTxtbx);
            this.Controls.Add(this.searchTxtbx);
            this.Controls.Add(this.mPhneTxtbx);
            this.Controls.Add(this.adrssTxtbx);
            this.Controls.Add(this.lasNameTxtbx);
            this.Controls.Add(this.fNameTxtbx);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.sveToExcellBtn);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PhoneBook-To-Excell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button sveToExcellBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox fNameTxtbx;
        private System.Windows.Forms.TextBox lasNameTxtbx;
        private System.Windows.Forms.TextBox adrssTxtbx;
        private System.Windows.Forms.TextBox mPhneTxtbx;
        private System.Windows.Forms.TextBox wPhneTxtbx;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.TextBox searchTxtbx;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label mPhneLbl;
        private System.Windows.Forms.Label wPhneLbl;
        private System.Windows.Forms.Label addrssLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkC4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressC5;
    }
}

