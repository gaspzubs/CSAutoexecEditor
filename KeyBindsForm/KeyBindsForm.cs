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
        private KeyBindsForm()
        {
            InitializeComponent();
        }
    }
}
