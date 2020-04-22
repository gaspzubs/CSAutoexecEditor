using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyBindsForm;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CSAutoexecEditor
{
    public partial class MainForm : Form
    {
        private MainForm()
        {
            InitializeComponent();
            // Button events
            this.cSFolderButton.Click += new EventHandler(this.CSFolderButton_Click);
            this.mngeKeyBndsButton.Click += new EventHandler(this.MngeKeyBndsButton_Click);
            // Miscellaneous events
            this.FormClosing += this.MainForm_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Button Events
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

        private void MngeKeyBndsButton_Click(object sender, EventArgs e)
        {
            KeyBindsForm.KeyBindsForm keyBindsForm = KeyBindsForm.KeyBindsForm.GetInstance;
            keyBindsForm.Show(this);
            this.Hide();
        }
        #endregion Button Events

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

    }
}
