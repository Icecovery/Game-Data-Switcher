namespace GameDataSwitcher
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TestList = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListBox();
            this.SelectItem = new System.Windows.Forms.MaskedTextBox();
            this.GameDataDataInformation = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RenameOriginalName = new System.Windows.Forms.Button();
            this.ViewGameData = new System.Windows.Forms.Button();
            this.NewGameData = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SetAsDefault = new System.Windows.Forms.Button();
            this.KSP = new System.Windows.Forms.GroupBox();
            this.comboBoxWindow = new System.Windows.Forms.ComboBox();
            this.comboBoxHardware = new System.Windows.Forms.ComboBox();
            this.checkBoxExit = new System.Windows.Forms.CheckBox();
            this.checkBoxX64 = new System.Windows.Forms.CheckBox();
            this.LaunchKSP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteGameData = new System.Windows.Forms.Button();
            this.CloneGameData = new System.Windows.Forms.Button();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticBackupLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllBackupLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KSP.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAIssueToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportAIssueToolStripMenuItem
            // 
            this.reportAIssueToolStripMenuItem.Name = "reportAIssueToolStripMenuItem";
            this.reportAIssueToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.reportAIssueToolStripMenuItem.Text = "Report an Issue";
            this.reportAIssueToolStripMenuItem.Click += new System.EventHandler(this.reportAIssueToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // TestList
            // 
            this.TestList.AutoSize = true;
            this.TestList.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TestList.Location = new System.Drawing.Point(8, 40);
            this.TestList.Name = "TestList";
            this.TestList.Size = new System.Drawing.Size(233, 19);
            this.TestList.TabIndex = 0;
            this.TestList.Text = "Found GameData Folder(s):\r\n";
            this.TestList.Click += new System.EventHandler(this.TestList_Click);
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 19;
            this.List.Location = new System.Drawing.Point(12, 65);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(226, 384);
            this.List.TabIndex = 1;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // SelectItem
            // 
            this.SelectItem.Enabled = false;
            this.SelectItem.Location = new System.Drawing.Point(248, 65);
            this.SelectItem.Name = "SelectItem";
            this.SelectItem.ReadOnly = true;
            this.SelectItem.Size = new System.Drawing.Size(172, 25);
            this.SelectItem.TabIndex = 2;
            // 
            // GameDataDataInformation
            // 
            this.GameDataDataInformation.Culture = new System.Globalization.CultureInfo("");
            this.GameDataDataInformation.Enabled = false;
            this.GameDataDataInformation.Location = new System.Drawing.Point(248, 119);
            this.GameDataDataInformation.Name = "GameDataDataInformation";
            this.GameDataDataInformation.ReadOnly = true;
            this.GameDataDataInformation.Size = new System.Drawing.Size(172, 25);
            this.GameDataDataInformation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(244, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected GameData:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(244, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // RenameOriginalName
            // 
            this.RenameOriginalName.Enabled = false;
            this.RenameOriginalName.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RenameOriginalName.Location = new System.Drawing.Point(426, 97);
            this.RenameOriginalName.Name = "RenameOriginalName";
            this.RenameOriginalName.Size = new System.Drawing.Size(99, 48);
            this.RenameOriginalName.TabIndex = 6;
            this.RenameOriginalName.Text = "Rename";
            this.RenameOriginalName.UseVisualStyleBackColor = true;
            this.RenameOriginalName.Click += new System.EventHandler(this.RenameOriginalName_Click);
            // 
            // ViewGameData
            // 
            this.ViewGameData.Enabled = false;
            this.ViewGameData.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ViewGameData.Location = new System.Drawing.Point(426, 43);
            this.ViewGameData.Name = "ViewGameData";
            this.ViewGameData.Size = new System.Drawing.Size(99, 48);
            this.ViewGameData.TabIndex = 7;
            this.ViewGameData.Text = "View";
            this.ViewGameData.UseVisualStyleBackColor = true;
            this.ViewGameData.Click += new System.EventHandler(this.ViewGameData_Click);
            // 
            // NewGameData
            // 
            this.NewGameData.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewGameData.Location = new System.Drawing.Point(248, 206);
            this.NewGameData.Name = "NewGameData";
            this.NewGameData.Size = new System.Drawing.Size(277, 50);
            this.NewGameData.TabIndex = 8;
            this.NewGameData.Text = "Create New GD";
            this.NewGameData.UseVisualStyleBackColor = true;
            this.NewGameData.Click += new System.EventHandler(this.NewGameData_Click);
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Refresh.Location = new System.Drawing.Point(12, 462);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(226, 50);
            this.Refresh.TabIndex = 9;
            this.Refresh.TabStop = false;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // SetAsDefault
            // 
            this.SetAsDefault.Enabled = false;
            this.SetAsDefault.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetAsDefault.Location = new System.Drawing.Point(248, 152);
            this.SetAsDefault.Name = "SetAsDefault";
            this.SetAsDefault.Size = new System.Drawing.Size(277, 48);
            this.SetAsDefault.TabIndex = 10;
            this.SetAsDefault.Text = "Set as Default";
            this.SetAsDefault.UseVisualStyleBackColor = true;
            this.SetAsDefault.Click += new System.EventHandler(this.SetAsDefault_Click);
            // 
            // KSP
            // 
            this.KSP.Controls.Add(this.comboBoxWindow);
            this.KSP.Controls.Add(this.comboBoxHardware);
            this.KSP.Controls.Add(this.checkBoxExit);
            this.KSP.Controls.Add(this.checkBoxX64);
            this.KSP.Controls.Add(this.LaunchKSP);
            this.KSP.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KSP.Location = new System.Drawing.Point(244, 320);
            this.KSP.Name = "KSP";
            this.KSP.Size = new System.Drawing.Size(281, 193);
            this.KSP.TabIndex = 13;
            this.KSP.TabStop = false;
            this.KSP.Text = "LaunchKSP";
            // 
            // comboBoxWindow
            // 
            this.comboBoxWindow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWindow.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxWindow.FormattingEnabled = true;
            this.comboBoxWindow.Items.AddRange(new object[] {
            "Use Default Window Setting",
            "Window",
            "Borderless Window",
            "Full Screen"});
            this.comboBoxWindow.Location = new System.Drawing.Point(6, 119);
            this.comboBoxWindow.Name = "comboBoxWindow";
            this.comboBoxWindow.Size = new System.Drawing.Size(268, 27);
            this.comboBoxWindow.TabIndex = 20;
            // 
            // comboBoxHardware
            // 
            this.comboBoxHardware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHardware.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxHardware.FormattingEnabled = true;
            this.comboBoxHardware.Items.AddRange(new object[] {
            "No Hardware-accelerated",
            "Force Open GL",
            "Force Direct3D 9",
            "Force Direct3D 11"});
            this.comboBoxHardware.Location = new System.Drawing.Point(6, 82);
            this.comboBoxHardware.Name = "comboBoxHardware";
            this.comboBoxHardware.Size = new System.Drawing.Size(268, 27);
            this.comboBoxHardware.TabIndex = 19;
            // 
            // checkBoxExit
            // 
            this.checkBoxExit.AutoSize = true;
            this.checkBoxExit.Location = new System.Drawing.Point(109, 156);
            this.checkBoxExit.Name = "checkBoxExit";
            this.checkBoxExit.Size = new System.Drawing.Size(165, 23);
            this.checkBoxExit.TabIndex = 18;
            this.checkBoxExit.Text = "Exit after Launch";
            this.checkBoxExit.UseVisualStyleBackColor = true;
            // 
            // checkBoxX64
            // 
            this.checkBoxX64.AutoSize = true;
            this.checkBoxX64.Checked = true;
            this.checkBoxX64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX64.Location = new System.Drawing.Point(7, 156);
            this.checkBoxX64.Name = "checkBoxX64";
            this.checkBoxX64.Size = new System.Drawing.Size(59, 23);
            this.checkBoxX64.TabIndex = 13;
            this.checkBoxX64.Text = "x64";
            this.checkBoxX64.UseVisualStyleBackColor = true;
            // 
            // LaunchKSP
            // 
            this.LaunchKSP.Location = new System.Drawing.Point(4, 25);
            this.LaunchKSP.Name = "LaunchKSP";
            this.LaunchKSP.Size = new System.Drawing.Size(271, 50);
            this.LaunchKSP.TabIndex = 12;
            this.LaunchKSP.Text = "Launch KSP";
            this.LaunchKSP.UseVisualStyleBackColor = true;
            this.LaunchKSP.Click += new System.EventHandler(this.LaunchKSP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DeleteGameData
            // 
            this.DeleteGameData.Enabled = false;
            this.DeleteGameData.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteGameData.Location = new System.Drawing.Point(390, 263);
            this.DeleteGameData.Name = "DeleteGameData";
            this.DeleteGameData.Size = new System.Drawing.Size(135, 50);
            this.DeleteGameData.TabIndex = 15;
            this.DeleteGameData.Text = "Delete GD";
            this.DeleteGameData.UseVisualStyleBackColor = true;
            this.DeleteGameData.Click += new System.EventHandler(this.DeleteGameData_Click);
            // 
            // CloneGameData
            // 
            this.CloneGameData.Enabled = false;
            this.CloneGameData.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloneGameData.Location = new System.Drawing.Point(248, 263);
            this.CloneGameData.Name = "CloneGameData";
            this.CloneGameData.Size = new System.Drawing.Size(135, 50);
            this.CloneGameData.TabIndex = 16;
            this.CloneGameData.Text = "Clone GD";
            this.CloneGameData.UseVisualStyleBackColor = true;
            this.CloneGameData.Click += new System.EventHandler(this.CloneGameData_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticBackupLogToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteAllBackupLogsToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // automaticBackupLogToolStripMenuItem
            // 
            this.automaticBackupLogToolStripMenuItem.CheckOnClick = true;
            this.automaticBackupLogToolStripMenuItem.Name = "automaticBackupLogToolStripMenuItem";
            this.automaticBackupLogToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.automaticBackupLogToolStripMenuItem.Text = "Automatic backup log";
            this.automaticBackupLogToolStripMenuItem.Click += new System.EventHandler(this.automaticBackupLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 6);
            // 
            // deleteAllBackupLogsToolStripMenuItem
            // 
            this.deleteAllBackupLogsToolStripMenuItem.Name = "deleteAllBackupLogsToolStripMenuItem";
            this.deleteAllBackupLogsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.deleteAllBackupLogsToolStripMenuItem.Text = "Delete all backup logs";
            this.deleteAllBackupLogsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllBackupLogsToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 518);
            this.Controls.Add(this.CloneGameData);
            this.Controls.Add(this.DeleteGameData);
            this.Controls.Add(this.KSP);
            this.Controls.Add(this.SetAsDefault);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.NewGameData);
            this.Controls.Add(this.ViewGameData);
            this.Controls.Add(this.RenameOriginalName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameDataDataInformation);
            this.Controls.Add(this.SelectItem);
            this.Controls.Add(this.List);
            this.Controls.Add(this.TestList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GameData Switcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KSP.ResumeLayout(false);
            this.KSP.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestList;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.MaskedTextBox SelectItem;
        private System.Windows.Forms.MaskedTextBox GameDataDataInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RenameOriginalName;
        private System.Windows.Forms.Button ViewGameData;
        private System.Windows.Forms.Button NewGameData;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button SetAsDefault;
        private System.Windows.Forms.GroupBox KSP;
        private System.Windows.Forms.CheckBox checkBoxX64;
        private System.Windows.Forms.Button LaunchKSP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button DeleteGameData;
        private System.Windows.Forms.CheckBox checkBoxExit;
        private System.Windows.Forms.ToolStripMenuItem reportAIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBoxWindow;
        private System.Windows.Forms.ComboBox comboBoxHardware;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CloneGameData;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticBackupLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllBackupLogsToolStripMenuItem;
    }
}

