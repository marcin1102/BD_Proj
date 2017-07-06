using BD.Helpers;
using BD.Manager;
using BD.Worker;
using BusinessLayer.Searchers;
using BusinessLayer.Services;
using DataLayer.Role;
using System;
using System.Windows.Forms;
using BusinessLayer;

namespace BD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButtonClick(object sender, EventArgs e)
        {
            var loginService = new LoginService();
            var uName = loginTextBox.Text;
            var pass = passwordTextBox.Text;
            bool isAuthorized = false;
            try
            {
                isAuthorized = await loginService.LoginAsync(uName, pass);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Błędny login lub hasło");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (isAuthorized == true)
            {
                var workerSearcher = new WorkerSearcher();
                var worker = await workerSearcher.GetByLogin(uName);
                ChooseAndOpenNextWindow(worker.Role);
                LoggedUser.Worker = worker;
            }
        }

        private void ChooseAndOpenNextWindow(string role)
        {
            if(role == Roles.Worker.ToString())
            {
                this.OpenNextWindow(new MainWindow(new WorkerPanel()));
            }
            else
            {
                this.OpenNextWindow(new MainWindow(new ManagerPanel()));
            }
        }
    }
}
