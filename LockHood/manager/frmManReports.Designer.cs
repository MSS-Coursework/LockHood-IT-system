namespace LockHood
{
    partial class frmManReports
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnIncoAll = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllinven = new System.Windows.Forms.Button();
            this.btnInvent = new System.Windows.Forms.Button();
            this.cmbInventory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAllTask = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuperAll = new System.Windows.Forms.Button();
            this.btnSuper = new System.Windows.Forms.Button();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rptviewerMan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dtpEnd);
            this.panel4.Controls.Add(this.dtpStart);
            this.panel4.Controls.Add(this.btnIncoAll);
            this.panel4.Controls.Add(this.btnIncome);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(59, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 136);
            this.panel4.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Start Date";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(91, 100);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 71;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(91, 74);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 70;
            // 
            // btnIncoAll
            // 
            this.btnIncoAll.BackColor = System.Drawing.Color.White;
            this.btnIncoAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncoAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncoAll.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnIncoAll.Location = new System.Drawing.Point(275, 30);
            this.btnIncoAll.Name = "btnIncoAll";
            this.btnIncoAll.Size = new System.Drawing.Size(42, 35);
            this.btnIncoAll.TabIndex = 68;
            this.btnIncoAll.Text = "ALL";
            this.btnIncoAll.UseVisualStyleBackColor = false;
            this.btnIncoAll.Click += new System.EventHandler(this.btnIncoAll_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Location = new System.Drawing.Point(193, 30);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(76, 35);
            this.btnIncome.TabIndex = 69;
            this.btnIncome.Text = "GENERATE";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Income Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAllinven);
            this.panel1.Controls.Add(this.btnInvent);
            this.panel1.Controls.Add(this.cmbInventory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 96);
            this.panel1.TabIndex = 70;
            // 
            // btnAllinven
            // 
            this.btnAllinven.BackColor = System.Drawing.Color.White;
            this.btnAllinven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllinven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllinven.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAllinven.Location = new System.Drawing.Point(275, 30);
            this.btnAllinven.Name = "btnAllinven";
            this.btnAllinven.Size = new System.Drawing.Size(42, 35);
            this.btnAllinven.TabIndex = 68;
            this.btnAllinven.Text = "ALL";
            this.btnAllinven.UseVisualStyleBackColor = false;
            this.btnAllinven.Click += new System.EventHandler(this.btnAllinven_Click);
            // 
            // btnInvent
            // 
            this.btnInvent.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvent.FlatAppearance.BorderSize = 0;
            this.btnInvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvent.ForeColor = System.Drawing.Color.White;
            this.btnInvent.Location = new System.Drawing.Point(193, 30);
            this.btnInvent.Name = "btnInvent";
            this.btnInvent.Size = new System.Drawing.Size(76, 35);
            this.btnInvent.TabIndex = 69;
            this.btnInvent.Text = "GENERATE";
            this.btnInvent.UseVisualStyleBackColor = false;
            this.btnInvent.Click += new System.EventHandler(this.btnInvent_Click);
            // 
            // cmbInventory
            // 
            this.cmbInventory.FormattingEnabled = true;
            this.cmbInventory.Location = new System.Drawing.Point(24, 55);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(140, 21);
            this.cmbInventory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnAllTask);
            this.panel2.Controls.Add(this.btnTask);
            this.panel2.Controls.Add(this.cmbTask);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(59, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 96);
            this.panel2.TabIndex = 70;
            // 
            // btnAllTask
            // 
            this.btnAllTask.BackColor = System.Drawing.Color.White;
            this.btnAllTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTask.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAllTask.Location = new System.Drawing.Point(275, 30);
            this.btnAllTask.Name = "btnAllTask";
            this.btnAllTask.Size = new System.Drawing.Size(42, 35);
            this.btnAllTask.TabIndex = 68;
            this.btnAllTask.Text = "ALL";
            this.btnAllTask.UseVisualStyleBackColor = false;
            this.btnAllTask.Click += new System.EventHandler(this.btnAllTask_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnSuperAll);
            this.panel3.Controls.Add(this.btnSuper);
            this.panel3.Controls.Add(this.cmbSupervisor);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(59, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 96);
            this.panel3.TabIndex = 71;
            // 
            // btnSuperAll
            // 
            this.btnSuperAll.BackColor = System.Drawing.Color.White;
            this.btnSuperAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuperAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuperAll.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSuperAll.Location = new System.Drawing.Point(275, 30);
            this.btnSuperAll.Name = "btnSuperAll";
            this.btnSuperAll.Size = new System.Drawing.Size(42, 35);
            this.btnSuperAll.TabIndex = 68;
            this.btnSuperAll.Text = "ALL";
            this.btnSuperAll.UseVisualStyleBackColor = false;
            this.btnSuperAll.Click += new System.EventHandler(this.btnSuperAll_Click);
            // 
            // btnSuper
            // 
            this.btnSuper.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSuper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuper.FlatAppearance.BorderSize = 0;
            this.btnSuper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuper.ForeColor = System.Drawing.Color.White;
            this.btnSuper.Location = new System.Drawing.Point(193, 30);
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.Size = new System.Drawing.Size(76, 35);
            this.btnSuper.TabIndex = 69;
            this.btnSuper.Text = "GENERATE";
            this.btnSuper.UseVisualStyleBackColor = false;
            this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Location = new System.Drawing.Point(24, 55);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(140, 21);
            this.cmbSupervisor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supervisor Report";
            // 
            // rptviewerMan
            // 
            this.rptviewerMan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rptviewerMan.Location = new System.Drawing.Point(428, 60);
            this.rptviewerMan.Name = "rptviewerMan";
            this.rptviewerMan.ServerReport.BearerToken = null;
            this.rptviewerMan.Size = new System.Drawing.Size(593, 511);
            this.rptviewerMan.TabIndex = 72;
            this.rptviewerMan.ZoomPercent = 75;
            // 
            // frmManReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.rptviewerMan);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManReports";
            this.Text = "frmManReports";
            this.Load += new System.EventHandler(this.frmManReports_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIncoAll;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllinven;
        private System.Windows.Forms.Button btnInvent;
        private System.Windows.Forms.ComboBox cmbInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAllTask;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSuperAll;
        private System.Windows.Forms.Button btnSuper;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer rptviewerMan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}