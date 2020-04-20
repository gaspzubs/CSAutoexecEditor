using System;
using System.Collections.Generic;
using System.Text;

namespace SettingAutoexec
{
    public interface ISetting
    {
        /// <summary>
        /// Returns the line to add to autoexec.cfg
        /// </summary>
        string getCfgLine();
    }
}