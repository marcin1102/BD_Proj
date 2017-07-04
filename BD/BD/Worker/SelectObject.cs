using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;
using BusinessLayer.Services;
using BusinessLayer.Services.Object;

namespace BD.Worker
{
    public partial class SelectObject : UserControl
    {
        private readonly UserControl previousControl;

        public async void GetObjectsData()
        {
            try
            {
                var objectSearcher = new ObjectSearcher();
                objectDataGridView.DataSource = await objectSearcher.GetObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public SelectObject(UserControl previousControl)
        {
            this.previousControl = previousControl;
            InitializeComponent();

            GetObjectsData();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }

        private async void selectButton_Click(object sender, EventArgs e)
        {
                try
                {
                    var @object = (ObjectData) objectDataGridView.CurrentRow.DataBoundItem;
                    var workerPanel = previousControl as WorkerPanel;
                    if (workerPanel != null)
                    {
                        workerPanel.SetObject(@object);
                        this.GoToPreviousView(workerPanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
