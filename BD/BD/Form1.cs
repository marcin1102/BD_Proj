using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var class1 = new DataLayer.Class1();
            class1.AddClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientSearcher = new ClientSearcher();
            dataGridView1.DataSource = clientSearcher.GetClients();
        }
    }
}
