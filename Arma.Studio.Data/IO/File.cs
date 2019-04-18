﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma.Studio.Data.IO
{
    public class File : FileFolderBase
    {
        public string Extension => System.IO.Path.GetExtension(this.Name);
        protected override void OnNameChanged()
        {
            this.RaisePropertyChanged(nameof(this.Extension));
        }
    }
}
