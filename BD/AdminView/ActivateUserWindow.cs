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
    public partial class ActivateUserWindow : UserControl
    {
        private readonly UserControl previousControl;
        private readonly string uName;
        public ActivateUserWindow(UserControl previousControl, string uName)
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
            label1.Text = worker.FirstName;
            label2.Text = worker.LastName;
        }

        private void returnBT_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }

        private async void activateBT_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();
            try
            {
                await loginService.removeExpiration(uName);
                this.ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
