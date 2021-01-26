namespace FabricModEasyDevelopmentProgram
{
    partial class FormNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNew));
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxPath = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "在此输入将新建的项目文件夹:";
            // 
            // TextboxPath
            // 
            this.TextboxPath.Location = new System.Drawing.Point(185, 12);
            this.TextboxPath.Name = "TextboxPath";
            this.TextboxPath.Size = new System.Drawing.Size(250, 21);
            this.TextboxPath.TabIndex = 2;
            this.TextboxPath.TextChanged += new System.EventHandler(this.TextboxPath_TextChanged);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(12, 41);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(167, 23);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "退出(&E)";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(185, 41);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(250, 23);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "关闭并返回到主页(&B)";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(441, 12);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(75, 23);
            this.ButtonDownload.TabIndex = 5;
            this.ButtonDownload.Text = "下载(&D)";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(441, 42);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(75, 23);
            this.ButtonHelp.TabIndex = 6;
            this.ButtonHelp.Text = "帮助(&H)";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 77);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonDownload);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.TextboxPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNew";
            this.Text = "新建";
            this.Load += new System.EventHandler(this.FormNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxPath;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.Button ButtonHelp;
    }
}