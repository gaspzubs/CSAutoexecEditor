using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CSAutoexecEditor
{
    public partial class MainForm : Form
    {
        private MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void CSFolderButton_Click(object sender, EventArgs e)
        {
            using (var csOpenFolderDialog = new CommonOpenFileDialog())
            {
                csOpenFolderDialog.IsFolderPicker = true;
                csOpenFolderDialog.EnsurePathExists = true;
                var csFolder = csOpenFolderDialog.ShowDialog();

                if (csFolder == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(csOpenFolderDialog.FileName))
                {
                    this.cSFolderTextBox.Text = csOpenFolderDialog.FileName;
                }
            }
        }

        private void folderBrowserCfg_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
