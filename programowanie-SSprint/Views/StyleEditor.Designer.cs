﻿namespace programowanie_SSprint
{
    partial class StyleEditor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Czerwony",
            "#ff0000"}, -1);
            this.lvStyles = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxEditArea = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBoxStyleList = new System.Windows.Forms.GroupBox();
            this.notificationPanel1 = new programowanie_SSprint.Views.HelperViews.NotificationPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEditArea.SuspendLayout();
            this.groupBoxStyleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvStyles
            // 
            this.lvStyles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStyles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName});
            this.lvStyles.FullRowSelect = true;
            this.lvStyles.GridLines = true;
            this.lvStyles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvStyles.Location = new System.Drawing.Point(3, 16);
            this.lvStyles.Name = "lvStyles";
            this.lvStyles.Size = new System.Drawing.Size(262, 179);
            this.lvStyles.TabIndex = 0;
            this.lvStyles.UseCompatibleStateImageBehavior = false;
            this.lvStyles.View = System.Windows.Forms.View.Details;
            this.lvStyles.SelectedIndexChanged += new System.EventHandler(this.lvStyles_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 47;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nazwa";
            this.columnHeaderName.Width = 171;
            // 
            // groupBoxEditArea
            // 
            this.groupBoxEditArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEditArea.Controls.Add(this.btnCancel);
            this.groupBoxEditArea.Controls.Add(this.tbID);
            this.groupBoxEditArea.Controls.Add(this.lID);
            this.groupBoxEditArea.Controls.Add(this.btnApplyChanges);
            this.groupBoxEditArea.Controls.Add(this.lName);
            this.groupBoxEditArea.Controls.Add(this.tbName);
            this.groupBoxEditArea.Location = new System.Drawing.Point(283, 46);
            this.groupBoxEditArea.Name = "groupBoxEditArea";
            this.groupBoxEditArea.Size = new System.Drawing.Size(211, 230);
            this.groupBoxEditArea.TabIndex = 0;
            this.groupBoxEditArea.TabStop = false;
            this.groupBoxEditArea.Text = "Edycja zaznaczonego stylu";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(6, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID.Location = new System.Drawing.Point(33, 60);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(160, 20);
            this.tbID.TabIndex = 7;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(6, 63);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 13);
            this.lID.TabIndex = 6;
            this.lID.Text = "ID:";
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyChanges.BackColor = System.Drawing.Color.LightGreen;
            this.btnApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplyChanges.Location = new System.Drawing.Point(6, 201);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(199, 23);
            this.btnApplyChanges.TabIndex = 2;
            this.btnApplyChanges.Text = "Zapisz zmiany";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lName.Location = new System.Drawing.Point(6, 37);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(49, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Nazwa:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(61, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(132, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(6, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Location = new System.Drawing.Point(184, 201);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Dodaj nowy";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // groupBoxStyleList
            // 
            this.groupBoxStyleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStyleList.Controls.Add(this.lvStyles);
            this.groupBoxStyleList.Controls.Add(this.btnDelete);
            this.groupBoxStyleList.Controls.Add(this.btnAddNew);
            this.groupBoxStyleList.Location = new System.Drawing.Point(12, 46);
            this.groupBoxStyleList.Name = "groupBoxStyleList";
            this.groupBoxStyleList.Size = new System.Drawing.Size(265, 230);
            this.groupBoxStyleList.TabIndex = 7;
            this.groupBoxStyleList.TabStop = false;
            this.groupBoxStyleList.Text = "Lista wprowadzonych styli";
            // 
            // notificationPanel1
            // 
            this.notificationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationPanel1.BackColor = System.Drawing.Color.White;
            this.notificationPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationPanel1.Location = new System.Drawing.Point(15, 12);
            this.notificationPanel1.MinimumSize = new System.Drawing.Size(245, 20);
            this.notificationPanel1.Name = "notificationPanel1";
            this.notificationPanel1.NotificationTime = 6000;
            this.notificationPanel1.Size = new System.Drawing.Size(479, 28);
            this.notificationPanel1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StyleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 288);
            this.Controls.Add(this.notificationPanel1);
            this.Controls.Add(this.groupBoxEditArea);
            this.Controls.Add(this.groupBoxStyleList);
            this.MinimumSize = new System.Drawing.Size(483, 258);
            this.Name = "StyleEditor";
            this.Text = "Edytor styli";
            this.Load += new System.EventHandler(this.StyleEditor_Load);
            this.groupBoxEditArea.ResumeLayout(false);
            this.groupBoxEditArea.PerformLayout();
            this.groupBoxStyleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStyles;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.GroupBox groupBoxEditArea;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBoxStyleList;
        private Views.HelperViews.NotificationPanel notificationPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}