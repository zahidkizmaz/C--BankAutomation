namespace _14253043P
{
    partial class RegisterClientFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxCName = new System.Windows.Forms.TextBox();
            this.txtbxCSurname = new System.Windows.Forms.TextBox();
            this.txtbxCAdress = new System.Windows.Forms.TextBox();
            this.txtbxCMail = new System.Windows.Forms.TextBox();
            this.btnCRegister = new System.Windows.Forms.Button();
            this.txtbxCPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register New Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client Adress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Client Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Client Mail:";
            // 
            // txtbxCName
            // 
            this.txtbxCName.Location = new System.Drawing.Point(227, 127);
            this.txtbxCName.Name = "txtbxCName";
            this.txtbxCName.Size = new System.Drawing.Size(141, 22);
            this.txtbxCName.TabIndex = 6;
            // 
            // txtbxCSurname
            // 
            this.txtbxCSurname.Location = new System.Drawing.Point(227, 181);
            this.txtbxCSurname.Name = "txtbxCSurname";
            this.txtbxCSurname.Size = new System.Drawing.Size(141, 22);
            this.txtbxCSurname.TabIndex = 7;
            // 
            // txtbxCAdress
            // 
            this.txtbxCAdress.Location = new System.Drawing.Point(227, 235);
            this.txtbxCAdress.Name = "txtbxCAdress";
            this.txtbxCAdress.Size = new System.Drawing.Size(141, 22);
            this.txtbxCAdress.TabIndex = 8;
            // 
            // txtbxCMail
            // 
            this.txtbxCMail.Location = new System.Drawing.Point(227, 333);
            this.txtbxCMail.Name = "txtbxCMail";
            this.txtbxCMail.Size = new System.Drawing.Size(141, 22);
            this.txtbxCMail.TabIndex = 10;
            // 
            // btnCRegister
            // 
            this.btnCRegister.Location = new System.Drawing.Point(130, 398);
            this.btnCRegister.Name = "btnCRegister";
            this.btnCRegister.Size = new System.Drawing.Size(163, 42);
            this.btnCRegister.TabIndex = 11;
            this.btnCRegister.Text = "Register";
            this.btnCRegister.UseVisualStyleBackColor = true;
            this.btnCRegister.Click += new System.EventHandler(this.btnCRegister_Click);
            // 
            // txtbxCPhone
            // 
            this.txtbxCPhone.Location = new System.Drawing.Point(227, 286);
            this.txtbxCPhone.Mask = "00000000000";
            this.txtbxCPhone.Name = "txtbxCPhone";
            this.txtbxCPhone.Size = new System.Drawing.Size(141, 22);
            this.txtbxCPhone.TabIndex = 12;
            // 
            // RegisterClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 528);
            this.Controls.Add(this.txtbxCPhone);
            this.Controls.Add(this.btnCRegister);
            this.Controls.Add(this.txtbxCMail);
            this.Controls.Add(this.txtbxCAdress);
            this.Controls.Add(this.txtbxCSurname);
            this.Controls.Add(this.txtbxCName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterClientFrm";
            this.Text = "Register New Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxCName;
        private System.Windows.Forms.TextBox txtbxCSurname;
        private System.Windows.Forms.TextBox txtbxCAdress;
        private System.Windows.Forms.TextBox txtbxCMail;
        private System.Windows.Forms.Button btnCRegister;
        private System.Windows.Forms.MaskedTextBox txtbxCPhone;
    }
}