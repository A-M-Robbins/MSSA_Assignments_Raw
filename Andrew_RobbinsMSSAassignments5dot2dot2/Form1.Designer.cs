namespace MSSAassignment5dot2dot
{
    partial class Phonebook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frstNmeLbl = new System.Windows.Forms.Label();
            this.lastNmeLbl = new System.Windows.Forms.Label();
            this.mblPhneLbl = new System.Windows.Forms.Label();
            this.workPhneLbl = new System.Windows.Forms.Label();
            this.addrssLbl = new System.Windows.Forms.Label();
            this.frstNmeTxtBx = new System.Windows.Forms.TextBox();
            this.lastNmeTxtBx = new System.Windows.Forms.TextBox();
            this.mblPhneTxtBx = new System.Windows.Forms.TextBox();
            this.wrkPhneTxtBx = new System.Windows.Forms.TextBox();
            this.addrssTxtBx = new System.Windows.Forms.TextBox();
            this.dsplayBtn = new System.Windows.Forms.Button();
            this.addCntctBtn = new System.Windows.Forms.Button();
            this.delContactBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.contactsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // frstNmeLbl
            // 
            this.frstNmeLbl.AutoSize = true;
            this.frstNmeLbl.Location = new System.Drawing.Point(21, 31);
            this.frstNmeLbl.Name = "frstNmeLbl";
            this.frstNmeLbl.Size = new System.Drawing.Size(97, 25);
            this.frstNmeLbl.TabIndex = 0;
            this.frstNmeLbl.Text = "First Name";
            // 
            // lastNmeLbl
            // 
            this.lastNmeLbl.AutoSize = true;
            this.lastNmeLbl.Location = new System.Drawing.Point(21, 78);
            this.lastNmeLbl.Name = "lastNmeLbl";
            this.lastNmeLbl.Size = new System.Drawing.Size(95, 25);
            this.lastNmeLbl.TabIndex = 0;
            this.lastNmeLbl.Text = "Last Name";
            // 
            // mblPhneLbl
            // 
            this.mblPhneLbl.AutoSize = true;
            this.mblPhneLbl.Location = new System.Drawing.Point(21, 125);
            this.mblPhneLbl.Name = "mblPhneLbl";
            this.mblPhneLbl.Size = new System.Drawing.Size(192, 25);
            this.mblPhneLbl.TabIndex = 0;
            this.mblPhneLbl.Text = "Mobile Phone Number";
            // 
            // workPhneLbl
            // 
            this.workPhneLbl.AutoSize = true;
            this.workPhneLbl.Location = new System.Drawing.Point(21, 172);
            this.workPhneLbl.Name = "workPhneLbl";
            this.workPhneLbl.Size = new System.Drawing.Size(179, 25);
            this.workPhneLbl.TabIndex = 0;
            this.workPhneLbl.Text = "Work Phone Number";
            // 
            // addrssLbl
            // 
            this.addrssLbl.AutoSize = true;
            this.addrssLbl.Location = new System.Drawing.Point(21, 223);
            this.addrssLbl.Name = "addrssLbl";
            this.addrssLbl.Size = new System.Drawing.Size(77, 25);
            this.addrssLbl.TabIndex = 0;
            this.addrssLbl.Text = "Address";
            // 
            // frstNmeTxtBx
            // 
            this.frstNmeTxtBx.Location = new System.Drawing.Point(219, 25);
            this.frstNmeTxtBx.Name = "frstNmeTxtBx";
            this.frstNmeTxtBx.Size = new System.Drawing.Size(591, 31);
            this.frstNmeTxtBx.TabIndex = 1;
            // 
            // lastNmeTxtBx
            // 
            this.lastNmeTxtBx.Location = new System.Drawing.Point(219, 72);
            this.lastNmeTxtBx.Name = "lastNmeTxtBx";
            this.lastNmeTxtBx.Size = new System.Drawing.Size(591, 31);
            this.lastNmeTxtBx.TabIndex = 1;
            // 
            // mblPhneTxtBx
            // 
            this.mblPhneTxtBx.Location = new System.Drawing.Point(219, 119);
            this.mblPhneTxtBx.Name = "mblPhneTxtBx";
            this.mblPhneTxtBx.Size = new System.Drawing.Size(591, 31);
            this.mblPhneTxtBx.TabIndex = 1;
            // 
            // wrkPhneTxtBx
            // 
            this.wrkPhneTxtBx.Location = new System.Drawing.Point(219, 166);
            this.wrkPhneTxtBx.Name = "wrkPhneTxtBx";
            this.wrkPhneTxtBx.Size = new System.Drawing.Size(591, 31);
            this.wrkPhneTxtBx.TabIndex = 1;
            // 
            // addrssTxtBx
            // 
            this.addrssTxtBx.Location = new System.Drawing.Point(219, 217);
            this.addrssTxtBx.Name = "addrssTxtBx";
            this.addrssTxtBx.Size = new System.Drawing.Size(591, 31);
            this.addrssTxtBx.TabIndex = 2;
            // 
            // dsplayBtn
            // 
            this.dsplayBtn.Location = new System.Drawing.Point(828, 121);
            this.dsplayBtn.Name = "dsplayBtn";
            this.dsplayBtn.Size = new System.Drawing.Size(176, 33);
            this.dsplayBtn.TabIndex = 3;
            this.dsplayBtn.Text = "Display All Contacts";
            this.dsplayBtn.UseVisualStyleBackColor = true;
            this.dsplayBtn.Click += new System.EventHandler(this.dsplayBtn_Click);
            // 
            // addCntctBtn
            // 
            this.addCntctBtn.Location = new System.Drawing.Point(828, 23);
            this.addCntctBtn.Name = "addCntctBtn";
            this.addCntctBtn.Size = new System.Drawing.Size(176, 33);
            this.addCntctBtn.TabIndex = 4;
            this.addCntctBtn.Text = "Add Contact";
            this.addCntctBtn.UseVisualStyleBackColor = true;
            this.addCntctBtn.Click += new System.EventHandler(this.addCntctBtn_Click);
            // 
            // delContactBtn
            // 
            this.delContactBtn.Location = new System.Drawing.Point(828, 74);
            this.delContactBtn.Name = "delContactBtn";
            this.delContactBtn.Size = new System.Drawing.Size(176, 33);
            this.delContactBtn.TabIndex = 3;
            this.delContactBtn.Text = "Delete Contact";
            this.delContactBtn.UseVisualStyleBackColor = true;
            this.delContactBtn.Click += new System.EventHandler(this.delContactBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(828, 215);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(176, 33);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // contactsDataGrid
            // 
            this.contactsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGrid.Location = new System.Drawing.Point(21, 312);
            this.contactsDataGrid.Name = "contactsDataGrid";
            this.contactsDataGrid.RowHeadersWidth = 62;
            this.contactsDataGrid.RowTemplate.Height = 33;
            this.contactsDataGrid.Size = new System.Drawing.Size(1067, 321);
            this.contactsDataGrid.TabIndex = 5;
            this.contactsDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsDataGrid_CellContentDoubleClick);
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.contactsDataGrid);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addCntctBtn);
            this.Controls.Add(this.delContactBtn);
            this.Controls.Add(this.dsplayBtn);
            this.Controls.Add(this.addrssTxtBx);
            this.Controls.Add(this.wrkPhneTxtBx);
            this.Controls.Add(this.mblPhneTxtBx);
            this.Controls.Add(this.lastNmeTxtBx);
            this.Controls.Add(this.frstNmeTxtBx);
            this.Controls.Add(this.addrssLbl);
            this.Controls.Add(this.workPhneLbl);
            this.Controls.Add(this.mblPhneLbl);
            this.Controls.Add(this.lastNmeLbl);
            this.Controls.Add(this.frstNmeLbl);
            this.Name = "Phonebook";
            this.Text = "Phone/Addressbook";
            this.Load += new System.EventHandler(this.Phonebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label frstNmeLbl;
        private Label lastNmeLbl;
        private Label mblPhneLbl;
        private Label workPhneLbl;
        private Label addrssLbl;
        private TextBox frstNmeTxtBx;
        private TextBox lastNmeTxtBx;
        private TextBox mblPhneTxtBx;
        private TextBox wrkPhneTxtBx;
        private TextBox addrssTxtBx;
        private Button dsplayBtn;
        private Button addCntctBtn;
        private Button delContactBtn;
        private Button searchBtn;
        private DataGridView contactsDataGrid;
    }
}