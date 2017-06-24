using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class testForm : Form
    {
        private RepairContext context;
        public testForm()
        {
            context = new RepairContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var context = new RepairContext())
            {
                //var res = context.Clients.ToList();
                //BindingSource bs = new BindingSource();
                //bs.DataSource = context.Clients.ToList();
                dataGridView1.DataSource = context.Clients.ToList();
                //dataGridView1.Refresh();
            }
        }

        private void DataGridView1_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            context.SaveChanges();
        }
    }
}
