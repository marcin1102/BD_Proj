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

namespace BD
{
    public partial class WorkerMain : Form
    {
        public WorkerMain()
        {
            InitializeComponent();
        }

        public WorkerMain(FormOpenMode mode, DataLayer.Activity activity)
        {
            InitializeComponent();
        }

        private void endButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}