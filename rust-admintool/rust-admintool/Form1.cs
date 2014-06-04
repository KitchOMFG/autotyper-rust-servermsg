using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace rust_admintool
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        public void locateFileBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;
                fileUrlTxt.Text = fullPath;
                StreamReader file = new StreamReader(fullPath);
                txtDisplayMessage.LoadFile(fullPath, RichTextBoxStreamType.PlainText);
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            runBtn.Enabled = false;
            stopBtn.Enabled = true;

            i = 0;
            timer.Enabled = true;


        }
        private void stopBtn_Click(object sender, EventArgs e)
        {
            runBtn.Enabled = true;
            stopBtn.Enabled = false;

            timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string fullPath = openFileDialog.FileName;
            string[] lines = File.ReadAllLines(fullPath); //Splits each line into a separate array position

            
            if (i < lines.Length)
            {
                SendKeys.Send(lines[i]);
                SendKeys.Send("{ENTER}");
                i++;
            }
            else
            {
                timer.Enabled = false;
            }
            
            
        }

        private void intervalSlider_Scroll(object sender, EventArgs e)
        {
            timer.Interval = intervalSlider.Value * 1000;
            int intervalValue = intervalSlider.Value;
            intervalSliderTxt.Text = "A message is sent every " + intervalValue.ToString() + " seconds";
        }

        
    }
}
