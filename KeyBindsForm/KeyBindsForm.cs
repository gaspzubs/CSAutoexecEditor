using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBindsForm
{
    public partial class KeyBindsForm : Form
    {
        private static KeyBindsForm _instanceMainForm = null;
        private static readonly object _lock = new object();

        private KeyBindsForm()
        {
            InitializeComponent();
            this.FormClosing += KeyBindsForm_FormClosing;
        }

        /// <summary>
        /// A constructor that allows to keep the owner (Main Form)
        /// </summary>
        /// <param name="owner">The owner of the KeyBindsForm</param>
        private KeyBindsForm(Form owner)
        {
            InitializeComponent();
            this.TopMost = true;
            this.Owner = owner;
            this.FormClosing += KeyBindsForm_FormClosing;
        }

        /// <summary>
        /// Get a singleton instance of the KeyBindsForm with its owner set
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static KeyBindsForm GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_instanceMainForm == null)
                    {
                        _instanceMainForm = new KeyBindsForm();
                    }
                    return _instanceMainForm;
                }
            }
        }

        /// <summary>
        /// Doesn't close the form when raising FormClosing event but only hides it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyBindsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            this.Hide();
            e.Cancel = true;
        }

    }
}
