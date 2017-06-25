using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using BusinessLayer.DTO;
using DataLayer.Role;
using AdminView.Helpers;

namespace AdminView
{
    public partial class AddUserWindow : UserControl
    {
        private readonly UserControl previousControl;

        public AddUserWindow(UserControl previousControl)
        {
            InitializeComponent();
            this.previousControl = previousControl;
            roleCB.DataSource = Enum.GetValues(typeof(Roles)).Cast<Roles>().Select(x => x.ToString()).ToList();
        }

        private async void createUserBT_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();
            var workerToCreate = new WorkerData(loginTB.Text, passTB.Text, firstNameTB.Text, lastNameTB.Text, roleCB.Text, null);
            try
            {
                loginService.Register(workerToCreate);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            var form = Parent as Form;
            form.Controls.Clear();
            form.Controls.Add(new ManageUsersWindow());
        }

        private void returnBT_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }
    }
}
