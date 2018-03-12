namespace GameDataSwitcher
{
    partial class AboutBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOJBK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGithub = new System.Windows.Forms.Button();
            this.buttonPatron = new System.Windows.Forms.Button();
            this.buttonForum = new System.Windows.Forms.Button();
            this.buttonSpaceDock = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOJBK
            // 
            this.buttonOJBK.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOJBK.Location = new System.Drawing.Point(334, 371);
            this.buttonOJBK.Name = "buttonOJBK";
            this.buttonOJBK.Size = new System.Drawing.Size(231, 42);
            this.buttonOJBK.TabIndex = 1;
            this.buttonOJBK.Text = "OK";
            this.buttonOJBK.UseVisualStyleBackColor = true;
            this.buttonOJBK.Click += new System.EventHandler(this.buttonOJBK_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 204);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(330, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "GDS - GameData Switcher";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(423, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "VX.X.X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGithub
            // 
            this.buttonGithub.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGithub.Location = new System.Drawing.Point(334, 81);
            this.buttonGithub.Name = "buttonGithub";
            this.buttonGithub.Size = new System.Drawing.Size(231, 42);
            this.buttonGithub.TabIndex = 5;
            this.buttonGithub.Text = "GitHub Source";
            this.buttonGithub.UseVisualStyleBackColor = true;
            this.buttonGithub.Click += new System.EventHandler(this.buttonGithub_Click);
            // 
            // buttonPatron
            // 
            this.buttonPatron.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPatron.Location = new System.Drawing.Point(334, 275);
            this.buttonPatron.Name = "buttonPatron";
            this.buttonPatron.Size = new System.Drawing.Size(231, 42);
            this.buttonPatron.TabIndex = 6;
            this.buttonPatron.Text = "Patreon";
            this.buttonPatron.UseVisualStyleBackColor = true;
            this.buttonPatron.Click += new System.EventHandler(this.buttonPatron_Click);
            // 
            // buttonForum
            // 
            this.buttonForum.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonForum.Location = new System.Drawing.Point(334, 129);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Size = new System.Drawing.Size(231, 42);
            this.buttonForum.TabIndex = 7;
            this.buttonForum.Text = "Forum Page";
            this.buttonForum.UseVisualStyleBackColor = true;
            this.buttonForum.Click += new System.EventHandler(this.buttonForum_Click);
            // 
            // buttonSpaceDock
            // 
            this.buttonSpaceDock.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSpaceDock.Location = new System.Drawing.Point(334, 178);
            this.buttonSpaceDock.Name = "buttonSpaceDock";
            this.buttonSpaceDock.Size = new System.Drawing.Size(231, 42);
            this.buttonSpaceDock.TabIndex = 8;
            this.buttonSpaceDock.Text = "SpaceDock";
            this.buttonSpaceDock.UseVisualStyleBackColor = true;
            this.buttonSpaceDock.Click += new System.EventHandler(this.buttonSpaceDock_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReport.Location = new System.Drawing.Point(334, 227);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(231, 42);
            this.buttonReport.TabIndex = 9;
            this.buttonReport.Text = "Report an Issue";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 428);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonSpaceDock);
            this.Controls.Add(this.buttonForum);
            this.Controls.Add(this.buttonPatron);
            this.Controls.Add(this.buttonGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOJBK);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOJBK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGithub;
        private System.Windows.Forms.Button buttonPatron;
        private System.Windows.Forms.Button buttonForum;
        private System.Windows.Forms.Button buttonSpaceDock;
        private System.Windows.Forms.Button buttonReport;
    }
}
