namespace MSSAassignment5._3
{
    partial class Form2
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
            this.stdntIdTxtbx1 = new System.Windows.Forms.TextBox();
            this.stdntNameTxtBx1 = new System.Windows.Forms.TextBox();
            this.gpaStudTxtBx1 = new System.Windows.Forms.TextBox();
            this.studIdLabl = new System.Windows.Forms.Label();
            this.studNmeLabl = new System.Windows.Forms.Label();
            this.gpaLabl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrBtn1 = new System.Windows.Forms.Button();
            this.saveToTxtdoxBtn = new System.Windows.Forms.Button();
            this.deleteBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stdntIdTxtbx1
            // 
            this.stdntIdTxtbx1.Location = new System.Drawing.Point(173, 23);
            this.stdntIdTxtbx1.Name = "stdntIdTxtbx1";
            this.stdntIdTxtbx1.Size = new System.Drawing.Size(303, 26);
            this.stdntIdTxtbx1.TabIndex = 0;
            // 
            // stdntNameTxtBx1
            // 
            this.stdntNameTxtBx1.Location = new System.Drawing.Point(173, 66);
            this.stdntNameTxtBx1.Name = "stdntNameTxtBx1";
            this.stdntNameTxtBx1.Size = new System.Drawing.Size(303, 26);
            this.stdntNameTxtBx1.TabIndex = 0;
            // 
            // gpaStudTxtBx1
            // 
            this.gpaStudTxtBx1.Location = new System.Drawing.Point(173, 111);
            this.gpaStudTxtBx1.Name = "gpaStudTxtBx1";
            this.gpaStudTxtBx1.Size = new System.Drawing.Size(303, 26);
            this.gpaStudTxtBx1.TabIndex = 0;
            // 
            // studIdLabl
            // 
            this.studIdLabl.AutoSize = true;
            this.studIdLabl.Location = new System.Drawing.Point(20, 32);
            this.studIdLabl.Name = "studIdLabl";
            this.studIdLabl.Size = new System.Drawing.Size(87, 20);
            this.studIdLabl.TabIndex = 1;
            this.studIdLabl.Text = "Student ID";
            // 
            // studNmeLabl
            // 
            this.studNmeLabl.AutoSize = true;
            this.studNmeLabl.Location = new System.Drawing.Point(20, 72);
            this.studNmeLabl.Name = "studNmeLabl";
            this.studNmeLabl.Size = new System.Drawing.Size(112, 20);
            this.studNmeLabl.TabIndex = 1;
            this.studNmeLabl.Text = "Student Name";
            // 
            // gpaLabl
            // 
            this.gpaLabl.AutoSize = true;
            this.gpaLabl.Location = new System.Drawing.Point(20, 114);
            this.gpaLabl.Name = "gpaLabl";
            this.gpaLabl.Size = new System.Drawing.Size(43, 20);
            this.gpaLabl.TabIndex = 1;
            this.gpaLabl.Text = "GPA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(24, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(737, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "GPA";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // entrBtn1
            // 
            this.entrBtn1.Location = new System.Drawing.Point(514, 9);
            this.entrBtn1.Name = "entrBtn1";
            this.entrBtn1.Size = new System.Drawing.Size(83, 40);
            this.entrBtn1.TabIndex = 3;
            this.entrBtn1.Text = "Enter";
            this.entrBtn1.UseVisualStyleBackColor = true;
            this.entrBtn1.Click += new System.EventHandler(this.entrBtn1_Click);
            // 
            // saveToTxtdoxBtn
            // 
            this.saveToTxtdoxBtn.Location = new System.Drawing.Point(514, 58);
            this.saveToTxtdoxBtn.Name = "saveToTxtdoxBtn";
            this.saveToTxtdoxBtn.Size = new System.Drawing.Size(83, 40);
            this.saveToTxtdoxBtn.TabIndex = 3;
            this.saveToTxtdoxBtn.Text = "Save";
            this.saveToTxtdoxBtn.UseVisualStyleBackColor = true;
            this.saveToTxtdoxBtn.Click += new System.EventHandler(this.saveToTxtdoxBtn_Click);
            // 
            // deleteBtn1
            // 
            this.deleteBtn1.Location = new System.Drawing.Point(514, 111);
            this.deleteBtn1.Name = "deleteBtn1";
            this.deleteBtn1.Size = new System.Drawing.Size(83, 40);
            this.deleteBtn1.TabIndex = 3;
            this.deleteBtn1.Text = "Delete";
            this.deleteBtn1.UseVisualStyleBackColor = true;
            this.deleteBtn1.Click += new System.EventHandler(this.deleteBtn1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 396);
            this.Controls.Add(this.deleteBtn1);
            this.Controls.Add(this.saveToTxtdoxBtn);
            this.Controls.Add(this.entrBtn1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpaLabl);
            this.Controls.Add(this.studNmeLabl);
            this.Controls.Add(this.studIdLabl);
            this.Controls.Add(this.gpaStudTxtBx1);
            this.Controls.Add(this.stdntNameTxtBx1);
            this.Controls.Add(this.stdntIdTxtbx1);
            this.Name = "Form2";
            this.Text = "Student Database";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stdntIdTxtbx1;
        private System.Windows.Forms.TextBox stdntNameTxtBx1;
        private System.Windows.Forms.TextBox gpaStudTxtBx1;
        private System.Windows.Forms.Label studIdLabl;
        private System.Windows.Forms.Label studNmeLabl;
        private System.Windows.Forms.Label gpaLabl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button entrBtn1;
        private System.Windows.Forms.Button saveToTxtdoxBtn;
        private System.Windows.Forms.Button deleteBtn1;
    }
}