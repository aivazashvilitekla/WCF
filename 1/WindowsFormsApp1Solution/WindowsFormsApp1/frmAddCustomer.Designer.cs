
namespace WindowsFormsApp1
{
    partial class frmAddCustomer
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
            this.txtbox_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_country = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_phone = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_fname
            // 
            this.txtbox_fname.Location = new System.Drawing.Point(121, 20);
            this.txtbox_fname.Name = "txtbox_fname";
            this.txtbox_fname.Size = new System.Drawing.Size(100, 22);
            this.txtbox_fname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lastname";
            // 
            // txtbox_lname
            // 
            this.txtbox_lname.Location = new System.Drawing.Point(121, 61);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.Size = new System.Drawing.Size(100, 22);
            this.txtbox_lname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // txtbox_city
            // 
            this.txtbox_city.Location = new System.Drawing.Point(121, 103);
            this.txtbox_city.Name = "txtbox_city";
            this.txtbox_city.Size = new System.Drawing.Size(100, 22);
            this.txtbox_city.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            // 
            // txtbox_country
            // 
            this.txtbox_country.Location = new System.Drawing.Point(121, 146);
            this.txtbox_country.Name = "txtbox_country";
            this.txtbox_country.Size = new System.Drawing.Size(100, 22);
            this.txtbox_country.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // txtbox_phone
            // 
            this.txtbox_phone.Location = new System.Drawing.Point(121, 194);
            this.txtbox_phone.Name = "txtbox_phone";
            this.txtbox_phone.Size = new System.Drawing.Size(100, 22);
            this.txtbox_phone.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(85, 245);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 289);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_fname);
            this.Name = "frmAddCustomer";
            this.Text = "frmAddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_country;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_phone;
        private System.Windows.Forms.Button btn_add;
    }
}