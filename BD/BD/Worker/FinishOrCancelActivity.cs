﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.DTO;

namespace BD
{
    public partial class FinishOrCancelActivity : UserControl
    {
        public FinishOrCancelActivity()
        {
            InitializeComponent();
        }

        public FinishOrCancelActivity(FormOpenMode mode, ActivityData activity)
        {
            InitializeComponent();
        }

        private void endButton_Click(object sender, EventArgs e)
        {

        }

        private void WorkerActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
