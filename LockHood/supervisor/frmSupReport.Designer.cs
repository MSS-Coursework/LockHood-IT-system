namespace LockHood
{
    partial class frmSupReport
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
            this.ReportViewerSup = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaskAll = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEmpAll = new System.Windows.Forms.Button();
            this.cmbEmpl = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportViewerSup
            // 
            this.ReportViewerSup.Location = new System.Drawing.Point(425, 60);
            this.ReportViewerSup.Name = "ReportViewerSup";
            this.ReportViewerSup.ServerReport.BearerToken = null;
            this.ReportViewerSup.Size = new System.Drawing.Size(600, 533);
            this.ReportViewerSup.TabIndex = 77;
            this.ReportViewerSup.ZoomPercent = 75;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnEmpAll);
            this.panel3.Controls.Add(this.btnEmp);
            this.panel3.Controls.Add(this.cmbEmpl);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(59, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 96);
            this.panel3.TabIndex = 76;
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmp.FlatAppearance.BorderSize = 0;
            this.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmp.ForeColor = System.Drawing.Color.White;
            this.btnEmp.Location = new System.Drawing.Point(193, 30);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(76, 35);
            this.btnEmp.TabIndex = 69;
            this.btnEmp.Text = "GENERATE";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee Report";
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
            this.cmbTask.Items.AddRange(new object[] {
            "Pending",
            "Completed"});
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
            this.panel1.Controls.Add(this.btnMaterial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 96);
            this.panel1.TabIndex = 75;
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Location = new System.Drawing.Point(193, 30);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(124, 35);
            this.btnMaterial.TabIndex = 69;
            this.btnMaterial.Text = "GENERATE";
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material Report";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnRequest);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(59, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 96);
            this.panel4.TabIndex = 73;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Location = new System.Drawing.Point(193, 30);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(124, 35);
            this.btnRequest.TabIndex = 69;
            this.btnRequest.Text = "GENERATE";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Request Report";
            // 
            // btnEmpAll
            // 
            this.btnEmpAll.BackColor = System.Drawing.Color.White;
            this.btnEmpAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAll.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEmpAll.Location = new System.Drawing.Point(275, 30);
            this.btnEmpAll.Name = "btnEmpAll";
            this.btnEmpAll.Size = new System.Drawing.Size(42, 35);
            this.btnEmpAll.TabIndex = 68;
            this.btnEmpAll.Text = "ALL";
            this.btnEmpAll.UseVisualStyleBackColor = false;
            this.btnEmpAll.Click += new System.EventHandler(this.btnEmpAll_Click);
            // 
            // cmbEmpl
            // 
            this.cmbEmpl.FormattingEnabled = true;
            this.cmbEmpl.Location = new System.Drawing.Point(24, 55);
            this.cmbEmpl.Name = "cmbEmpl";
            this.cmbEmpl.Size = new System.Drawing.Size(140, 21);
            this.cmbEmpl.TabIndex = 3;
            // 
            // frmSupReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.ReportViewerSup);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSupReport";
            this.Text = "frmSupReport";
            this.Load += new System.EventHandler(this.frmSupReport_Load);
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

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerSup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaskAll;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEmpAll;
        private System.Windows.Forms.ComboBox cmbEmpl;
    }
}