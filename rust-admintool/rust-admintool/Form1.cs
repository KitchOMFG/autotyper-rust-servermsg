using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rust_admintool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void locateFileBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;
                
                fileUrlTxt.Text = fullPath;
                txtDisplayMessage.LoadFile(fullPath, RichTextBoxStreamType.PlainText);

            }
            //Debugging
        }
    }
}
