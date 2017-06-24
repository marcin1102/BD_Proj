using BD.Admin;
using BusinessLayer;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            bindData();
        }

        private void bindData()
        { 
            workerBindingSource.DataSource = WorkerFacade.GetWorkers(null);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var window = new AdminUserCreateForm();
            window.Show();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {

        }

        private void setUserRoleButton_Click(object sender, EventArgs e)
        {

        }

        private void usersRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaNaprawDataSet.Worker' table. You can move, or remove it, as needed.
            //this.workerTableAdapter.Fill(this.bazaNaprawDataSet.Worker);
            usersDataGridView.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
