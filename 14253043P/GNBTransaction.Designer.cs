namespace _14253043P
{
    partial class GNBTransaction
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
            this.components = new System.ComponentModel.Container();
            this.goliathNationalBankDataSet = new _14253043P.GoliathNationalBankDataSet();
            this.transactionTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTBLTableAdapter = new _14253043P.GoliathNationalBankDataSetTableAdapters.TransactionTBLTableAdapter();
            this.cmbGNBClient = new System.Windows.Forms.ComboBox();
            this.cmbGNBAccount = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetTransactionTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goliathNationalBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // goliathNationalBankDataSet
            // 
            this.goliathNationalBankDataSet.DataSetName = "GoliathNationalBankDataSet";
            this.goliathNationalBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTBLBindingSource
            // 
            this.transactionTBLBindingSource.DataMember = "TransactionTBL";
            this.transactionTBLBindingSource.DataSource = this.goliathNationalBankDataSet;
            // 
            // transactionTBLTableAdapter
            // 
            this.transactionTBLTableAdapter.ClearBeforeFill = true;
            // 
            // cmbGNBClient
            // 
            this.cmbGNBClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGNBClient.DropDownWidth = 300;
            this.cmbGNBClient.FormattingEnabled = true;
            this.cmbGNBClient.Location = new System.Drawing.Point(208, 235);
            this.cmbGNBClient.Name = "cmbGNBClient";
            this.cmbGNBClient.Size = new System.Drawing.Size(242, 24);
            this.cmbGNBClient.TabIndex = 0;
            this.cmbGNBClient.SelectedIndexChanged += new System.EventHandler(this.cmbGNBClient_SelectedIndexChanged);
            // 
            // cmbGNBAccount
            // 
            this.cmbGNBAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGNBAccount.DropDownWidth = 500;
            this.cmbGNBAccount.FormattingEnabled = true;
            this.cmbGNBAccount.Location = new System.Drawing.Point(208, 293);
            this.cmbGNBAccount.Name = "cmbGNBAccount";
            this.cmbGNBAccount.Size = new System.Drawing.Size(242, 24);
            this.cmbGNBAccount.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(208, 180);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Account:";
            // 
            // btnGetTransactionTable
            // 
            this.btnGetTransactionTable.Location = new System.Drawing.Point(333, 351);
            this.btnGetTransactionTable.Name = "btnGetTransactionTable";
            this.btnGetTransactionTable.Size = new System.Drawing.Size(117, 59);
            this.btnGetTransactionTable.TabIndex = 6;
            this.btnGetTransactionTable.Text = "Get Account Statement";
            this.btnGetTransactionTable.UseVisualStyleBackColor = true;
            this.btnGetTransactionTable.Click += new System.EventHandler(this.btnGetTransactionTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Till:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(132, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Account Statement";
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Location = new System.Drawing.Point(193, 351);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(117, 59);
            this.btnDeleteAcc.TabIndex = 10;
            this.btnDeleteAcc.Text = "Delete This Account";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // GNBTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 508);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetTransactionTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbGNBAccount);
            this.Controls.Add(this.cmbGNBClient);
            this.Name = "GNBTransaction";
            this.Text = "GNBTransaction";
            this.Load += new System.EventHandler(this.GNBTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goliathNationalBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GoliathNationalBankDataSet goliathNationalBankDataSet;
        private System.Windows.Forms.BindingSource transactionTBLBindingSource;
        private GoliathNationalBankDataSetTableAdapters.TransactionTBLTableAdapter transactionTBLTableAdapter;
        private System.Windows.Forms.ComboBox cmbGNBClient;
        private System.Windows.Forms.ComboBox cmbGNBAccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetTransactionTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteAcc;
    }
}