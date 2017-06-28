using BusinessLayer;
using BusinessLayer.Searchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Manager
{
    public partial class SelectClient : Form
    {
        public SelectClient()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var clientSearcher = new ClientSearcher();
            clientBindingSource.DataSource = clientSearcher.GetClients();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var window = new CreateClient();
            window.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
