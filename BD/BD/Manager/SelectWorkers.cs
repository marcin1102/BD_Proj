using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.DTO;

namespace BD.Manager
{
    public partial class SelectWorkers : UserControl
    {
        private readonly UserControl previousControl;
        public SelectWorkers(UserControl previousControl)
        {
            this.previousControl = previousControl;
            InitializeComponent();
        }

        private void chooseClientButton_Click(object sender, EventArgs e)
        {
            var worker = (WorkerData)workerDataGridView.CurrentRow.DataBoundItem;
            var createOrEditActivity = previousControl as CreateOrEditActivity;
            createOrEditActivity.SetWorker(worker);
            this.GoToPreviousView(createOrEditActivity);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }
    }
}
