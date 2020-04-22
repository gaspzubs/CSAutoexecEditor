namespace KeyBindsForm
{
    partial class KeyBindsForm
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
            this.keyBindsListView = new System.Windows.Forms.ListView();
            this.keyBindslabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyBindsListView
            // 
            this.keyBindsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyBindsListView.HideSelection = false;
            this.keyBindsListView.Location = new System.Drawing.Point(78, 3);
            this.keyBindsListView.MinimumSize = new System.Drawing.Size(300, 200);
            this.keyBindsListView.Name = "keyBindsListView";
            this.keyBindsListView.Size = new System.Drawing.Size(710, 200);
            this.keyBindsListView.TabIndex = 0;
            this.keyBindsListView.UseCompatibleStateImageBehavior = false;
            // 
            // keyBindslabel
            // 
            this.keyBindslabel.AutoSize = true;
            this.keyBindslabel.Location = new System.Drawing.Point(3, 0);
            this.keyBindslabel.Name = "keyBindslabel";
            this.keyBindslabel.Size = new System.Drawing.Size(69, 13);
            this.keyBindslabel.TabIndex = 1;
            this.keyBindslabel.Text = "My key binds";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.keyBindslabel);
            this.flowLayoutPanel1.Controls.Add(this.keyBindsListView);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // KeyBindsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "KeyBindsForm";
            this.Text = "Key binds";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView keyBindsListView;
        private System.Windows.Forms.Label keyBindslabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

