using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminView.Helpers;
using BusinessLayer.Searchers;
using BusinessLayer.Services;

namespace AdminView
{
    public partial class DeactivateUserWindow : UserControl
    {
        private readonly UserControl previousControl;
        private readonly string uName;
        public DeactivateUserWindow(UserControl previousControl, string uName)
        {
            this.previousControl = previousControl;
            InitializeComponent();
            this.uName = uName;
            FillFields();
        }

        private async void FillFields()
        {
            var workerSearcher = new WorkerSearcher();
            var worker = await workerSearcher.GetByLogin(uName);
            firstNameTB.Text = worker.FirstName;
            lastNameTB.Text = worker.LastName;
        }

        private void returnBT_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }

        private async void setExpirationBT_Click(object sender, EventArgs e)
        {
            var dateTime = expirationDP.Value;
            var loginService = new LoginService();
            try
            {
                await loginService.SetExpiration(uName, dateTime);
                this.ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
