namespace _14253043P
{
    partial class WithdrawMoneyFrm
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
            this.cmbClientList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccountList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxWtihdrawMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbClientList
            // 
            this.cmbClientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientList.DropDownWidth = 300;
            this.cmbClientList.FormattingEnabled = true;
            this.cmbClientList.Location = new System.Drawing.Point(226, 109);
            this.cmbClientList.Name = "cmbClientList";
            this.cmbClientList.Size = new System.Drawing.Size(121, 24);
            this.cmbClientList.TabIndex = 0;
            this.cmbClientList.SelectedIndexChanged += new System.EventHandler(this.cmbClientList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select The Account:";
            // 
            // cmbAccountList
            // 
            this.cmbAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountList.DropDownWidth = 520;
            this.cmbAccountList.FormattingEnabled = true;
            this.cmbAccountList.Location = new System.Drawing.Point(226, 162);
            this.cmbAccountList.Name = "cmbAccountList";
            this.cmbAccountList.Size = new System.Drawing.Size(121, 24);
            this.cmbAccountList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Of Money:";
            // 
            // txtbxWtihdrawMoney
            // 
            this.txtbxWtihdrawMoney.Location = new System.Drawing.Point(226, 224);
            this.txtbxWtihdrawMoney.Name = "txtbxWtihdrawMoney";
            this.txtbxWtihdrawMoney.Size = new System.Drawing.Size(121, 22);
            this.txtbxWtihdrawMoney.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Withdraw-Deposit Money";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(221, 300);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(126, 47);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "Withdraw Money";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(69, 300);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(126, 47);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit Money";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // WithdrawMoneyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 453);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxWtihdrawMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAccountList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClientList);
            this.Name = "WithdrawMoneyFrm";
            this.Text = "WithdrawMoneyFrm";
            this.Load += new System.EventHandler(this.WithdrawMoneyFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccountList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxWtihdrawMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
    }
}