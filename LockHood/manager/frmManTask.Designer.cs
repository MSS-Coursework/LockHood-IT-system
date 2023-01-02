
namespace LockHood
{
    partial class frmManTask
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
            this.cmb_Workshop = new System.Windows.Forms.ComboBox();
            this.cmb_DepName = new System.Windows.Forms.ComboBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lblErrorTask = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblErrorDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorDepart = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblErrorWork = new System.Windows.Forms.Label();
            this.dgv_task = new System.Windows.Forms.DataGridView();
            this.headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSucces = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.dtpUpdDate = new System.Windows.Forms.DateTimePicker();
            this.cmbUpdDepart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdsucces = new System.Windows.Forms.Label();
            this.cmbupdateWork = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdateCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateTask_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Workshop
            // 
            this.cmb_Workshop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmb_Workshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Workshop.FormattingEnabled = true;
            this.cmb_Workshop.Location = new System.Drawing.Point(23, 326);
            this.cmb_Workshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Workshop.Name = "cmb_Workshop";
            this.cmb_Workshop.Size = new System.Drawing.Size(216, 23);
            this.cmb_Workshop.TabIndex = 32;
            // 
            // cmb_DepName
            // 
            this.cmb_DepName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmb_DepName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_DepName.FormattingEnabled = true;
            this.cmb_DepName.Location = new System.Drawing.Point(23, 256);
            this.cmb_DepName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_DepName.Name = "cmb_DepName";
            this.cmb_DepName.Size = new System.Drawing.Size(216, 23);
            this.cmb_DepName.TabIndex = 31;
            this.cmb_DepName.Leave += new System.EventHandler(this.cmb_DepName_Leave);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtp_Date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtp_Date.Location = new System.Drawing.Point(23, 184);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(216, 23);
            this.dtp_Date.TabIndex = 30;
            // 
            // lblErrorTask
            // 
            this.lblErrorTask.AutoSize = true;
            this.lblErrorTask.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTask.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTask.Location = new System.Drawing.Point(22, 143);
            this.lblErrorTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorTask.Name = "lblErrorTask";
            this.lblErrorTask.Size = new System.Drawing.Size(67, 12);
            this.lblErrorTask.TabIndex = 53;
            this.lblErrorTask.Text = "Error Username";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(23, 433);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 35);
            this.btnCancel.TabIndex = 50;
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
            this.btnCreate.Location = new System.Drawing.Point(23, 392);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(216, 35);
            this.btnCreate.TabIndex = 51;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTask.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(23, 107);
            this.txtTask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(216, 27);
            this.txtTask.TabIndex = 47;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblEmail.Location = new System.Drawing.Point(20, 84);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 15);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Task";
            // 
            // lblErrorDate
            // 
            this.lblErrorDate.AutoSize = true;
            this.lblErrorDate.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDate.Location = new System.Drawing.Point(22, 211);
            this.lblErrorDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorDate.Name = "lblErrorDate";
            this.lblErrorDate.Size = new System.Drawing.Size(67, 12);
            this.lblErrorDate.TabIndex = 55;
            this.lblErrorDate.Text = "Error Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "Date";
            // 
            // lblErrorDepart
            // 
            this.lblErrorDepart.AutoSize = true;
            this.lblErrorDepart.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDepart.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDepart.Location = new System.Drawing.Point(22, 282);
            this.lblErrorDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorDepart.Name = "lblErrorDepart";
            this.lblErrorDepart.Size = new System.Drawing.Size(67, 12);
            this.lblErrorDepart.TabIndex = 57;
            this.lblErrorDepart.Text = "Error Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(21, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label10.Location = new System.Drawing.Point(21, 308);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "Workshop";
            // 
            // lblErrorWork
            // 
            this.lblErrorWork.AutoSize = true;
            this.lblErrorWork.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorWork.ForeColor = System.Drawing.Color.Red;
            this.lblErrorWork.Location = new System.Drawing.Point(22, 353);
            this.lblErrorWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorWork.Name = "lblErrorWork";
            this.lblErrorWork.Size = new System.Drawing.Size(67, 12);
            this.lblErrorWork.TabIndex = 59;
            this.lblErrorWork.Text = "Error Username";
            // 
            // dgv_task
            // 
            this.dgv_task.AllowUserToDeleteRows = false;
            this.dgv_task.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_task.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headid,
            this.Task,
            this.Status,
            this.Date,
            this.Workshop,
            this.Department,
            this.Update,
            this.Delete});
            this.dgv_task.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_task.Location = new System.Drawing.Point(268, 84);
            this.dgv_task.Name = "dgv_task";
            this.dgv_task.ReadOnly = true;
            this.dgv_task.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_task.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_task.RowTemplate.Height = 35;
            this.dgv_task.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_task.Size = new System.Drawing.Size(770, 457);
            this.dgv_task.TabIndex = 60;
            this.dgv_task.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_task_CellClick);
            // 
            // headid
            // 
            this.headid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headid.DataPropertyName = "ID";
            this.headid.HeaderText = "ID";
            this.headid.MinimumWidth = 6;
            this.headid.Name = "headid";
            this.headid.ReadOnly = true;
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.DataPropertyName = "Task";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Task.DefaultCellStyle = dataGridViewCellStyle2;
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
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
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
            // cmbDepart
            // 
            this.cmbDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(822, 55);
            this.cmbDepart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(216, 23);
            this.cmbDepart.TabIndex = 61;
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.cmbDepart_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(704, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sort by Department";
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucces.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSucces.Location = new System.Drawing.Point(20, 20);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(64, 21);
            this.lblSucces.TabIndex = 66;
            this.lblSucces.Text = "Success";
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatePanel.Controls.Add(this.dtpUpdDate);
            this.updatePanel.Controls.Add(this.cmbUpdDepart);
            this.updatePanel.Controls.Add(this.label2);
            this.updatePanel.Controls.Add(this.lblUpdsucces);
            this.updatePanel.Controls.Add(this.cmbupdateWork);
            this.updatePanel.Controls.Add(this.label3);
            this.updatePanel.Controls.Add(this.btnupdateCancel);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.updateTask_txtbox);
            this.updatePanel.Location = new System.Drawing.Point(397, 116);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(280, 392);
            this.updatePanel.TabIndex = 84;
            this.updatePanel.Visible = false;
            // 
            // dtpUpdDate
            // 
            this.dtpUpdDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtpUpdDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dtpUpdDate.Location = new System.Drawing.Point(30, 153);
            this.dtpUpdDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpUpdDate.Name = "dtpUpdDate";
            this.dtpUpdDate.Size = new System.Drawing.Size(216, 23);
            this.dtpUpdDate.TabIndex = 85;
            // 
            // cmbUpdDepart
            // 
            this.cmbUpdDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbUpdDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUpdDepart.FormattingEnabled = true;
            this.cmbUpdDepart.Location = new System.Drawing.Point(31, 210);
            this.cmbUpdDepart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbUpdDepart.Name = "cmbUpdDepart";
            this.cmbUpdDepart.Size = new System.Drawing.Size(217, 23);
            this.cmbUpdDepart.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(28, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 86;
            this.label2.Text = "Department";
            // 
            // lblUpdsucces
            // 
            this.lblUpdsucces.AutoSize = true;
            this.lblUpdsucces.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdsucces.ForeColor = System.Drawing.Color.Blue;
            this.lblUpdsucces.Location = new System.Drawing.Point(12, 9);
            this.lblUpdsucces.Name = "lblUpdsucces";
            this.lblUpdsucces.Size = new System.Drawing.Size(46, 13);
            this.lblUpdsucces.TabIndex = 64;
            this.lblUpdsucces.Text = "Success";
            // 
            // cmbupdateWork
            // 
            this.cmbupdateWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbupdateWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbupdateWork.FormattingEnabled = true;
            this.cmbupdateWork.Location = new System.Drawing.Point(30, 266);
            this.cmbupdateWork.Name = "cmbupdateWork";
            this.cmbupdateWork.Size = new System.Drawing.Size(218, 23);
            this.cmbupdateWork.TabIndex = 58;
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
            // btnupdateCancel
            // 
            this.btnupdateCancel.BackColor = System.Drawing.Color.White;
            this.btnupdateCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateCancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnupdateCancel.Location = new System.Drawing.Point(159, 322);
            this.btnupdateCancel.Name = "btnupdateCancel";
            this.btnupdateCancel.Size = new System.Drawing.Size(88, 35);
            this.btnupdateCancel.TabIndex = 57;
            this.btnupdateCancel.Text = "CANCEL";
            this.btnupdateCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(30, 322);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(28, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "Workshop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(28, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Task";
            // 
            // updateTask_txtbox
            // 
            this.updateTask_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.updateTask_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateTask_txtbox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTask_txtbox.Location = new System.Drawing.Point(30, 91);
            this.updateTask_txtbox.Multiline = true;
            this.updateTask_txtbox.Name = "updateTask_txtbox";
            this.updateTask_txtbox.Size = new System.Drawing.Size(218, 27);
            this.updateTask_txtbox.TabIndex = 47;
            // 
            // frmManTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.lblSucces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.dgv_task);
            this.Controls.Add(this.lblErrorWork);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblErrorDepart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblErrorDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblErrorTask);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmb_Workshop);
            this.Controls.Add(this.cmb_DepName);
            this.Controls.Add(this.dtp_Date);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmManTask";
            this.Text = "frmManTask";
            this.Load += new System.EventHandler(this.frmManTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_Workshop;
        private System.Windows.Forms.ComboBox cmb_DepName;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lblErrorTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblErrorDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErrorDepart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblErrorWork;
        private System.Windows.Forms.DataGridView dgv_task;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSucces;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.ComboBox cmbUpdDepart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdsucces;
        private System.Windows.Forms.ComboBox cmbupdateWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdateCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateTask_txtbox;
        private System.Windows.Forms.DateTimePicker dtpUpdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}