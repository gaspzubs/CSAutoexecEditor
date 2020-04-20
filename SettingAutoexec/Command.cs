using System;
using System.Collections.Generic;
using System.Text;

namespace SettingAutoexec
{
    public struct Command
    {
        /// <summary>
        /// The type of the command (crosshair, cl_*...)
        /// </summary>
        public string type
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The raw text of the command
        /// </summary>
        public string commandText
        {
            get => default;
            set
            {
            }
        }

        public Binding Binding
        {
            get => default;
            set
            {
            }
        }
    }
}