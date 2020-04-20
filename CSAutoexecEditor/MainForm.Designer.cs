namespace CSAutoexecEditor
{
    sealed partial class MainForm
    {
        private static MainForm _instanceMainForm = null;
        private static readonly object _lock = new object();

        public static MainForm GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if(_instanceMainForm == null)
                    {
                        _instanceMainForm = new MainForm();
                    }
                    return _instanceMainForm;
                }
            }
        }
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
            this.folderBrowserCfg = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CSFolderTextBox = new System.Windows.Forms.TextBox();
            this.CSFolderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserCfg
            // 
            this.folderBrowserCfg.SelectedPath = "C:\\";
            this.folderBrowserCfg.Tag = "";
            this.folderBrowserCfg.HelpRequest += new System.EventHandler(this.folderBrowserCfg_HelpRequest);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.CSFolderTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CSFolderButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CSFolderTextBox
            // 
            this.CSFolderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CSFolderTextBox.Location = new System.Drawing.Point(3, 3);
            this.CSFolderTextBox.Name = "CSFolderTextBox";
            this.CSFolderTextBox.Size = new System.Drawing.Size(654, 20);
            this.CSFolderTextBox.TabIndex = 0;
            // 
            // CSFolderButton
            // 
            this.CSFolderButton.AutoSize = true;
            this.CSFolderButton.Location = new System.Drawing.Point(663, 3);
            this.CSFolderButton.MinimumSize = new System.Drawing.Size(135, 23);
            this.CSFolderButton.Name = "CSFolderButton";
            this.CSFolderButton.Size = new System.Drawing.Size(135, 23);
            this.CSFolderButton.TabIndex = 1;
            this.CSFolderButton.Text = "Select your CS:GO folder";
            this.CSFolderButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Autoexec Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserCfg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox CSFolderTextBox;
        private System.Windows.Forms.Button CSFolderButton;
    }
}

