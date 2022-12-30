namespace LockHood
{
    partial class frmWarehouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdMat = new System.Windows.Forms.TextBox();
            this.txtUpdQuan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUpdsucces = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdateCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Req = new System.Windows.Forms.DataGridView();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlReqUpdate = new System.Windows.Forms.Panel();
            this.txtAddMate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddReqQuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRqSucess = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdReqCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvIntReq = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbWorkshop = new System.Windows.Forms.ComboBox();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrQuan = new System.Windows.Forms.Label();
            this.lblSucces = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rmaterials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Req)).BeginInit();
            this.pnlReqUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntReq)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(269, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Quantity";
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuant.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(272, 72);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuant.Multiline = true;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(198, 27);
            this.txtQuant.TabIndex = 133;
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.txtUpdMat);
            this.updatePanel.Controls.Add(this.txtUpdQuan);
            this.updatePanel.Controls.Add(this.label13);
            this.updatePanel.Controls.Add(this.lblUpdsucces);
            this.updatePanel.Controls.Add(this.label3);
            this.updatePanel.Controls.Add(this.btnupdateCancel);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Location = new System.Drawing.Point(177, 186);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(280, 318);
            this.updatePanel.TabIndex = 129;
            this.updatePanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(30, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 121;
            this.label7.Text = "Quantity";
            // 
            // txtUpdMat
            // 
            this.txtUpdMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUpdMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdMat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdMat.Location = new System.Drawing.Point(32, 107);
            this.txtUpdMat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdMat.Multiline = true;
            this.txtUpdMat.Name = "txtUpdMat";
            this.txtUpdMat.Size = new System.Drawing.Size(216, 27);
            this.txtUpdMat.TabIndex = 119;
            // 
            // txtUpdQuan
            // 
            this.txtUpdQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUpdQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdQuan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdQuan.Location = new System.Drawing.Point(33, 167);
            this.txtUpdQuan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdQuan.Multiline = true;
            this.txtUpdQuan.Name = "txtUpdQuan";
            this.txtUpdQuan.Size = new System.Drawing.Size(216, 27);
            this.txtUpdQuan.TabIndex = 119;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label13.Location = new System.Drawing.Point(29, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Material";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(28, 38);
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
            this.btnupdateCancel.Location = new System.Drawing.Point(160, 230);
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
            this.btnUpdate.Location = new System.Drawing.Point(32, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Material";
            // 
            // dgv_Req
            // 
            this.dgv_Req.AllowUserToDeleteRows = false;
            this.dgv_Req.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Req.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_Req.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Req.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Req.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Req.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.Materials,
            this.MQuantity,
            this.Update,
            this.Delete});
            this.dgv_Req.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgv_Req.Location = new System.Drawing.Point(39, 117);
            this.dgv_Req.Name = "dgv_Req";
            this.dgv_Req.ReadOnly = true;
            this.dgv_Req.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Req.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Req.RowTemplate.Height = 35;
            this.dgv_Req.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Req.Size = new System.Drawing.Size(547, 433);
            this.dgv_Req.TabIndex = 128;
            this.dgv_Req.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Req_CellContentClick);
            // 
            // MID
            // 
            this.MID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MID.DataPropertyName = "MID";
            this.MID.HeaderText = "ID";
            this.MID.Name = "MID";
            this.MID.ReadOnly = true;
            // 
            // Materials
            // 
            this.Materials.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Materials.DataPropertyName = "Materials";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Materials.DefaultCellStyle = dataGridViewCellStyle9;
            this.Materials.HeaderText = "Materials";
            this.Materials.MinimumWidth = 6;
            this.Materials.Name = "Materials";
            this.Materials.ReadOnly = true;
            // 
            // MQuantity
            // 
            this.MQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MQuantity.DataPropertyName = "MQuantity";
            this.MQuantity.HeaderText = "Quantity";
            this.MQuantity.Name = "MQuantity";
            this.MQuantity.ReadOnly = true;
            // 
            // Update
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.Update.DefaultCellStyle = dataGridViewCellStyle10;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "UPDATE";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 120;
            // 
            // Delete
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle11;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "DELETE";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 120;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(498, 70);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 35);
            this.btnCreate.TabIndex = 130;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlReqUpdate
            // 
            this.pnlReqUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReqUpdate.Controls.Add(this.txtAddMate);
            this.pnlReqUpdate.Controls.Add(this.label5);
            this.pnlReqUpdate.Controls.Add(this.txtAddReqQuan);
            this.pnlReqUpdate.Controls.Add(this.label6);
            this.pnlReqUpdate.Controls.Add(this.lbRqSucess);
            this.pnlReqUpdate.Controls.Add(this.label9);
            this.pnlReqUpdate.Controls.Add(this.btnUpdReqCancel);
            this.pnlReqUpdate.Controls.Add(this.btnSend);
            this.pnlReqUpdate.Location = new System.Drawing.Point(693, 222);
            this.pnlReqUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReqUpdate.Name = "pnlReqUpdate";
            this.pnlReqUpdate.Size = new System.Drawing.Size(280, 318);
            this.pnlReqUpdate.TabIndex = 136;
            this.pnlReqUpdate.Visible = false;
            // 
            // txtAddMate
            // 
            this.txtAddMate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAddMate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddMate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMate.Location = new System.Drawing.Point(33, 108);
            this.txtAddMate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddMate.Multiline = true;
            this.txtAddMate.Name = "txtAddMate";
            this.txtAddMate.Size = new System.Drawing.Size(216, 27);
            this.txtAddMate.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(30, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Quantity";
            // 
            // txtAddReqQuan
            // 
            this.txtAddReqQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAddReqQuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddReqQuan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddReqQuan.Location = new System.Drawing.Point(33, 167);
            this.txtAddReqQuan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddReqQuan.Multiline = true;
            this.txtAddReqQuan.Name = "txtAddReqQuan";
            this.txtAddReqQuan.Size = new System.Drawing.Size(216, 27);
            this.txtAddReqQuan.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(29, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Material";
            // 
            // lbRqSucess
            // 
            this.lbRqSucess.AutoSize = true;
            this.lbRqSucess.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRqSucess.ForeColor = System.Drawing.Color.Blue;
            this.lbRqSucess.Location = new System.Drawing.Point(12, 9);
            this.lbRqSucess.Name = "lbRqSucess";
            this.lbRqSucess.Size = new System.Drawing.Size(46, 13);
            this.lbRqSucess.TabIndex = 64;
            this.lbRqSucess.Text = "Success";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(28, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 27);
            this.label9.TabIndex = 63;
            this.label9.Text = "Update";
            // 
            // btnUpdReqCancel
            // 
            this.btnUpdReqCancel.BackColor = System.Drawing.Color.White;
            this.btnUpdReqCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdReqCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdReqCancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdReqCancel.Location = new System.Drawing.Point(160, 230);
            this.btnUpdReqCancel.Name = "btnUpdReqCancel";
            this.btnUpdReqCancel.Size = new System.Drawing.Size(88, 35);
            this.btnUpdReqCancel.TabIndex = 57;
            this.btnUpdReqCancel.Text = "CANCEL";
            this.btnUpdReqCancel.UseVisualStyleBackColor = false;
            this.btnUpdReqCancel.Click += new System.EventHandler(this.btnUpdReqCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(32, 230);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 35);
            this.btnSend.TabIndex = 62;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvIntReq
            // 
            this.dgvIntReq.AllowUserToDeleteRows = false;
            this.dgvIntReq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvIntReq.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgvIntReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvIntReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RID,
            this.Rmaterials,
            this.RQuantity,
            this.dataGridViewButtonColumn1});
            this.dgvIntReq.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dgvIntReq.Location = new System.Drawing.Point(618, 143);
            this.dgvIntReq.Name = "dgvIntReq";
            this.dgvIntReq.ReadOnly = true;
            this.dgvIntReq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvIntReq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvIntReq.RowTemplate.Height = 35;
            this.dgvIntReq.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntReq.Size = new System.Drawing.Size(416, 407);
            this.dgvIntReq.TabIndex = 135;
            this.dgvIntReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntReq_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(665, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 24);
            this.label4.TabIndex = 137;
            this.label4.Text = "Incoming Inventory Requests";
            // 
            // cmbWorkshop
            // 
            this.cmbWorkshop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWorkshop.FormattingEnabled = true;
            this.cmbWorkshop.Location = new System.Drawing.Point(818, 116);
            this.cmbWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbWorkshop.Name = "cmbWorkshop";
            this.cmbWorkshop.Size = new System.Drawing.Size(216, 21);
            this.cmbWorkshop.TabIndex = 138;
            this.cmbWorkshop.SelectedIndexChanged += new System.EventHandler(this.cmbWorkshop_SelectedIndexChanged);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(37, 102);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(51, 12);
            this.lblErrorName.TabIndex = 139;
            this.lblErrorName.Text = "Error Name";
            // 
            // lblErrQuan
            // 
            this.lblErrQuan.AutoSize = true;
            this.lblErrQuan.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrQuan.ForeColor = System.Drawing.Color.Red;
            this.lblErrQuan.Location = new System.Drawing.Point(270, 102);
            this.lblErrQuan.Name = "lblErrQuan";
            this.lblErrQuan.Size = new System.Drawing.Size(60, 12);
            this.lblErrQuan.TabIndex = 140;
            this.lblErrQuan.Text = "Error Quantity";
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucces.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSucces.Location = new System.Drawing.Point(34, 21);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(64, 21);
            this.lblSucces.TabIndex = 141;
            this.lblSucces.Text = "Success";
            // 
            // txtMaterial
            // 
            this.txtMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterial.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.Location = new System.Drawing.Point(39, 72);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaterial.Multiline = true;
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(198, 27);
            this.txtMaterial.TabIndex = 133;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label10.Location = new System.Drawing.Point(718, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 142;
            this.label10.Text = "Sort by Workshop";
            // 
            // RID
            // 
            this.RID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RID.DataPropertyName = "ID";
            this.RID.HeaderText = "ID";
            this.RID.Name = "RID";
            this.RID.ReadOnly = true;
            // 
            // Rmaterials
            // 
            this.Rmaterials.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rmaterials.DataPropertyName = "Materials";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Rmaterials.DefaultCellStyle = dataGridViewCellStyle13;
            this.Rmaterials.HeaderText = "Materials";
            this.Rmaterials.MinimumWidth = 6;
            this.Rmaterials.Name = "Rmaterials";
            this.Rmaterials.ReadOnly = true;
            // 
            // RQuantity
            // 
            this.RQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RQuantity.DataPropertyName = "Quantity";
            this.RQuantity.HeaderText = "Quantity";
            this.RQuantity.Name = "RQuantity";
            this.RQuantity.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewButtonColumn1.FillWeight = 187.6289F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Add";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Text = "ADD";
            this.dataGridViewButtonColumn1.ToolTipText = "Add";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 600);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSucces);
            this.Controls.Add(this.lblErrQuan);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.cmbWorkshop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlReqUpdate);
            this.Controls.Add(this.dgvIntReq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Req);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWarehouse";
            this.Text = "frmWarehouse";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Req)).EndInit();
            this.pnlReqUpdate.ResumeLayout(false);
            this.pnlReqUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdQuan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUpdsucces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdateCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Req;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlReqUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddReqQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRqSucess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdReqCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView dgvIntReq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbWorkshop;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrQuan;
        private System.Windows.Forms.Label lblSucces;
        private System.Windows.Forms.TextBox txtUpdMat;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn MQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddMate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rmaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn RQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}