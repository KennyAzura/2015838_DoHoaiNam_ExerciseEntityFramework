
namespace usingADO.NET
{
    partial class ManageStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.gbDanhSachSV = new System.Windows.Forms.GroupBox();
            this.lvListStudent = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsXoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbDanhSachSV.SuspendLayout();
            this.ctmsXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnReload);
            this.splitContainer1.Panel1.Controls.Add(this.btnDefault);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.cboClass);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.lblClass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbDanhSachSV);
            this.splitContainer1.Size = new System.Drawing.Size(944, 557);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(463, 216);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 30);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(685, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(550, 163);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(104, 42);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(409, 163);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(98, 42);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "Mặc định";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(332, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(376, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(332, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(376, 22);
            this.txtID.TabIndex = 2;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(332, 36);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(376, 24);
            this.cboClass.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(128, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên sinh viên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(128, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(128, 36);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 17);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Lớp";
            // 
            // gbDanhSachSV
            // 
            this.gbDanhSachSV.Controls.Add(this.lvListStudent);
            this.gbDanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSachSV.Location = new System.Drawing.Point(0, 0);
            this.gbDanhSachSV.Name = "gbDanhSachSV";
            this.gbDanhSachSV.Size = new System.Drawing.Size(944, 286);
            this.gbDanhSachSV.TabIndex = 0;
            this.gbDanhSachSV.TabStop = false;
            this.gbDanhSachSV.Text = "Danh sách sinh viên";
            // 
            // lvListStudent
            // 
            this.lvListStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chHoTen,
            this.chLop});
            this.lvListStudent.ContextMenuStrip = this.ctmsXoa;
            this.lvListStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvListStudent.FullRowSelect = true;
            this.lvListStudent.GridLines = true;
            this.lvListStudent.HideSelection = false;
            this.lvListStudent.Location = new System.Drawing.Point(3, 18);
            this.lvListStudent.Name = "lvListStudent";
            this.lvListStudent.Size = new System.Drawing.Size(938, 265);
            this.lvListStudent.TabIndex = 0;
            this.lvListStudent.UseCompatibleStateImageBehavior = false;
            this.lvListStudent.View = System.Windows.Forms.View.Details;
            this.lvListStudent.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvListStudent_ItemSelectionChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 147;
            // 
            // chHoTen
            // 
            this.chHoTen.Text = "Họ và tên sinh viên";
            this.chHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHoTen.Width = 199;
            // 
            // chLop
            // 
            this.chLop.Text = "Lớp";
            this.chLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chLop.Width = 253;
            // 
            // ctmsXoa
            // 
            this.ctmsXoa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsXoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.ctmsXoa.Name = "ctmsXoa";
            this.ctmsXoa.Size = new System.Drawing.Size(211, 56);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(210, 24);
            this.tsmiDelete.Text = "Xóa";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 557);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ManageStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbDanhSachSV.ResumeLayout(false);
            this.ctmsXoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.GroupBox gbDanhSachSV;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvListStudent;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chHoTen;
        private System.Windows.Forms.ColumnHeader chLop;
        private System.Windows.Forms.ContextMenuStrip ctmsXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}

