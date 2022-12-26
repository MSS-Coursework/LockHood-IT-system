namespace LockHood
{
    partial class frmManEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSucces = new System.Windows.Forms.Label();
            this.cmbWork = new System.Windows.Forms.ComboBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.txtUpdRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdsucces = new System.Windows.Forms.Label();
            this.cmbupdateWork = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnupdateCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.updateEmail_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateName_txtbox = new System.Windows.Forms.TextBox();
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblErrorWork = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblErrorRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucces.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSucces.Location = new System.Drawing.Point(35, 12);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(64, 21);
            this.lblSucces.TabIndex = 79;
            this.lblSucces.Text = "Success";
            // 
            // cmbWork
            // 
            this.cmbWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWork.FormattingEnabled = true;
            this.cmbWork.Location = new System.Drawing.Point(744, 68);
            this.cmbWork.Name = "cmbWork";
            this.cmbWork.Size = new System.Drawing.Size(217, 21);
            this.cmbWork.TabIndex = 77;
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatePanel.Controls.Add(this.txtUpdRole);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Controls.Add(this.lblUpdsucces);
            this.updatePanel.Controls.Add(this.cmbupdateWork);
            this.updatePanel.Controls.Add(this.label8);
            this.updatePanel.Controls.Add(this.btnupdateCancel);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.updateEmail_txtbox);
            this.updatePanel.Controls.Add(this.label6);
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.updateName_txtbox);
            this.updatePanel.Location = new System.Drawing.Point(402, 125);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(280, 392);
            this.updatePanel.TabIndex = 83;
            this.updatePanel.Visible = false;
            // 
            // txtUpdRole
            // 
            this.txtUpdRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUpdRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdRole.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdRole.Location = new System.Drawing.Point(31, 212);
            this.txtUpdRole.Multiline = true;
            this.txtUpdRole.Name = "txtUpdRole";
            this.txtUpdRole.Size = new System.Drawing.Size(217, 27);
            this.txtUpdRole.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(28, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Role";
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
            this.cmbupdateWork.Location = new System.Drawing.Point(30, 273);
            this.cmbupdateWork.Name = "cmbupdateWork";
            this.cmbupdateWork.Size = new System.Drawing.Size(218, 21);
            this.cmbupdateWork.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(28, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 27);
            this.label8.TabIndex = 63;
            this.label8.Text = "Update";
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
            this.btnupdateCancel.Click += new System.EventHandler(this.btnupdateCancel_Click);
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
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Workshop";
            // 
            // updateEmail_txtbox
            // 
            this.updateEmail_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.updateEmail_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateEmail_txtbox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmail_txtbox.Location = new System.Drawing.Point(31, 151);
            this.updateEmail_txtbox.Multiline = true;
            this.updateEmail_txtbox.Name = "updateEmail_txtbox";
            this.updateEmail_txtbox.Size = new System.Drawing.Size(217, 27);
            this.updateEmail_txtbox.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(28, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(30, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Name";
            // 
            // updateName_txtbox
            // 
            this.updateName_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.updateName_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateName_txtbox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateName_txtbox.Location = new System.Drawing.Point(30, 91);
            this.updateName_txtbox.Multiline = true;
            this.updateName_txtbox.Name = "updateName_txtbox";
            this.updateName_txtbox.Size = new System.Drawing.Size(218, 27);
            this.updateName_txtbox.TabIndex = 47;
            // 
            // dgv_emp
            // 
            this.dgv_emp.AllowUserToDeleteRows = false;
            this.dgv_emp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_emp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_emp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headid,
            this.namefield,
            this.Email,
            this.Role,
            this.Workshop,
            this.update_btn,
            this.delete_btn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_emp.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_emp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_emp.Location = new System.Drawing.Point(39, 113);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.ReadOnly = true;
            this.dgv_emp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_emp.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_emp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_emp.RowTemplate.Height = 35;
            this.dgv_emp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_emp.Size = new System.Drawing.Size(1003, 452);
            this.dgv_emp.TabIndex = 82;
            this.dgv_emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellClick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(966, 60);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(76, 35);
            this.btnCreate.TabIndex = 81;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblErrorWork
            // 
            this.lblErrorWork.AutoSize = true;
            this.lblErrorWork.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorWork.ForeColor = System.Drawing.Color.Red;
            this.lblErrorWork.Location = new System.Drawing.Point(743, 96);
            this.lblErrorWork.Name = "lblErrorWork";
            this.lblErrorWork.Size = new System.Drawing.Size(67, 12);
            this.lblErrorWork.TabIndex = 78;
            this.lblErrorWork.Text = "Error Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(741, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Workshop";
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.AutoSize = true;
            this.lblErrorMail.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(269, 97);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(67, 12);
            this.lblErrorMail.TabIndex = 75;
            this.lblErrorMail.Text = "Error Username";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(270, 66);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(216, 27);
            this.txtMail.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(267, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Email";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(38, 97);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(67, 12);
            this.lblErrorName.TabIndex = 72;
            this.lblErrorName.Text = "Error Username";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(39, 66);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 27);
            this.txtName.TabIndex = 71;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblEmail.Location = new System.Drawing.Point(36, 46);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 70;
            this.lblEmail.Text = "Name";
            // 
            // lblErrorRole
            // 
            this.lblErrorRole.AutoSize = true;
            this.lblErrorRole.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRole.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRole.Location = new System.Drawing.Point(505, 97);
            this.lblErrorRole.Name = "lblErrorRole";
            this.lblErrorRole.Size = new System.Drawing.Size(67, 12);
            this.lblErrorRole.TabIndex = 86;
            this.lblErrorRole.Text = "Error Username";
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRole.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(506, 66);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(216, 27);
            this.txtRole.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(503, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Role";
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
            // namefield
            // 
            this.namefield.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namefield.DataPropertyName = "Name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.namefield.DefaultCellStyle = dataGridViewCellStyle2;
            this.namefield.HeaderText = "Name";
            this.namefield.MinimumWidth = 6;
            this.namefield.Name = "namefield";
            this.namefield.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
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
            // update_btn
            // 
            this.update_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.update_btn.DefaultCellStyle = dataGridViewCellStyle3;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.HeaderText = "Update";
            this.update_btn.MinimumWidth = 6;
            this.update_btn.Name = "update_btn";
            this.update_btn.ReadOnly = true;
            this.update_btn.Text = "UPDATE";
            this.update_btn.ToolTipText = "Update";
            this.update_btn.UseColumnTextForButtonValue = true;
            this.update_btn.Width = 120;
            // 
            // delete_btn
            // 
            this.delete_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_btn.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.HeaderText = "Delete";
            this.delete_btn.MinimumWidth = 6;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.ReadOnly = true;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.ToolTipText = "Delete";
            this.delete_btn.UseColumnTextForButtonValue = true;
            this.delete_btn.Width = 120;
            // 
            // frmManEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.lblErrorRole);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSucces);
            this.Controls.Add(this.cmbWork);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.dgv_emp);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblErrorWork);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManEmployee";
            this.Text = "frmManEmployee";
            this.Load += new System.EventHandler(this.frmManEmployee_Load);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucces;
        private System.Windows.Forms.ComboBox cmbWork;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label lblUpdsucces;
        private System.Windows.Forms.ComboBox cmbupdateWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnupdateCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateEmail_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateName_txtbox;
        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblErrorWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblErrorRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefield;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workshop;
        private System.Windows.Forms.DataGridViewButtonColumn update_btn;
        private System.Windows.Forms.DataGridViewButtonColumn delete_btn;
    }
}