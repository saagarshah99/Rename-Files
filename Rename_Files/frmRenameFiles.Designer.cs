namespace Rename_Files
{
    partial class frmRenameFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenameFiles));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMainText = new System.Windows.Forms.TextBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOriginalExt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewExtension = new System.Windows.Forms.TextBox();
            this.chkSameAsOriginal = new System.Windows.Forms.CheckBox();
            this.btnDeleteFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Text:";
            // 
            // txtMainText
            // 
            this.txtMainText.Location = new System.Drawing.Point(107, 10);
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.Size = new System.Drawing.Size(266, 20);
            this.txtMainText.TabIndex = 0;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(274, 60);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(99, 23);
            this.btnOpenFileDialog.TabIndex = 5;
            this.btnOpenFileDialog.Text = "Browse Directory";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(16, 62);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(252, 20);
            this.txtDirectoryPath.TabIndex = 4;
            this.txtDirectoryPath.TextChanged += new System.EventHandler(this.txtDirectoryPath_TextChanged);
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Location = new System.Drawing.Point(16, 88);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(85, 23);
            this.btnRenameFiles.TabIndex = 6;
            this.btnRenameFiles.Text = "Rename Files";
            this.btnRenameFiles.UseVisualStyleBackColor = true;
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(188, 89);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Original Extension:";
            // 
            // txtOriginalExt
            // 
            this.txtOriginalExt.Location = new System.Drawing.Point(107, 36);
            this.txtOriginalExt.Name = "txtOriginalExt";
            this.txtOriginalExt.Size = new System.Drawing.Size(49, 20);
            this.txtOriginalExt.TabIndex = 1;
            this.txtOriginalExt.TextChanged += new System.EventHandler(this.txtOriginalExt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New Extension:";
            // 
            // txtNewExtension
            // 
            this.txtNewExtension.Location = new System.Drawing.Point(265, 36);
            this.txtNewExtension.Name = "txtNewExtension";
            this.txtNewExtension.Size = new System.Drawing.Size(49, 20);
            this.txtNewExtension.TabIndex = 2;
            this.txtNewExtension.TextChanged += new System.EventHandler(this.txtNewExtension_TextChanged);
            // 
            // chkSameAsOriginal
            // 
            this.chkSameAsOriginal.AutoSize = true;
            this.chkSameAsOriginal.Location = new System.Drawing.Point(320, 38);
            this.chkSameAsOriginal.Name = "chkSameAsOriginal";
            this.chkSameAsOriginal.Size = new System.Drawing.Size(53, 17);
            this.chkSameAsOriginal.TabIndex = 3;
            this.chkSameAsOriginal.Text = "Same";
            this.chkSameAsOriginal.UseVisualStyleBackColor = true;
            this.chkSameAsOriginal.CheckedChanged += new System.EventHandler(this.chkSameAsOriginal_CheckedChanged);
            // 
            // btnDeleteFiles
            // 
            this.btnDeleteFiles.Location = new System.Drawing.Point(107, 89);
            this.btnDeleteFiles.Name = "btnDeleteFiles";
            this.btnDeleteFiles.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFiles.TabIndex = 7;
            this.btnDeleteFiles.Text = "Delete Files";
            this.btnDeleteFiles.UseVisualStyleBackColor = true;
            this.btnDeleteFiles.Click += new System.EventHandler(this.btnDeleteFiles_Click);
            // 
            // frmRenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 122);
            this.Controls.Add(this.btnDeleteFiles);
            this.Controls.Add(this.txtMainText);
            this.Controls.Add(this.txtOriginalExt);
            this.Controls.Add(this.txtNewExtension);
            this.Controls.Add(this.chkSameAsOriginal);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnRenameFiles);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 161);
            this.MinimumSize = new System.Drawing.Size(404, 161);
            this.Name = "frmRenameFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files";
            this.Load += new System.EventHandler(this.frmRenameFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMainText;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOriginalExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewExtension;
        private System.Windows.Forms.CheckBox chkSameAsOriginal;
        private System.Windows.Forms.Button btnDeleteFiles;
    }
}

