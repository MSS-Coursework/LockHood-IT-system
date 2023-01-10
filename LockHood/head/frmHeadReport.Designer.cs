namespace LockHood
{
    partial class frmHeadReport
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
            this.rptViewerHead = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubAll = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.cmbSubTask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaskAll = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEmployeeAll = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptViewerHead
            // 
            this.rptViewerHead.Location = new System.Drawing.Point(435, 60);
            this.rptViewerHead.Name = "rptViewerHead";
            this.rptViewerHead.ServerReport.BearerToken = null;
            this.rptViewerHead.Size = new System.Drawing.Size(600, 518);
            this.rptViewerHead.TabIndex = 77;
            this.rptViewerHead.ZoomPercent = 75;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnSubAll);
            this.panel3.Controls.Add(this.btnSub);
            this.panel3.Controls.Add(this.cmbSubTask);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(59, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 96);
            this.panel3.TabIndex = 76;
            // 
            // btnSubAll
            // 
            this.btnSubAll.BackColor = System.Drawing.Color.White;
            this.btnSubAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAll.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSubAll.Location = new System.Drawing.Point(275, 30);
            this.btnSubAll.Name = "btnSubAll";
            this.btnSubAll.Size = new System.Drawing.Size(42, 35);
            this.btnSubAll.TabIndex = 68;
            this.btnSubAll.Text = "ALL";
            this.btnSubAll.UseVisualStyleBackColor = false;
            this.btnSubAll.Click += new System.EventHandler(this.btnSubAll_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(193, 30);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(76, 35);
            this.btnSub.TabIndex = 69;
            this.btnSub.Text = "GENERATE";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // cmbSubTask
            // 
            this.cmbSubTask.FormattingEnabled = true;
            this.cmbSubTask.Location = new System.Drawing.Point(24, 55);
            this.cmbSubTask.Name = "cmbSubTask";
            this.cmbSubTask.Size = new System.Drawing.Size(140, 21);
            this.cmbSubTask.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sub-Task Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnTaskAll);
            this.panel2.Controls.Add(this.btnTask);
            this.panel2.Controls.Add(this.cmbTask);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(59, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 96);
            this.panel2.TabIndex = 74;
            // 
            // btnTaskAll
            // 
            this.btnTaskAll.BackColor = System.Drawing.Color.White;
            this.btnTaskAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskAll.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnTaskAll.Location = new System.Drawing.Point(275, 30);
            this.btnTaskAll.Name = "btnTaskAll";
            this.btnTaskAll.Size = new System.Drawing.Size(42, 35);
            this.btnTaskAll.TabIndex = 68;
            this.btnTaskAll.Text = "ALL";
            this.btnTaskAll.UseVisualStyleBackColor = false;
            this.btnTaskAll.Click += new System.EventHandler(this.btnTaskAll_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.ForeColor = System.Drawing.Color.White;
            this.btnTask.Location = new System.Drawing.Point(193, 30);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(76, 35);
            this.btnTask.TabIndex = 69;
            this.btnTask.Text = "GENERATE";
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // cmbTask
            // 
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(24, 55);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(140, 21);
            this.cmbTask.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tasks Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 96);
            this.panel1.TabIndex = 75;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(219, 32);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(76, 35);
            this.btnInventory.TabIndex = 69;
            this.btnInventory.Text = "GENERATE";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Report";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnEmployeeAll);
            this.panel4.Controls.Add(this.btnEmployee);
            this.panel4.Controls.Add(this.cmbEmployee);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(59, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 96);
            this.panel4.TabIndex = 73;
            // 
            // btnEmployeeAll
            // 
            this.btnEmployeeAll.BackColor = System.Drawing.Color.White;
            this.btnEmployeeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeAll.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEmployeeAll.Location = new System.Drawing.Point(275, 30);
            this.btnEmployeeAll.Name = "btnEmployeeAll";
            this.btnEmployeeAll.Size = new System.Drawing.Size(42, 35);
            this.btnEmployeeAll.TabIndex = 68;
            this.btnEmployeeAll.Text = "ALL";
            this.btnEmployeeAll.UseVisualStyleBackColor = false;
            this.btnEmployeeAll.Click += new System.EventHandler(this.btnEmployeeAll_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(193, 30);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(76, 35);
            this.btnEmployee.TabIndex = 69;
            this.btnEmployee.Text = "GENERATE";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(24, 55);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(140, 21);
            this.cmbEmployee.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee Report";
            // 
            // frmHeadReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.rptViewerHead);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHeadReport";
            this.Text = "frmHeadReport";
            this.Load += new System.EventHandler(this.frmHeadReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewerHead;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSubAll;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.ComboBox cmbSubTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaskAll;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEmployeeAll;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label7;
    }
}