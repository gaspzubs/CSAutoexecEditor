using System;
using System.Collections.Generic;
using System.Text;

namespace SettingAutoexec
{
    /// <summary>
    /// a bind between an in-game setting and a key
    /// </summary>
    public class Binding : ISetting
    {
        public List<Command> Commands
        {
            get => default;
            set
            {
            }
        }

        public List<Key> Keys
        {
            get => default;
            set
            {
            }
        }

        public string getCfgLine()
        {
            throw new NotImplementedException();
        }
    }
}