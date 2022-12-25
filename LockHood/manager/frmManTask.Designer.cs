
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Search = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_ErrorWorkshop = new System.Windows.Forms.Label();
            this.lbl_ErrorHead = new System.Windows.Forms.Label();
            this.lbl_ErrorDate = new System.Windows.Forms.Label();
            this.lbl_ErrorTask = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Workshop = new System.Windows.Forms.ComboBox();
            this.cmb_DepName = new System.Windows.Forms.ComboBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(363, 405);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 42;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Search
            // 
            this.cmb_Search.FormattingEnabled = true;
            this.cmb_Search.Location = new System.Drawing.Point(406, 79);
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.Size = new System.Drawing.Size(315, 21);
            this.cmb_Search.TabIndex = 41;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(768, 79);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 40;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_ErrorWorkshop
            // 
            this.lbl_ErrorWorkshop.AutoSize = true;
            this.lbl_ErrorWorkshop.Location = new System.Drawing.Point(64, 355);
            this.lbl_ErrorWorkshop.Name = "lbl_ErrorWorkshop";
            this.lbl_ErrorWorkshop.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorWorkshop.TabIndex = 39;
            this.lbl_ErrorWorkshop.Text = "Error 4";
            // 
            // lbl_ErrorHead
            // 
            this.lbl_ErrorHead.AutoSize = true;
            this.lbl_ErrorHead.Location = new System.Drawing.Point(67, 264);
            this.lbl_ErrorHead.Name = "lbl_ErrorHead";
            this.lbl_ErrorHead.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorHead.TabIndex = 38;
            this.lbl_ErrorHead.Text = "Error 3";
            // 
            // lbl_ErrorDate
            // 
            this.lbl_ErrorDate.AutoSize = true;
            this.lbl_ErrorDate.Location = new System.Drawing.Point(69, 189);
            this.lbl_ErrorDate.Name = "lbl_ErrorDate";
            this.lbl_ErrorDate.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorDate.TabIndex = 37;
            this.lbl_ErrorDate.Text = "Error 2";
            // 
            // lbl_ErrorTask
            // 
            this.lbl_ErrorTask.AutoSize = true;
            this.lbl_ErrorTask.Location = new System.Drawing.Point(67, 106);
            this.lbl_ErrorTask.Name = "lbl_ErrorTask";
            this.lbl_ErrorTask.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorTask.TabIndex = 36;
            this.lbl_ErrorTask.Text = "Error 1";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(254, 405);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 35;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(173, 405);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 34;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(92, 405);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 33;
            this.btn_Add.Text = "Add task";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmb_Workshop
            // 
            this.cmb_Workshop.FormattingEnabled = true;
            this.cmb_Workshop.Location = new System.Drawing.Point(65, 328);
            this.cmb_Workshop.Name = "cmb_Workshop";
            this.cmb_Workshop.Size = new System.Drawing.Size(205, 21);
            this.cmb_Workshop.TabIndex = 32;
            // 
            // cmb_DepName
            // 
            this.cmb_DepName.FormattingEnabled = true;
            this.cmb_DepName.Location = new System.Drawing.Point(67, 238);
            this.cmb_DepName.Name = "cmb_DepName";
            this.cmb_DepName.Size = new System.Drawing.Size(205, 21);
            this.cmb_DepName.TabIndex = 31;
            this.cmb_DepName.Leave += new System.EventHandler(this.cmb_DepName_Leave);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(67, 155);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 30;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(70, 83);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 20);
            this.txt_Name.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "workshop name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "department name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Task name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 220);
            this.dataGridView1.TabIndex = 24;
            // 
            // frmManTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 625);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_ErrorWorkshop);
            this.Controls.Add(this.lbl_ErrorHead);
            this.Controls.Add(this.lbl_ErrorDate);
            this.Controls.Add(this.lbl_ErrorTask);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_Workshop);
            this.Controls.Add(this.cmb_DepName);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManTask";
            this.Text = "frmManTask";
            this.Load += new System.EventHandler(this.frmManTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_ErrorWorkshop;
        private System.Windows.Forms.Label lbl_ErrorHead;
        private System.Windows.Forms.Label lbl_ErrorDate;
        private System.Windows.Forms.Label lbl_ErrorTask;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_Workshop;
        private System.Windows.Forms.ComboBox cmb_DepName;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}