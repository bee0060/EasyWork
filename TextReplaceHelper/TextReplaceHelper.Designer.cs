namespace TextReplaceHelper
{
    partial class TextReplaceHelper
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.txtFindAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtReplaceAll = new System.Windows.Forms.Button();
            this.btnDefineOutput = new System.Windows.Forms.Button();
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplaceAs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(101, 12);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Source Directory";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Location = new System.Drawing.Point(125, 6);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(292, 21);
            this.txtSourceDirectory.TabIndex = 5;
            // 
            // txtFindAll
            // 
            this.txtFindAll.Location = new System.Drawing.Point(432, 39);
            this.txtFindAll.Name = "txtFindAll";
            this.txtFindAll.Size = new System.Drawing.Size(75, 21);
            this.txtFindAll.TabIndex = 6;
            this.txtFindAll.Text = "Find All";
            this.txtFindAll.UseVisualStyleBackColor = true;
            this.txtFindAll.Click += new System.EventHandler(this.txtFindAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Operation Result:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(125, 123);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(532, 244);
            this.txtOutput.TabIndex = 13;
            this.txtOutput.Text = "";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(12, 39);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(23, 12);
            this.lblReg.TabIndex = 15;
            this.lblReg.Text = "Reg";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(125, 39);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(292, 21);
            this.txtReg.TabIndex = 16;
            // 
            // txtReplaceAll
            // 
            this.txtReplaceAll.Location = new System.Drawing.Point(432, 66);
            this.txtReplaceAll.Name = "txtReplaceAll";
            this.txtReplaceAll.Size = new System.Drawing.Size(75, 21);
            this.txtReplaceAll.TabIndex = 17;
            this.txtReplaceAll.Text = "Replace All";
            this.txtReplaceAll.UseVisualStyleBackColor = true;
            this.txtReplaceAll.Click += new System.EventHandler(this.txtReplaceAll_Click);
            // 
            // btnDefineOutput
            // 
            this.btnDefineOutput.Location = new System.Drawing.Point(432, 6);
            this.btnDefineOutput.Name = "btnDefineOutput";
            this.btnDefineOutput.Size = new System.Drawing.Size(75, 21);
            this.btnDefineOutput.TabIndex = 18;
            this.btnDefineOutput.Text = "Browser";
            this.btnDefineOutput.UseVisualStyleBackColor = true;
            this.btnDefineOutput.Click += new System.EventHandler(this.btnDefineOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Replace As";
            // 
            // txtReplaceAs
            // 
            this.txtReplaceAs.Location = new System.Drawing.Point(125, 67);
            this.txtReplaceAs.Name = "txtReplaceAs";
            this.txtReplaceAs.Size = new System.Drawing.Size(292, 21);
            this.txtReplaceAs.TabIndex = 20;
            // 
            // TextReplaceHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 426);
            this.Controls.Add(this.txtReplaceAs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDefineOutput);
            this.Controls.Add(this.txtReplaceAll);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtFindAll);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.lblSource);
            this.Name = "TextReplaceHelper";
            this.Text = "TextReplaceHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button txtFindAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Button txtReplaceAll;
        private System.Windows.Forms.Button btnDefineOutput;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReplaceAs;
    }
}

