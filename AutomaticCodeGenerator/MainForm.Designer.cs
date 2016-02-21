namespace AutomaticCodeGenerator
{
    partial class MainForm
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
            this.lblProjectLocation = new System.Windows.Forms.Label();
            this.groupBoxProjectInfo = new System.Windows.Forms.GroupBox();
            this.chkVPages = new System.Windows.Forms.CheckBox();
            this.grdColumns = new System.Windows.Forms.DataGridView();
            this.clmColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtProjectLocation = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.chkAdminPages = new System.Windows.Forms.CheckBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtDatabaseServer = new System.Windows.Forms.TextBox();
            this.chkClasses = new System.Windows.Forms.CheckBox();
            this.cmdBrowseProjectLocation = new System.Windows.Forms.Button();
            this.chkSp = new System.Windows.Forms.CheckBox();
            this.lblDatabaseServer = new System.Windows.Forms.Label();
            this.chkTable = new System.Windows.Forms.CheckBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblDatabaseUser = new System.Windows.Forms.Label();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtDatabaseUser = new System.Windows.Forms.TextBox();
            this.lblDatabasePassword = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.ddlTables = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogProjectLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxProjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).BeginInit();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectLocation
            // 
            this.lblProjectLocation.AutoSize = true;
            this.lblProjectLocation.Location = new System.Drawing.Point(13, 24);
            this.lblProjectLocation.Name = "lblProjectLocation";
            this.lblProjectLocation.Size = new System.Drawing.Size(84, 13);
            this.lblProjectLocation.TabIndex = 0;
            this.lblProjectLocation.Text = "Project Location";
            // 
            // groupBoxProjectInfo
            // 
            this.groupBoxProjectInfo.Controls.Add(this.chkVPages);
            this.groupBoxProjectInfo.Controls.Add(this.grdColumns);
            this.groupBoxProjectInfo.Controls.Add(this.txtProjectLocation);
            this.groupBoxProjectInfo.Controls.Add(this.txtTableName);
            this.groupBoxProjectInfo.Controls.Add(this.chkAdminPages);
            this.groupBoxProjectInfo.Controls.Add(this.lblTableName);
            this.groupBoxProjectInfo.Controls.Add(this.txtDatabaseServer);
            this.groupBoxProjectInfo.Controls.Add(this.chkClasses);
            this.groupBoxProjectInfo.Controls.Add(this.lblProjectLocation);
            this.groupBoxProjectInfo.Controls.Add(this.cmdBrowseProjectLocation);
            this.groupBoxProjectInfo.Controls.Add(this.chkSp);
            this.groupBoxProjectInfo.Controls.Add(this.lblDatabaseServer);
            this.groupBoxProjectInfo.Controls.Add(this.chkTable);
            this.groupBoxProjectInfo.Controls.Add(this.txtDatabaseName);
            this.groupBoxProjectInfo.Controls.Add(this.lblDatabaseUser);
            this.groupBoxProjectInfo.Controls.Add(this.txtDatabasePassword);
            this.groupBoxProjectInfo.Controls.Add(this.lblDatabaseName);
            this.groupBoxProjectInfo.Controls.Add(this.txtDatabaseUser);
            this.groupBoxProjectInfo.Controls.Add(this.lblDatabasePassword);
            this.groupBoxProjectInfo.Location = new System.Drawing.Point(6, 100);
            this.groupBoxProjectInfo.Name = "groupBoxProjectInfo";
            this.groupBoxProjectInfo.Size = new System.Drawing.Size(685, 486);
            this.groupBoxProjectInfo.TabIndex = 0;
            this.groupBoxProjectInfo.TabStop = false;
            this.groupBoxProjectInfo.Text = "Output";
            // 
            // chkVPages
            // 
            this.chkVPages.AutoSize = true;
            this.chkVPages.Checked = true;
            this.chkVPages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVPages.Location = new System.Drawing.Point(447, 456);
            this.chkVPages.Name = "chkVPages";
            this.chkVPages.Size = new System.Drawing.Size(86, 17);
            this.chkVPages.TabIndex = 6;
            this.chkVPages.Text = "Viewer Page";
            this.chkVPages.UseVisualStyleBackColor = true;
            // 
            // grdColumns
            // 
            this.grdColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmColumnName,
            this.clmDataType,
            this.clmSize,
            this.PrimaryKey});
            this.grdColumns.Location = new System.Drawing.Point(9, 125);
            this.grdColumns.Name = "grdColumns";
            this.grdColumns.Size = new System.Drawing.Size(670, 315);
            this.grdColumns.TabIndex = 2;
            // 
            // clmColumnName
            // 
            this.clmColumnName.HeaderText = "Column Name";
            this.clmColumnName.Name = "clmColumnName";
            this.clmColumnName.Width = 320;
            // 
            // clmDataType
            // 
            this.clmDataType.HeaderText = "Data Type";
            this.clmDataType.Items.AddRange(new object[] {
            "int",
            "char",
            "float",
            "DateTime",
            "varchar",
            "nvarchar",
            "ntext"});
            this.clmDataType.Name = "clmDataType";
            // 
            // clmSize
            // 
            this.clmSize.HeaderText = "Size";
            this.clmSize.Name = "clmSize";
            this.clmSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.HeaderText = "Primary Key";
            this.PrimaryKey.Name = "PrimaryKey";
            // 
            // txtProjectLocation
            // 
            this.txtProjectLocation.Location = new System.Drawing.Point(103, 21);
            this.txtProjectLocation.Name = "txtProjectLocation";
            this.txtProjectLocation.Size = new System.Drawing.Size(477, 20);
            this.txtProjectLocation.TabIndex = 1;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(103, 99);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(221, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // chkAdminPages
            // 
            this.chkAdminPages.AutoSize = true;
            this.chkAdminPages.Checked = true;
            this.chkAdminPages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdminPages.Location = new System.Drawing.Point(353, 456);
            this.chkAdminPages.Name = "chkAdminPages";
            this.chkAdminPages.Size = new System.Drawing.Size(88, 17);
            this.chkAdminPages.TabIndex = 5;
            this.chkAdminPages.Text = "Admin Pages";
            this.chkAdminPages.UseVisualStyleBackColor = true;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(32, 102);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(65, 13);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table Name";
            // 
            // txtDatabaseServer
            // 
            this.txtDatabaseServer.Location = new System.Drawing.Point(103, 47);
            this.txtDatabaseServer.Name = "txtDatabaseServer";
            this.txtDatabaseServer.Size = new System.Drawing.Size(221, 20);
            this.txtDatabaseServer.TabIndex = 3;
            // 
            // chkClasses
            // 
            this.chkClasses.AutoSize = true;
            this.chkClasses.Checked = true;
            this.chkClasses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClasses.Location = new System.Drawing.Point(285, 456);
            this.chkClasses.Name = "chkClasses";
            this.chkClasses.Size = new System.Drawing.Size(62, 17);
            this.chkClasses.TabIndex = 4;
            this.chkClasses.Text = "Classes";
            this.chkClasses.UseVisualStyleBackColor = true;
            // 
            // cmdBrowseProjectLocation
            // 
            this.cmdBrowseProjectLocation.Location = new System.Drawing.Point(586, 19);
            this.cmdBrowseProjectLocation.Name = "cmdBrowseProjectLocation";
            this.cmdBrowseProjectLocation.Size = new System.Drawing.Size(93, 22);
            this.cmdBrowseProjectLocation.TabIndex = 7;
            this.cmdBrowseProjectLocation.Text = "&Browse";
            this.cmdBrowseProjectLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdBrowseProjectLocation.UseVisualStyleBackColor = true;
            this.cmdBrowseProjectLocation.Click += new System.EventHandler(this.cmdBrowseProjectLocation_Click);
            // 
            // chkSp
            // 
            this.chkSp.AutoSize = true;
            this.chkSp.Checked = true;
            this.chkSp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSp.Location = new System.Drawing.Point(165, 456);
            this.chkSp.Name = "chkSp";
            this.chkSp.Size = new System.Drawing.Size(114, 17);
            this.chkSp.TabIndex = 3;
            this.chkSp.Text = "Stored Procedures";
            this.chkSp.UseVisualStyleBackColor = true;
            // 
            // lblDatabaseServer
            // 
            this.lblDatabaseServer.AutoSize = true;
            this.lblDatabaseServer.Location = new System.Drawing.Point(10, 50);
            this.lblDatabaseServer.Name = "lblDatabaseServer";
            this.lblDatabaseServer.Size = new System.Drawing.Size(87, 13);
            this.lblDatabaseServer.TabIndex = 2;
            this.lblDatabaseServer.Text = "Database Server";
            // 
            // chkTable
            // 
            this.chkTable.AutoSize = true;
            this.chkTable.Checked = true;
            this.chkTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTable.Location = new System.Drawing.Point(106, 456);
            this.chkTable.Name = "chkTable";
            this.chkTable.Size = new System.Drawing.Size(53, 17);
            this.chkTable.TabIndex = 2;
            this.chkTable.Text = "Table";
            this.chkTable.UseVisualStyleBackColor = true;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(458, 47);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(221, 20);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // lblDatabaseUser
            // 
            this.lblDatabaseUser.AutoSize = true;
            this.lblDatabaseUser.Location = new System.Drawing.Point(19, 76);
            this.lblDatabaseUser.Name = "lblDatabaseUser";
            this.lblDatabaseUser.Size = new System.Drawing.Size(78, 13);
            this.lblDatabaseUser.TabIndex = 2;
            this.lblDatabaseUser.Text = "Database User";
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.Location = new System.Drawing.Point(458, 73);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.PasswordChar = '*';
            this.txtDatabasePassword.Size = new System.Drawing.Size(221, 20);
            this.txtDatabasePassword.TabIndex = 3;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(368, 50);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(84, 13);
            this.lblDatabaseName.TabIndex = 2;
            this.lblDatabaseName.Text = "Database Name";
            // 
            // txtDatabaseUser
            // 
            this.txtDatabaseUser.Location = new System.Drawing.Point(103, 73);
            this.txtDatabaseUser.Name = "txtDatabaseUser";
            this.txtDatabaseUser.Size = new System.Drawing.Size(221, 20);
            this.txtDatabaseUser.TabIndex = 3;
            // 
            // lblDatabasePassword
            // 
            this.lblDatabasePassword.AutoSize = true;
            this.lblDatabasePassword.Location = new System.Drawing.Point(350, 76);
            this.lblDatabasePassword.Name = "lblDatabasePassword";
            this.lblDatabasePassword.Size = new System.Drawing.Size(102, 13);
            this.lblDatabasePassword.TabIndex = 2;
            this.lblDatabasePassword.Text = "Database Password";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.txtLog);
            this.groupBoxMain.Controls.Add(this.cmdExit);
            this.groupBoxMain.Controls.Add(this.cmdClear);
            this.groupBoxMain.Controls.Add(this.cmdGenerate);
            this.groupBoxMain.Controls.Add(this.groupBoxInput);
            this.groupBoxMain.Controls.Add(this.groupBoxProjectInfo);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(1028, 638);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(697, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(325, 613);
            this.txtLog.TabIndex = 10;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(598, 592);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(93, 40);
            this.cmdExit.TabIndex = 9;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(499, 592);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(93, 40);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "&Clear";
            this.cmdClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(400, 592);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(93, 40);
            this.cmdGenerate.TabIndex = 7;
            this.cmdGenerate.Text = "&Generate";
            this.cmdGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.ddlTables);
            this.groupBoxInput.Controls.Add(this.txtFileName);
            this.groupBoxInput.Controls.Add(this.lblFileName);
            this.groupBoxInput.Controls.Add(this.lblSelectTable);
            this.groupBoxInput.Controls.Add(this.cmdBrowse);
            this.groupBoxInput.Location = new System.Drawing.Point(6, 15);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(685, 79);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // ddlTables
            // 
            this.ddlTables.FormattingEnabled = true;
            this.ddlTables.Location = new System.Drawing.Point(92, 45);
            this.ddlTables.Name = "ddlTables";
            this.ddlTables.Size = new System.Drawing.Size(221, 21);
            this.ddlTables.TabIndex = 8;
            this.ddlTables.SelectedIndexChanged += new System.EventHandler(this.ddlTables_SelectedIndexChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(92, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(488, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(36, 22);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(50, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Input File";
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Location = new System.Drawing.Point(19, 48);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(66, 13);
            this.lblSelectTable.TabIndex = 0;
            this.lblSelectTable.Text = "Select Entity";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(586, 17);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(93, 22);
            this.cmdBrowse.TabIndex = 7;
            this.cmdBrowse.Text = "&Browse";
            this.cmdBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.DefaultExt = "jpg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 662);
            this.Controls.Add(this.groupBoxMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Code Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxProjectInfo.ResumeLayout(false);
            this.groupBoxProjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).EndInit();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProjectLocation;
        private System.Windows.Forms.GroupBox groupBoxProjectInfo;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.TextBox txtProjectLocation;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView grdColumns;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkVPages;
        private System.Windows.Forms.CheckBox chkAdminPages;
        private System.Windows.Forms.CheckBox chkClasses;
        private System.Windows.Forms.CheckBox chkSp;
        private System.Windows.Forms.CheckBox chkTable;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.ComboBox ddlTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrimaryKey;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.TextBox txtDatabaseUser;
        private System.Windows.Forms.TextBox txtDatabaseServer;
        private System.Windows.Forms.Label lblDatabasePassword;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Label lblDatabaseUser;
        private System.Windows.Forms.Label lblDatabaseServer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogProjectLocation;
        private System.Windows.Forms.Button cmdBrowseProjectLocation;
        private System.Windows.Forms.Label lblSelectTable;
    }
}