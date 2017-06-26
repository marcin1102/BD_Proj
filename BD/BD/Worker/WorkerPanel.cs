using BD.Worker;
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
    public partial class WorkerStart : Form
    {
        public WorkerStart()
        {
            InitializeComponent();
        }

        private void showActivityButton_Click(object sender, EventArgs e)
        {

        }

        private void activitiesListLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formObjectSelect = new SelectObject();
            formObjectSelect.Show();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            var formWorkerMain = new WorkerMain(FormOpenMode.FINISH, null);
            formWorkerMain.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var formWorkerMain = new WorkerMain(FormOpenMode.CANCEL, null);
            formWorkerMain.Show();
        }
    }
}
