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

namespace AdminView
{
    public partial class LoginWindow : UserControl
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();
            var uName = uNameTB.Text;
            var pass = passTB.Text;
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
            
            if(isAuthorized == true)
            {
                var form = Parent as Form;
                form.Controls.Add(new ManageUsersWindow());
                Dispose();
            }            
        }
    }
}
