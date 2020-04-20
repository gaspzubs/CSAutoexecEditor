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
            this.SuspendLayout();
            // 
            // keyBindsListView
            // 
            this.keyBindsListView.HideSelection = false;
            this.keyBindsListView.Location = new System.Drawing.Point(12, 31);
            this.keyBindsListView.Name = "keyBindsListView";
            this.keyBindsListView.Size = new System.Drawing.Size(121, 97);
            this.keyBindsListView.TabIndex = 0;
            this.keyBindsListView.UseCompatibleStateImageBehavior = false;
            // 
            // keyBindslabel
            // 
            this.keyBindslabel.AutoSize = true;
            this.keyBindslabel.Location = new System.Drawing.Point(13, 12);
            this.keyBindslabel.Name = "keyBindslabel";
            this.keyBindslabel.Size = new System.Drawing.Size(69, 13);
            this.keyBindslabel.TabIndex = 1;
            this.keyBindslabel.Text = "My key binds";
            // 
            // KeyBindsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keyBindslabel);
            this.Controls.Add(this.keyBindsListView);
            this.Name = "KeyBindsForm";
            this.Text = "Key binds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView keyBindsListView;
        private System.Windows.Forms.Label keyBindslabel;
    }
}

