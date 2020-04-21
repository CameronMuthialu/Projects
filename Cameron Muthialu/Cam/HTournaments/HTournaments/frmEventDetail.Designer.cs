namespace HTournaments
{
    partial class frmEventDetail
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFinPos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEvntDetOdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEvntDetNo = new System.Windows.Forms.TextBox();
            this.cbxEvntDetStID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEvntDetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEvDetID = new System.Windows.Forms.TextBox();
            this.dgvEventDets = new System.Windows.Forms.DataGridView();
            this.EventDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_EventDetailStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDetailName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDetailNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDetailOdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishingPostion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventDets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(552, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(418, 446);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 51;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFinPos
            // 
            this.txtFinPos.Location = new System.Drawing.Point(157, 404);
            this.txtFinPos.Name = "txtFinPos";
            this.txtFinPos.Size = new System.Drawing.Size(200, 20);
            this.txtFinPos.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "First Timer";
            // 
            // txtFirstTime
            // 
            this.txtFirstTime.Location = new System.Drawing.Point(626, 404);
            this.txtFirstTime.Name = "txtFirstTime";
            this.txtFirstTime.Size = new System.Drawing.Size(200, 20);
            this.txtFirstTime.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Finishing Postion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Event Detail Odd";
            // 
            // txtEvntDetOdd
            // 
            this.txtEvntDetOdd.Location = new System.Drawing.Point(626, 360);
            this.txtEvntDetOdd.Name = "txtEvntDetOdd";
            this.txtEvntDetOdd.Size = new System.Drawing.Size(200, 20);
            this.txtEvntDetOdd.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Event Detail No.";
            // 
            // txtEvntDetNo
            // 
            this.txtEvntDetNo.Location = new System.Drawing.Point(157, 360);
            this.txtEvntDetNo.Name = "txtEvntDetNo";
            this.txtEvntDetNo.Size = new System.Drawing.Size(200, 20);
            this.txtEvntDetNo.TabIndex = 42;
            // 
            // cbxEvntDetStID
            // 
            this.cbxEvntDetStID.FormattingEnabled = true;
            this.cbxEvntDetStID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxEvntDetStID.Location = new System.Drawing.Point(157, 315);
            this.cbxEvntDetStID.Name = "cbxEvntDetStID";
            this.cbxEvntDetStID.Size = new System.Drawing.Size(200, 21);
            this.cbxEvntDetStID.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Event Detail Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Event Detail Status ID";
            // 
            // txtEvntDetName
            // 
            this.txtEvntDetName.Location = new System.Drawing.Point(626, 315);
            this.txtEvntDetName.Name = "txtEvntDetName";
            this.txtEvntDetName.Size = new System.Drawing.Size(200, 20);
            this.txtEvntDetName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Event ID";
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(626, 271);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(200, 20);
            this.txtEventID.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Event Detail ID";
            // 
            // txtEvDetID
            // 
            this.txtEvDetID.Location = new System.Drawing.Point(157, 271);
            this.txtEvDetID.Name = "txtEvDetID";
            this.txtEvDetID.Size = new System.Drawing.Size(200, 20);
            this.txtEvDetID.TabIndex = 34;
            // 
            // dgvEventDets
            // 
            this.dgvEventDets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventDets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventDetailID,
            this.FK_EventID,
            this.FK_EventDetailStatusID,
            this.EventDetailName,
            this.EventDetailNumber,
            this.EventDetailOdd,
            this.FinishingPostion,
            this.FirstTimer});
            this.dgvEventDets.Location = new System.Drawing.Point(18, 18);
            this.dgvEventDets.Name = "dgvEventDets";
            this.dgvEventDets.Size = new System.Drawing.Size(882, 229);
            this.dgvEventDets.TabIndex = 33;
            // 
            // EventDetailID
            // 
            this.EventDetailID.HeaderText = "Event Detail ID";
            this.EventDetailID.Name = "EventDetailID";
            // 
            // FK_EventID
            // 
            this.FK_EventID.HeaderText = "Event ID";
            this.FK_EventID.Name = "FK_EventID";
            // 
            // FK_EventDetailStatusID
            // 
            this.FK_EventDetailStatusID.HeaderText = "Event Detail Status ID";
            this.FK_EventDetailStatusID.Name = "FK_EventDetailStatusID";
            // 
            // EventDetailName
            // 
            this.EventDetailName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventDetailName.HeaderText = "Event Detail Name";
            this.EventDetailName.Name = "EventDetailName";
            // 
            // EventDetailNumber
            // 
            this.EventDetailNumber.HeaderText = "Event Detail Number";
            this.EventDetailNumber.Name = "EventDetailNumber";
            // 
            // EventDetailOdd
            // 
            this.EventDetailOdd.HeaderText = "Event Detail Odd";
            this.EventDetailOdd.Name = "EventDetailOdd";
            // 
            // FinishingPostion
            // 
            this.FinishingPostion.HeaderText = "Finishing Postion";
            this.FinishingPostion.Name = "FinishingPostion";
            // 
            // FirstTimer
            // 
            this.FirstTimer.HeaderText = "First Timer";
            this.FirstTimer.Name = "FirstTimer";
            // 
            // frmEventDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 487);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFinPos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFirstTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEvntDetOdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEvntDetNo);
            this.Controls.Add(this.cbxEvntDetStID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEvntDetName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvDetID);
            this.Controls.Add(this.dgvEventDets);
            this.Name = "frmEventDetail";
            this.Text = "EventDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventDets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFinPos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEvntDetOdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEvntDetNo;
        private System.Windows.Forms.ComboBox cbxEvntDetStID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEvntDetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEvDetID;
        private System.Windows.Forms.DataGridView dgvEventDets;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_EventDetailStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDetailName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDetailNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDetailOdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishingPostion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstTimer;
    }
}