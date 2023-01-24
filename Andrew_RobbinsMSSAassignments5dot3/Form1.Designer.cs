namespace MSSAassignment5._3
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
            this.loginTxtBx1 = new System.Windows.Forms.TextBox();
            this.loginLabl1 = new System.Windows.Forms.Label();
            this.passwrdTxtBx1 = new System.Windows.Forms.TextBox();
            this.passwrdLabl1 = new System.Windows.Forms.Label();
            this.headingLabl1 = new System.Windows.Forms.Label();
            this.entrBtn1 = new System.Windows.Forms.Button();
            this.clrBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTxtBx1
            // 
            this.loginTxtBx1.Location = new System.Drawing.Point(184, 98);
            this.loginTxtBx1.Name = "loginTxtBx1";
            this.loginTxtBx1.Size = new System.Drawing.Size(319, 26);
            this.loginTxtBx1.TabIndex = 0;
            // 
            // loginLabl1
            // 
            this.loginLabl1.AutoSize = true;
            this.loginLabl1.Location = new System.Drawing.Point(67, 98);
            this.loginLabl1.Name = "loginLabl1";
            this.loginLabl1.Size = new System.Drawing.Size(90, 20);
            this.loginLabl1.TabIndex = 1;
            this.loginLabl1.Text = "User Login:";
            this.loginLabl1.Click += new System.EventHandler(this.loginLabl1_Click);
            // 
            // passwrdTxtBx1
            // 
            this.passwrdTxtBx1.Location = new System.Drawing.Point(184, 178);
            this.passwrdTxtBx1.Name = "passwrdTxtBx1";
            this.passwrdTxtBx1.Size = new System.Drawing.Size(319, 26);
            this.passwrdTxtBx1.TabIndex = 0;
            // 
            // passwrdLabl1
            // 
            this.passwrdLabl1.AutoSize = true;
            this.passwrdLabl1.Location = new System.Drawing.Point(58, 178);
            this.passwrdLabl1.Name = "passwrdLabl1";
            this.passwrdLabl1.Size = new System.Drawing.Size(120, 20);
            this.passwrdLabl1.TabIndex = 1;
            this.passwrdLabl1.Text = "User Password:";
            // 
            // headingLabl1
            // 
            this.headingLabl1.AutoSize = true;
            this.headingLabl1.Font = new System.Drawing.Font("Oswald", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabl1.Location = new System.Drawing.Point(194, -8);
            this.headingLabl1.Name = "headingLabl1";
            this.headingLabl1.Size = new System.Drawing.Size(309, 54);
            this.headingLabl1.TabIndex = 1;
            this.headingLabl1.Text = "Learning Management";
            this.headingLabl1.Click += new System.EventHandler(this.loginLabl1_Click);
            // 
            // entrBtn1
            // 
            this.entrBtn1.Location = new System.Drawing.Point(523, 89);
            this.entrBtn1.Name = "entrBtn1";
            this.entrBtn1.Size = new System.Drawing.Size(109, 39);
            this.entrBtn1.TabIndex = 2;
            this.entrBtn1.Text = "Enter";
            this.entrBtn1.UseVisualStyleBackColor = true;
            this.entrBtn1.Click += new System.EventHandler(this.entrBtn1_Click);
            // 
            // clrBtn1
            // 
            this.clrBtn1.Location = new System.Drawing.Point(523, 165);
            this.clrBtn1.Name = "clrBtn1";
            this.clrBtn1.Size = new System.Drawing.Size(109, 39);
            this.clrBtn1.TabIndex = 2;
            this.clrBtn1.Text = "Clear";
            this.clrBtn1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 255);
            this.Controls.Add(this.clrBtn1);
            this.Controls.Add(this.entrBtn1);
            this.Controls.Add(this.passwrdLabl1);
            this.Controls.Add(this.passwrdTxtBx1);
            this.Controls.Add(this.headingLabl1);
            this.Controls.Add(this.loginLabl1);
            this.Controls.Add(this.loginTxtBx1);
            this.Name = "Form1";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxtBx1;
        private System.Windows.Forms.Label loginLabl1;
        private System.Windows.Forms.TextBox passwrdTxtBx1;
        private System.Windows.Forms.Label passwrdLabl1;
        private System.Windows.Forms.Label headingLabl1;
        private System.Windows.Forms.Button entrBtn1;
        private System.Windows.Forms.Button clrBtn1;
    }
}

