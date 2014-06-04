namespace rust_admintool
{
    partial class Form1
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
            this.fileUrlTxt = new System.Windows.Forms.TextBox();
            this.locateFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtDisplayMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fileUrlTxt
            // 
            this.fileUrlTxt.Location = new System.Drawing.Point(24, 21);
            this.fileUrlTxt.Name = "fileUrlTxt";
            this.fileUrlTxt.Size = new System.Drawing.Size(363, 20);
            this.fileUrlTxt.TabIndex = 0;
            // 
            // locateFileBtn
            // 
            this.locateFileBtn.Location = new System.Drawing.Point(415, 17);
            this.locateFileBtn.Name = "locateFileBtn";
            this.locateFileBtn.Size = new System.Drawing.Size(75, 23);
            this.locateFileBtn.TabIndex = 2;
            this.locateFileBtn.Text = "Locate File";
            this.locateFileBtn.UseVisualStyleBackColor = true;
            this.locateFileBtn.Click += new System.EventHandler(this.locateFileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtDisplayMessage
            // 
            this.txtDisplayMessage.Location = new System.Drawing.Point(24, 47);
            this.txtDisplayMessage.Name = "txtDisplayMessage";
            this.txtDisplayMessage.Size = new System.Drawing.Size(155, 136);
            this.txtDisplayMessage.TabIndex = 3;
            this.txtDisplayMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 261);
            this.Controls.Add(this.txtDisplayMessage);
            this.Controls.Add(this.locateFileBtn);
            this.Controls.Add(this.fileUrlTxt);
            this.Name = "Form1";
            this.Text = "Rust Autotyper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileUrlTxt;
        private System.Windows.Forms.Button locateFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox txtDisplayMessage;
    }
}

