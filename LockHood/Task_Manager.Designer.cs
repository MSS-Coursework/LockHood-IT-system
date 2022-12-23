
namespace LockHood
{
    partial class Task_Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_HeadName = new System.Windows.Forms.ComboBox();
            this.cmb_Workshop = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_ErrorTask = new System.Windows.Forms.Label();
            this.lbl_ErrorDate = new System.Windows.Forms.Label();
            this.lbl_ErrorHead = new System.Windows.Forms.Label();
            this.lbl_ErrorWorkshop = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Search = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTaskToolStripMenuItem,
            this.addTaskToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // manageTaskToolStripMenuItem
            // 
            this.manageTaskToolStripMenuItem.Name = "manageTaskToolStripMenuItem";
            this.manageTaskToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.manageTaskToolStripMenuItem.Text = "Manage task";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addTaskToolStripMenuItem.Text = "Add task";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 220);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Task name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "department name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "workshop name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(15, 67);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 20);
            this.txt_Name.TabIndex = 9;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(12, 139);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 10;
            // 
            // cmb_HeadName
            // 
            this.cmb_HeadName.FormattingEnabled = true;
            this.cmb_HeadName.Location = new System.Drawing.Point(12, 222);
            this.cmb_HeadName.Name = "cmb_HeadName";
            this.cmb_HeadName.Size = new System.Drawing.Size(205, 21);
            this.cmb_HeadName.TabIndex = 11;
            this.cmb_HeadName.Leave += new System.EventHandler(this.cmb_HeadName_Leave);
            // 
            // cmb_Workshop
            // 
            this.cmb_Workshop.FormattingEnabled = true;
            this.cmb_Workshop.Location = new System.Drawing.Point(10, 312);
            this.cmb_Workshop.Name = "cmb_Workshop";
            this.cmb_Workshop.Size = new System.Drawing.Size(205, 21);
            this.cmb_Workshop.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(37, 389);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add task";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(118, 389);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(199, 389);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // lbl_ErrorTask
            // 
            this.lbl_ErrorTask.AutoSize = true;
            this.lbl_ErrorTask.Location = new System.Drawing.Point(12, 90);
            this.lbl_ErrorTask.Name = "lbl_ErrorTask";
            this.lbl_ErrorTask.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorTask.TabIndex = 16;
            this.lbl_ErrorTask.Text = "Error 1";
            // 
            // lbl_ErrorDate
            // 
            this.lbl_ErrorDate.AutoSize = true;
            this.lbl_ErrorDate.Location = new System.Drawing.Point(14, 173);
            this.lbl_ErrorDate.Name = "lbl_ErrorDate";
            this.lbl_ErrorDate.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorDate.TabIndex = 17;
            this.lbl_ErrorDate.Text = "Error 2";
            // 
            // lbl_ErrorHead
            // 
            this.lbl_ErrorHead.AutoSize = true;
            this.lbl_ErrorHead.Location = new System.Drawing.Point(12, 248);
            this.lbl_ErrorHead.Name = "lbl_ErrorHead";
            this.lbl_ErrorHead.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorHead.TabIndex = 18;
            this.lbl_ErrorHead.Text = "Error 3";
            // 
            // lbl_ErrorWorkshop
            // 
            this.lbl_ErrorWorkshop.AutoSize = true;
            this.lbl_ErrorWorkshop.Location = new System.Drawing.Point(9, 339);
            this.lbl_ErrorWorkshop.Name = "lbl_ErrorWorkshop";
            this.lbl_ErrorWorkshop.Size = new System.Drawing.Size(38, 13);
            this.lbl_ErrorWorkshop.TabIndex = 19;
            this.lbl_ErrorWorkshop.Text = "Error 4";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(713, 63);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Search
            // 
            this.cmb_Search.FormattingEnabled = true;
            this.cmb_Search.Location = new System.Drawing.Point(351, 63);
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.Size = new System.Drawing.Size(315, 21);
            this.cmb_Search.TabIndex = 22;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(308, 389);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 23;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Task_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.cmb_HeadName);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Task_Manager";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Task_Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.ComboBox cmb_HeadName;
        private System.Windows.Forms.ComboBox cmb_Workshop;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_ErrorTask;
        private System.Windows.Forms.Label lbl_ErrorDate;
        private System.Windows.Forms.Label lbl_ErrorHead;
        private System.Windows.Forms.Label lbl_ErrorWorkshop;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Search;
        private System.Windows.Forms.Button btn_Refresh;
    }
}