using System;
using System.Windows.Forms;
using AdminView.Helpers;
using DataLayer;
using BusinessLayer.Searchers;
using DataLayer.Role;
using System.Linq;
using BusinessLayer.DTO;
using BusinessLayer.Services;

namespace AdminView
{
    public partial class UpdateUserWindow : UserControl
    {
        private readonly UserControl previousControl;
        private readonly string uName;
        public UpdateUserWindow(UserControl previousControl, string uName)
        {
            InitializeComponent();
            this.previousControl = previousControl;
            this.uName = uName;
            FillFields();
        }

        private void returnBT_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }

        private async void FillFields()
        {
            var workerSearcher = new WorkerSearcher();
            var worker = await workerSearcher.GetByLogin(uName);
            firstNameTB.Text = worker.FirstName;
            lastNameTB.Text = worker.LastName;
            roleCB.DataSource = Enum.GetValues(typeof(Roles)).Cast<Roles>().Select(x => x.ToString()).ToList();
        }

        private async void updateBT_Click(object sender, EventArgs e)
        {
            var workerData = new WorkerData(uName, passTB.Text, firstNameTB.Text, lastNameTB.Text, roleCB.Text, null);
            var workerService = new WorkerService();
            try
            {
                await workerService.UpdateWorkerData(workerData);
                this.ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                       
        }
    }
}
