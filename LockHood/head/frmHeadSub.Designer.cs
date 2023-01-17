
namespace LockHood.head
{
    partial class frmHeadSub
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeadSub));
            this.lblSucces = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSortWork = new System.Windows.Forms.ComboBox();
            this.dgv_sub = new System.Windows.Forms.DataGridView();
            this.MainTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubWorkshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblErrorEmp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblErrorDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblErrorSub = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorTask = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnupdateCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdSub = new System.Windows.Forms.TextBox();
            this.cmbUpdEmp = new System.Windows.Forms.ComboBox();
            this.dtpUpdDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_task = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NotYet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub)).BeginInit();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucces.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSucces.Location = new System.Drawing.Point(24, 17);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(64, 21);
            this.lblSucces.TabIndex = 102;
            this.lblSucces.Text = "Success";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(708, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Sort by Workshop";
            // 
            // cmbSortWork
            // 
            this.cmbSortWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbSortWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSortWork.FormattingEnabled = true;
            this.cmbSortWork.Location = new System.Drawing.Point(826, 36);
            this.cmbSortWork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSortWork.Name = "cmbSortWork";
            this.cmbSortWork.Size = new System.Drawing.Size(216, 21);
            this.cmbSortWork.TabIndex = 100;
            this.cmbSortWork.SelectedIndexChanged += new System.EventHandler(this.cmbSortWork_SelectedIndexChanged);
            // 
            // dgv_sub
            // 
            this.dgv_sub.AllowUserToDeleteRows = false;
            this.dgv_sub.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_sub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_sub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MainTask,
            this.Subtask,
            this.SubDate,
            this.SubWorkshop,
            this.Employee,
            this.SubStatus,
            this.Update,
            this.Delete});
            this.dgv_sub.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_sub.Location = new System.Drawing.Point(272, 219);
            this.dgv_sub.Name = "dgv_sub";
            this.dgv_sub.ReadOnly = true;
            this.dgv_sub.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_sub.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_sub.RowTemplate.Height = 35;
            this.dgv_sub.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sub.Size = new System.Drawing.Size(770, 387);
            this.dgv_sub.TabIndex = 99;
            this.dgv_sub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sub_CellClick);
            // 
            // MainTask
            // 
            this.MainTask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MainTask.DataPropertyName = "TaskID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MainTask.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainTask.HeaderText = "TaskID";
            this.MainTask.MinimumWidth = 6;
            this.MainTask.Name = "MainTask";
            this.MainTask.ReadOnly = true;
            // 
            // Subtask
            // 
            this.Subtask.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subtask.DataPropertyName = "Subtask";
            this.Subtask.HeaderText = "Subtask";
            this.Subtask.Name = "Subtask";
            this.Subtask.ReadOnly = true;
            // 
            // SubDate
            // 
            this.SubDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubDate.DataPropertyName = "Date";
            this.SubDate.HeaderText = "Date";
            this.SubDate.MinimumWidth = 6;
            this.SubDate.Name = "SubDate";
            this.SubDate.ReadOnly = true;
            // 
            // SubWorkshop
            // 
            this.SubWorkshop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubWorkshop.DataPropertyName = "Workshop";
            this.SubWorkshop.HeaderText = "Workshop";
            this.SubWorkshop.MinimumWidth = 6;
            this.SubWorkshop.Name = "SubWorkshop";
            this.SubWorkshop.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // SubStatus
            // 
            this.SubStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubStatus.DataPropertyName = "Status";
            this.SubStatus.HeaderText = "Status";
            this.SubStatus.Name = "SubStatus";
            this.SubStatus.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.Update.DefaultCellStyle = dataGridViewCellStyle3;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "UPDATE";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "DELETE";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lblErrorEmp
            // 
            this.lblErrorEmp.AutoSize = true;
            this.lblErrorEmp.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmp.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmp.Location = new System.Drawing.Point(27, 325);
            this.lblErrorEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorEmp.Name = "lblErrorEmp";
            this.lblErrorEmp.Size = new System.Drawing.Size(67, 12);
            this.lblErrorEmp.TabIndex = 98;
            this.lblErrorEmp.Text = "Error Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label10.Location = new System.Drawing.Point(26, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Employee";
            // 
            // lblErrorDate
            // 
            this.lblErrorDate.AutoSize = true;
            this.lblErrorDate.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDate.Location = new System.Drawing.Point(27, 253);
            this.lblErrorDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorDate.Name = "lblErrorDate";
            this.lblErrorDate.Size = new System.Drawing.Size(67, 12);
            this.lblErrorDate.TabIndex = 96;
            this.lblErrorDate.Text = "Error Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(26, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Sub task";
            // 
            // lblErrorSub
            // 
            this.lblErrorSub.AutoSize = true;
            this.lblErrorSub.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSub.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSub.Location = new System.Drawing.Point(27, 182);
            this.lblErrorSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorSub.Name = "lblErrorSub";
            this.lblErrorSub.Size = new System.Drawing.Size(67, 12);
            this.lblErrorSub.TabIndex = 94;
            this.lblErrorSub.Text = "Error Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(26, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Date";
            // 
            // lblErrorTask
            // 
            this.lblErrorTask.AutoSize = true;
            this.lblErrorTask.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTask.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTask.Location = new System.Drawing.Point(27, 107);
            this.lblErrorTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorTask.Name = "lblErrorTask";
            this.lblErrorTask.Size = new System.Drawing.Size(67, 12);
            this.lblErrorTask.TabIndex = 92;
            this.lblErrorTask.Text = "Error Username";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(28, 411);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 35);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(28, 370);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(216, 35);
            this.btnCreate.TabIndex = 91;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtSub
            // 
            this.txtSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSub.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.Location = new System.Drawing.Point(28, 154);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSub.Multiline = true;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(216, 27);
            this.txtSub.TabIndex = 89;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblEmail.Location = new System.Drawing.Point(25, 66);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 88;
            this.lblEmail.Text = "Task";
            // 
            // cmbEmp
            // 
            this.cmbEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(28, 304);
            this.cmbEmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(216, 21);
            this.cmbEmp.TabIndex = 87;
            // 
            // cmbTask
            // 
            this.cmbTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(28, 85);
            this.cmbTask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(216, 21);
            this.cmbTask.TabIndex = 86;
            this.cmbTask.SelectedIndexChanged += new System.EventHandler(this.cmbTask_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtpDate.Location = new System.Drawing.Point(28, 230);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(216, 20);
            this.dtpDate.TabIndex = 85;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(30, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnupdateCancel
            // 
            this.btnupdateCancel.BackColor = System.Drawing.Color.White;
            this.btnupdateCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateCancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnupdateCancel.Location = new System.Drawing.Point(159, 265);
            this.btnupdateCancel.Name = "btnupdateCancel";
            this.btnupdateCancel.Size = new System.Drawing.Size(88, 35);
            this.btnupdateCancel.TabIndex = 57;
            this.btnupdateCancel.Text = "CANCEL";
            this.btnupdateCancel.UseVisualStyleBackColor = false;
            this.btnupdateCancel.Click += new System.EventHandler(this.btnupdateCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(28, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Update";
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.label11);
            this.updatePanel.Controls.Add(this.txtUpdSub);
            this.updatePanel.Controls.Add(this.cmbUpdEmp);
            this.updatePanel.Controls.Add(this.dtpUpdDate);
            this.updatePanel.Controls.Add(this.label3);
            this.updatePanel.Controls.Add(this.btnupdateCancel);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Location = new System.Drawing.Point(538, 154);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(280, 347);
            this.updatePanel.TabIndex = 103;
            this.updatePanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(30, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(30, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 121;
            this.label7.Text = "Sub task";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label11.Location = new System.Drawing.Point(30, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Date";
            // 
            // txtUpdSub
            // 
            this.txtUpdSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUpdSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdSub.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdSub.Location = new System.Drawing.Point(32, 103);
            this.txtUpdSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdSub.Multiline = true;
            this.txtUpdSub.Name = "txtUpdSub";
            this.txtUpdSub.Size = new System.Drawing.Size(216, 27);
            this.txtUpdSub.TabIndex = 119;
            // 
            // cmbUpdEmp
            // 
            this.cmbUpdEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbUpdEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUpdEmp.FormattingEnabled = true;
            this.cmbUpdEmp.Location = new System.Drawing.Point(32, 221);
            this.cmbUpdEmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbUpdEmp.Name = "cmbUpdEmp";
            this.cmbUpdEmp.Size = new System.Drawing.Size(216, 21);
            this.cmbUpdEmp.TabIndex = 117;
            // 
            // dtpUpdDate
            // 
            this.dtpUpdDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtpUpdDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtpUpdDate.Location = new System.Drawing.Point(32, 164);
            this.dtpUpdDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpUpdDate.Name = "dtpUpdDate";
            this.dtpUpdDate.Size = new System.Drawing.Size(216, 20);
            this.dtpUpdDate.TabIndex = 115;
            // 
            // dgv_task
            // 
            this.dgv_task.AllowUserToDeleteRows = false;
            this.dgv_task.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_task.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Task,
            this.Status,
            this.Date,
            this.Workshop,
            this.dataGridViewButtonColumn5,
            this.NotYet});
            this.dgv_task.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_task.Location = new System.Drawing.Point(272, 63);
            this.dgv_task.Name = "dgv_task";
            this.dgv_task.ReadOnly = true;
            this.dgv_task.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_task.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_task.RowTemplate.Height = 35;
            this.dgv_task.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_task.Size = new System.Drawing.Size(770, 150);
            this.dgv_task.TabIndex = 104;
            this.dgv_task.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_task_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.DataPropertyName = "Task";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Task.DefaultCellStyle = dataGridViewCellStyle6;
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 6;
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Workshop
            // 
            this.Workshop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Workshop.DataPropertyName = "Workshop";
            this.Workshop.HeaderText = "Workshop";
            this.Workshop.MinimumWidth = 6;
            this.Workshop.Name = "Workshop";
            this.Workshop.ReadOnly = true;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewButtonColumn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn5.HeaderText = "Complete";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.ReadOnly = true;
            this.dataGridViewButtonColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn5.Text = "COMPLETE";
            this.dataGridViewButtonColumn5.ToolTipText = "Complete";
            this.dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
            // 
            // NotYet
            // 
            this.NotYet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.NotYet.DefaultCellStyle = dataGridViewCellStyle8;
            this.NotYet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotYet.HeaderText = "NotYet";
            this.NotYet.Name = "NotYet";
            this.NotYet.ReadOnly = true;
            this.NotYet.Text = "NOT YET";
            this.NotYet.ToolTipText = "NotYet";
            this.NotYet.UseColumnTextForButtonValue = true;
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(669, 36);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(23, 23);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 118;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // frmHeadSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.dgv_task);
            this.Controls.Add(this.lblSucces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSortWork);
            this.Controls.Add(this.dgv_sub);
            this.Controls.Add(this.lblErrorEmp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblErrorDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblErrorSub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblErrorTask);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.cmbTask);
            this.Controls.Add(this.dtpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHeadSub";
            this.Text = "frmHeadSub";
            this.Load += new System.EventHandler(this.frmHeadSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSucces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSortWork;
        private System.Windows.Forms.DataGridView dgv_sub;
        private System.Windows.Forms.Label lblErrorEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblErrorDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblErrorSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErrorTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnupdateCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdSub;
        private System.Windows.Forms.ComboBox cmbUpdEmp;
        private System.Windows.Forms.DateTimePicker dtpUpdDate;
        private System.Windows.Forms.DataGridView dgv_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workshop;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn NotYet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtask;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubWorkshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubStatus;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox picRefresh;
    }
}