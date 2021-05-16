﻿using System;
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
using System.Windows.Navigation;

namespace Chemistry_Tool
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    /// 
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        public void EH_OpenSourceCode(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);    //Open GitHub repos
        }
    }
}
