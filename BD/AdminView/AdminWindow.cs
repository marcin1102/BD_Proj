﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminView
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            Controls.Add(new LoginWindow());
        }
    }
}
