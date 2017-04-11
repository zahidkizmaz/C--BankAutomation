namespace _14253043P
{
    partial class ClientHomePage
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
            this.btnNClient = new System.Windows.Forms.Button();
            this.btnUClient = new System.Windows.Forms.Button();
            this.txtbxclientUpdateID = new System.Windows.Forms.TextBox();
            this.btnNAccount = new System.Windows.Forms.Button();
            this.btnNWthdraw = new System.Windows.Forms.Button();
            this.btnNTransfer = new System.Windows.Forms.Button();
            this.btnBankTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerGNB = new System.Windows.Forms.DateTimePicker();
            this.btnAccountStatement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNClient
            // 
            this.btnNClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNClient.Location = new System.Drawing.Point(57, 46);
            this.btnNClient.Name = "btnNClient";
            this.btnNClient.Size = new System.Drawing.Size(129, 84);
            this.btnNClient.TabIndex = 0;
            this.btnNClient.Text = "Register New Client";
            this.btnNClient.UseVisualStyleBackColor = true;
            this.btnNClient.Click += new System.EventHandler(this.btnNClient_Click);
            // 
            // btnUClient
            // 
            this.btnUClient.Location = new System.Drawing.Point(57, 286);
            this.btnUClient.Name = "btnUClient";
            this.btnUClient.Size = new System.Drawing.Size(129, 84);
            this.btnUClient.TabIndex = 1;
            this.btnUClient.Text = "Update A Client";
            this.btnUClient.UseVisualStyleBackColor = true;
            this.btnUClient.Click += new System.EventHandler(this.btnUClient_Click);
            // 
            // txtbxclientUpdateID
            // 
            this.txtbxclientUpdateID.Location = new System.Drawing.Point(57, 248);
            this.txtbxclientUpdateID.Name = "txtbxclientUpdateID";
            this.txtbxclientUpdateID.Size = new System.Drawing.Size(129, 22);
            this.txtbxclientUpdateID.TabIndex = 2;
            // 
            // btnNAccount
            // 
            this.btnNAccount.Location = new System.Drawing.Point(335, 46);
            this.btnNAccount.Name = "btnNAccount";
            this.btnNAccount.Size = new System.Drawing.Size(129, 84);
            this.btnNAccount.TabIndex = 3;
            this.btnNAccount.Text = "Create New Account";
            this.btnNAccount.UseVisualStyleBackColor = true;
            this.btnNAccount.Click += new System.EventHandler(this.btnNAccount_Click);
            // 
            // btnNWthdraw
            // 
            this.btnNWthdraw.Location = new System.Drawing.Point(335, 163);
            this.btnNWthdraw.Name = "btnNWthdraw";
            this.btnNWthdraw.Size = new System.Drawing.Size(129, 84);
            this.btnNWthdraw.TabIndex = 4;
            this.btnNWthdraw.Text = "Withdraw or Deposit Money";
            this.btnNWthdraw.UseVisualStyleBackColor = true;
            this.btnNWthdraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNTransfer
            // 
            this.btnNTransfer.Location = new System.Drawing.Point(335, 286);
            this.btnNTransfer.Name = "btnNTransfer";
            this.btnNTransfer.Size = new System.Drawing.Size(129, 84);
            this.btnNTransfer.TabIndex = 5;
            this.btnNTransfer.Text = "Transfer Money";
            this.btnNTransfer.UseVisualStyleBackColor = true;
            this.btnNTransfer.Click += new System.EventHandler(this.btnNTransfer_Click);
            // 
            // btnBankTransaction
            // 
            this.btnBankTransaction.Location = new System.Drawing.Point(637, 89);
            this.btnBankTransaction.Name = "btnBankTransaction";
            this.btnBankTransaction.Size = new System.Drawing.Size(129, 84);
            this.btnBankTransaction.TabIndex = 6;
            this.btnBankTransaction.Text = "Transaction Table of GNB";
            this.btnBankTransaction.UseVisualStyleBackColor = true;
            this.btnBankTransaction.Click += new System.EventHandler(this.btnBankTransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pick Date:";
            // 
            // dateTimePickerGNB
            // 
            this.dateTimePickerGNB.Location = new System.Drawing.Point(637, 46);
            this.dateTimePickerGNB.Name = "dateTimePickerGNB";
            this.dateTimePickerGNB.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerGNB.TabIndex = 7;
            // 
            // btnAccountStatement
            // 
            this.btnAccountStatement.Location = new System.Drawing.Point(637, 286);
            this.btnAccountStatement.Name = "btnAccountStatement";
            this.btnAccountStatement.Size = new System.Drawing.Size(129, 84);
            this.btnAccountStatement.TabIndex = 9;
            this.btnAccountStatement.Text = "Account Statements";
            this.btnAccountStatement.UseVisualStyleBackColor = true;
            this.btnAccountStatement.Click += new System.EventHandler(this.btnAccountStatement_Click);
            // 
            // ClientHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 578);
            this.Controls.Add(this.btnAccountStatement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerGNB);
            this.Controls.Add(this.btnBankTransaction);
            this.Controls.Add(this.btnNTransfer);
            this.Controls.Add(this.btnNWthdraw);
            this.Controls.Add(this.btnNAccount);
            this.Controls.Add(this.txtbxclientUpdateID);
            this.Controls.Add(this.btnUClient);
            this.Controls.Add(this.btnNClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientHomePage";
            this.Text = "ClientHomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientHomePage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNClient;
        private System.Windows.Forms.Button btnUClient;
        private System.Windows.Forms.TextBox txtbxclientUpdateID;
        private System.Windows.Forms.Button btnNAccount;
        private System.Windows.Forms.Button btnNWthdraw;
        private System.Windows.Forms.Button btnNTransfer;
        private System.Windows.Forms.Button btnBankTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerGNB;
        private System.Windows.Forms.Button btnAccountStatement;
    }
}