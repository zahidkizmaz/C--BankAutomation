namespace _14253043P
{
    partial class TransferMoneyFrm
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxTransferMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccountsT1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientsT1 = new System.Windows.Forms.ComboBox();
            this.cmbAccountsT2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClientsT2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(306, 350);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(126, 47);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(263, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Transfer Money";
            // 
            // txtbxTransferMoney
            // 
            this.txtbxTransferMoney.Location = new System.Drawing.Point(366, 247);
            this.txtbxTransferMoney.Name = "txtbxTransferMoney";
            this.txtbxTransferMoney.Size = new System.Drawing.Size(121, 22);
            this.txtbxTransferMoney.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount Of Money:";
            // 
            // cmbAccountsT1
            // 
            this.cmbAccountsT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountsT1.DropDownWidth = 520;
            this.cmbAccountsT1.FormattingEnabled = true;
            this.cmbAccountsT1.Location = new System.Drawing.Point(204, 173);
            this.cmbAccountsT1.Name = "cmbAccountsT1";
            this.cmbAccountsT1.Size = new System.Drawing.Size(121, 24);
            this.cmbAccountsT1.TabIndex = 12;
            this.cmbAccountsT1.SelectedIndexChanged += new System.EventHandler(this.cmbAccountsT1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select The Account:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select The Client:";
            // 
            // cmbClientsT1
            // 
            this.cmbClientsT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientsT1.DropDownWidth = 300;
            this.cmbClientsT1.FormattingEnabled = true;
            this.cmbClientsT1.Location = new System.Drawing.Point(204, 120);
            this.cmbClientsT1.Name = "cmbClientsT1";
            this.cmbClientsT1.Size = new System.Drawing.Size(121, 24);
            this.cmbClientsT1.TabIndex = 9;
            this.cmbClientsT1.SelectedIndexChanged += new System.EventHandler(this.cmbClientsT1_SelectedIndexChanged);
            // 
            // cmbAccountsT2
            // 
            this.cmbAccountsT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountsT2.DropDownWidth = 520;
            this.cmbAccountsT2.FormattingEnabled = true;
            this.cmbAccountsT2.Location = new System.Drawing.Point(553, 173);
            this.cmbAccountsT2.Name = "cmbAccountsT2";
            this.cmbAccountsT2.Size = new System.Drawing.Size(121, 24);
            this.cmbAccountsT2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select The Account:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select The Client:";
            // 
            // cmbClientsT2
            // 
            this.cmbClientsT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientsT2.DropDownWidth = 300;
            this.cmbClientsT2.FormattingEnabled = true;
            this.cmbClientsT2.Location = new System.Drawing.Point(553, 120);
            this.cmbClientsT2.Name = "cmbClientsT2";
            this.cmbClientsT2.Size = new System.Drawing.Size(121, 24);
            this.cmbClientsT2.TabIndex = 17;
            this.cmbClientsT2.SelectedIndexChanged += new System.EventHandler(this.cmbClientsT2_SelectedIndexChanged);
            // 
            // TransferMoneyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 439);
            this.Controls.Add(this.cmbAccountsT2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbClientsT2);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxTransferMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAccountsT1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClientsT1);
            this.Name = "TransferMoneyFrm";
            this.Text = "TransferMoneyFrm";
            this.Load += new System.EventHandler(this.TransferMoneyFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxTransferMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccountsT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientsT1;
        private System.Windows.Forms.ComboBox cmbAccountsT2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClientsT2;
    }
}