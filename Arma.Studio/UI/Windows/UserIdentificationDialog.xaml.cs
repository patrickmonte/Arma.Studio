﻿using Arma.Studio.Data.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Arma.Studio.UI.Windows
{
    /// <summary>
    /// Interaction logic for SetUserIdentifierDialog.xaml
    /// </summary>
    public partial class UserIdentificationDialog : DialogWindow
    {
        public UserIdentificationDialog(UserIdentificationDialogDataContext userIdentificationDialogDataContext)
        {
            this.DataContext = userIdentificationDialogDataContext;
            InitializeComponent();
        }
    }
}
