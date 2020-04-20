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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cSFolderTextBox = new System.Windows.Forms.TextBox();
            this.cSFolderButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generateButton);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 411);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.cSFolderTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cSFolderButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cSFolderTextBox
            // 
            this.cSFolderTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cSFolderTextBox.Location = new System.Drawing.Point(3, 5);
            this.cSFolderTextBox.MaximumSize = new System.Drawing.Size(600, 20);
            this.cSFolderTextBox.Name = "cSFolderTextBox";
            this.cSFolderTextBox.Size = new System.Drawing.Size(438, 20);
            this.cSFolderTextBox.TabIndex = 0;
            // 
            // cSFolderButton
            // 
            this.cSFolderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cSFolderButton.AutoSize = true;
            this.cSFolderButton.Location = new System.Drawing.Point(444, 0);
            this.cSFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.cSFolderButton.MinimumSize = new System.Drawing.Size(135, 20);
            this.cSFolderButton.Name = "cSFolderButton";
            this.cSFolderButton.Size = new System.Drawing.Size(140, 30);
            this.cSFolderButton.TabIndex = 1;
            this.cSFolderButton.Text = "Select your CS:GO folder";
            this.cSFolderButton.UseVisualStyleBackColor = false;
            // 
            // generateButton
            // 
            this.generateButton.AutoSize = true;
            this.generateButton.Location = new System.Drawing.Point(13, 376);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(108, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate autoexec";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "Autoexec Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox cSFolderTextBox;
        private System.Windows.Forms.Button cSFolderButton;
        private System.Windows.Forms.Button generateButton;
    }
}

