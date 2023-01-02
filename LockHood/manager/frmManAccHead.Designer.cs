namespace LockHood
{
    partial class frmManAccHead
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_head = new System.Windows.Forms.DataGridView();
            this.headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblErrorMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorDepart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.lblUpdsucces = new System.Windows.Forms.Label();
            this.cmbupdateDep = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnupdateCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.updateEmail_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateName_txtbox = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblSucces = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_head)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_head
            // 
            this.dgv_head.AllowUserToDeleteRows = false;
            this.dgv_head.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_head.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_head.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_head.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_head.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_head.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headid,
            this.namefield,
            this.Email,
            this.Department,
            this.update_btn,
            this.delete_btn});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_head.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_head.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_head.Location = new System.Drawing.Point(53, 110);
            this.dgv_head.Name = "dgv_head";
            this.dgv_head.ReadOnly = true;
            this.dgv_head.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_head.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_head.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_head.RowTemplate.Height = 35;
            this.dgv_head.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_head.Size = new System.Drawing.Size(942, 452);
            this.dgv_head.TabIndex = 2;
            this.dgv_head.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_head_CellClick);
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
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.namefield.DefaultCellStyle = dataGridViewCellStyle14;
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
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // update_btn
            // 
            this.update_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            this.update_btn.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_btn.DefaultCellStyle = dataGridViewCellStyle16;
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
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(52, 94);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(67, 12);
            this.lblErrorName.TabIndex = 47;
            this.lblErrorName.Text = "Error Username";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(53, 63);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 27);
            this.txtName.TabIndex = 46;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblEmail.Location = new System.Drawing.Point(50, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Name";
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.AutoSize = true;
            this.lblErrorMail.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(257, 94);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(67, 12);
            this.lblErrorMail.TabIndex = 50;
            this.lblErrorMail.Text = "Error Username";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(258, 63);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(174, 27);
            this.txtMail.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(255, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Email";
            // 
            // lblErrorDepart
            // 
            this.lblErrorDepart.AutoSize = true;
            this.lblErrorDepart.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDepart.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDepart.Location = new System.Drawing.Point(697, 94);
            this.lblErrorDepart.Name = "lblErrorDepart";
            this.lblErrorDepart.Size = new System.Drawing.Size(67, 12);
            this.lblErrorDepart.TabIndex = 53;
            this.lblErrorDepart.Text = "Error Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(695, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Department";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(905, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 35);
            this.btnCreate.TabIndex = 55;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatePanel.Controls.Add(this.lblUpdsucces);
            this.updatePanel.Controls.Add(this.cmbupdateDep);
            this.updatePanel.Controls.Add(this.label8);
            this.updatePanel.Controls.Add(this.btnupdateCancel);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.updateEmail_txtbox);
            this.updatePanel.Controls.Add(this.label6);
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.updateName_txtbox);
            this.updatePanel.Location = new System.Drawing.Point(402, 167);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(280, 339);
            this.updatePanel.TabIndex = 56;
            this.updatePanel.Visible = false;
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
            // cmbupdateDep
            // 
            this.cmbupdateDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbupdateDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbupdateDep.FormattingEnabled = true;
            this.cmbupdateDep.Location = new System.Drawing.Point(32, 219);
            this.cmbupdateDep.Name = "cmbupdateDep";
            this.cmbupdateDep.Size = new System.Drawing.Size(216, 21);
            this.cmbupdateDep.TabIndex = 58;
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
            this.btnupdateCancel.Location = new System.Drawing.Point(160, 268);
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
            this.btnUpdate.Location = new System.Drawing.Point(31, 268);
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
            this.label7.Location = new System.Drawing.Point(29, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Department";
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
            this.updateName_txtbox.Location = new System.Drawing.Point(32, 91);
            this.updateName_txtbox.Multiline = true;
            this.updateName_txtbox.Name = "updateName_txtbox";
            this.updateName_txtbox.Size = new System.Drawing.Size(216, 27);
            this.updateName_txtbox.TabIndex = 47;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(698, 66);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(175, 21);
            this.cmbDepartment.TabIndex = 57;
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucces.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSucces.Location = new System.Drawing.Point(48, 9);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(64, 21);
            this.lblSucces.TabIndex = 65;
            this.lblSucces.Text = "Success";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(466, 63);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(216, 27);
            this.txtPass.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(463, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Password";
            // 
            // lblErrPass
            // 
            this.lblErrPass.AutoSize = true;
            this.lblErrPass.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrPass.Location = new System.Drawing.Point(464, 93);
            this.lblErrPass.Name = "lblErrPass";
            this.lblErrPass.Size = new System.Drawing.Size(67, 12);
            this.lblErrPass.TabIndex = 71;
            this.lblErrPass.Text = "Error Username";
            // 
            // frmManAccHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 625);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrPass);
            this.Controls.Add(this.lblSucces);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblErrorDepart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dgv_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManAccHead";
            this.Text = "frmManAccHead";
            this.Load += new System.EventHandler(this.frmManAccHead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_head)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_head;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblErrorMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorDepart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateName_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateEmail_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnupdateCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbupdateDep;
        private System.Windows.Forms.Label lblUpdsucces;
        private System.Windows.Forms.Label lblSucces;
        private System.Windows.Forms.DataGridViewTextBoxColumn headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefield;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewButtonColumn update_btn;
        private System.Windows.Forms.DataGridViewButtonColumn delete_btn;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrPass;
    }
}