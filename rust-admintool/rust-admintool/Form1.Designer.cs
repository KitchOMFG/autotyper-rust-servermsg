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
            this.components = new System.ComponentModel.Container();
            this.fileUrlTxt = new System.Windows.Forms.TextBox();
            this.locateFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtDisplayMessage = new System.Windows.Forms.RichTextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.lineTimer = new System.Windows.Forms.Timer(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalSliderTxt = new System.Windows.Forms.Label();
            this.intervalSlider = new System.Windows.Forms.TrackBar();
            this.comboCycleTime = new System.Windows.Forms.ComboBox();
            this.repeatLabelText1 = new System.Windows.Forms.Label();
            this.repeatLabelText2 = new System.Windows.Forms.Label();
            this.cycleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.intervalSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // fileUrlTxt
            // 
            this.fileUrlTxt.Location = new System.Drawing.Point(138, 16);
            this.fileUrlTxt.Name = "fileUrlTxt";
            this.fileUrlTxt.Size = new System.Drawing.Size(352, 20);
            this.fileUrlTxt.TabIndex = 0;
            this.fileUrlTxt.Text = "File Path";
            // 
            // locateFileBtn
            // 
            this.locateFileBtn.Location = new System.Drawing.Point(27, 7);
            this.locateFileBtn.Name = "locateFileBtn";
            this.locateFileBtn.Size = new System.Drawing.Size(84, 37);
            this.locateFileBtn.TabIndex = 2;
            this.locateFileBtn.Text = "Select File";
            this.locateFileBtn.UseVisualStyleBackColor = true;
            this.locateFileBtn.Click += new System.EventHandler(this.locateFileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // txtDisplayMessage
            // 
            this.txtDisplayMessage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtDisplayMessage.Location = new System.Drawing.Point(24, 73);
            this.txtDisplayMessage.Name = "txtDisplayMessage";
            this.txtDisplayMessage.Size = new System.Drawing.Size(466, 280);
            this.txtDisplayMessage.TabIndex = 3;
            this.txtDisplayMessage.Text = "";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(536, 117);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(99, 49);
            this.runBtn.TabIndex = 4;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // lineTimer
            // 
            this.lineTimer.Interval = 5000;
            this.lineTimer.Tick += new System.EventHandler(this.lineTimer_Tick);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(536, 255);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(99, 47);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output text. Text will be output line by line";
            // 
            // intervalSliderTxt
            // 
            this.intervalSliderTxt.AutoSize = true;
            this.intervalSliderTxt.Location = new System.Drawing.Point(16, 394);
            this.intervalSliderTxt.Name = "intervalSliderTxt";
            this.intervalSliderTxt.Size = new System.Drawing.Size(179, 13);
            this.intervalSliderTxt.TabIndex = 8;
            this.intervalSliderTxt.Text = "A line of text is sent every 5 seconds";
            // 
            // intervalSlider
            // 
            this.intervalSlider.Location = new System.Drawing.Point(42, 360);
            this.intervalSlider.Minimum = 5;
            this.intervalSlider.Name = "intervalSlider";
            this.intervalSlider.Size = new System.Drawing.Size(104, 45);
            this.intervalSlider.TabIndex = 9;
            this.intervalSlider.Value = 5;
            this.intervalSlider.Scroll += new System.EventHandler(this.intervalSlider_Scroll);
            // 
            // comboCycleTime
            // 
            this.comboCycleTime.FormattingEnabled = true;
            this.comboCycleTime.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120"});
            this.comboCycleTime.Location = new System.Drawing.Point(321, 365);
            this.comboCycleTime.Name = "comboCycleTime";
            this.comboCycleTime.Size = new System.Drawing.Size(121, 21);
            this.comboCycleTime.TabIndex = 10;
            // 
            // repeatLabelText1
            // 
            this.repeatLabelText1.AutoSize = true;
            this.repeatLabelText1.Location = new System.Drawing.Point(191, 368);
            this.repeatLabelText1.Name = "repeatLabelText1";
            this.repeatLabelText1.Size = new System.Drawing.Size(124, 13);
            this.repeatLabelText1.TabIndex = 11;
            this.repeatLabelText1.Text = "Message will cycle every";
            // 
            // repeatLabelText2
            // 
            this.repeatLabelText2.AutoSize = true;
            this.repeatLabelText2.Location = new System.Drawing.Point(448, 368);
            this.repeatLabelText2.Name = "repeatLabelText2";
            this.repeatLabelText2.Size = new System.Drawing.Size(43, 13);
            this.repeatLabelText2.TabIndex = 12;
            this.repeatLabelText2.Text = "minutes";
            // 
            // cycleTimer
            // 
            this.cycleTimer.Tick += new System.EventHandler(this.cycleTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 431);
            this.Controls.Add(this.repeatLabelText2);
            this.Controls.Add(this.repeatLabelText1);
            this.Controls.Add(this.comboCycleTime);
            this.Controls.Add(this.intervalSliderTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.txtDisplayMessage);
            this.Controls.Add(this.locateFileBtn);
            this.Controls.Add(this.fileUrlTxt);
            this.Controls.Add(this.intervalSlider);
            this.Name = "Form1";
            this.Text = "Rust Autotyper";
            ((System.ComponentModel.ISupportInitialize)(this.intervalSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileUrlTxt;
        private System.Windows.Forms.Button locateFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox txtDisplayMessage;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Timer lineTimer;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label intervalSliderTxt;
        private System.Windows.Forms.TrackBar intervalSlider;
        private System.Windows.Forms.ComboBox comboCycleTime;
        private System.Windows.Forms.Label repeatLabelText1;
        private System.Windows.Forms.Label repeatLabelText2;
        private System.Windows.Forms.Timer cycleTimer;
    }
}

