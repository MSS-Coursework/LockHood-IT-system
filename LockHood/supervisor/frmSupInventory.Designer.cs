namespace LockHood
{
    partial class frmSupInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRequestInvent = new System.Windows.Forms.Button();
            this.cmbInventory = new System.Windows.Forms.ComboBox();
            this.txtMaterialQuant = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRequestInvent
            // 
            this.btnRequestInvent.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRequestInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestInvent.FlatAppearance.BorderSize = 0;
            this.btnRequestInvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestInvent.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestInvent.ForeColor = System.Drawing.Color.White;
            this.btnRequestInvent.Location = new System.Drawing.Point(115, 329);
            this.btnRequestInvent.Name = "btnRequestInvent";
            this.btnRequestInvent.Size = new System.Drawing.Size(334, 52);
            this.btnRequestInvent.TabIndex = 41;
            this.btnRequestInvent.Text = "REQUEST";
            this.btnRequestInvent.UseVisualStyleBackColor = false;
            // 
            // cmbInventory
            // 
            this.cmbInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cmbInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInventory.FormattingEnabled = true;
            this.cmbInventory.ItemHeight = 13;
            this.cmbInventory.Location = new System.Drawing.Point(115, 120);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(334, 21);
            this.cmbInventory.TabIndex = 42;
            // 
            // txtMaterialQuant
            // 
            this.txtMaterialQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMaterialQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterialQuant.Location = new System.Drawing.Point(115, 236);
            this.txtMaterialQuant.Multiline = true;
            this.txtMaterialQuant.Name = "txtMaterialQuant";
            this.txtMaterialQuant.Size = new System.Drawing.Size(138, 31);
            this.txtMaterialQuant.TabIndex = 43;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblEmail.Location = new System.Drawing.Point(110, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 30);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Materials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(110, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 45;
            this.label1.Text = "Quantity";
            // 
            // frmSupInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMaterialQuant);
            this.Controls.Add(this.cmbInventory);
            this.Controls.Add(this.btnRequestInvent);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSupInventory";
            this.Text = "frmSupInventory";
            this.Load += new System.EventHandler(this.frmSupInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRequestInvent;
        private System.Windows.Forms.ComboBox cmbInventory;
        private System.Windows.Forms.TextBox txtMaterialQuant;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
    }
}