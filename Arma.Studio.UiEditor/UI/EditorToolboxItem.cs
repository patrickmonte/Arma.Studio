﻿using Arma.Studio.UiEditor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma.Studio.UiEditor.UI
{
    public class EditorToolboxItem
    {
        public string Name { get; set; }
        public EControlType Type { get; set; }
        public string IconPath { get; set; }
    }
}
