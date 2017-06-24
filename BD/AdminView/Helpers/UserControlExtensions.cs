using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminView.Helpers
{
    public static class UserControlExtensions
    {
        public static void GoToPreviousView(this UserControl current, UserControl previous)
        {
            var parent = current.Parent as Form;
            previous.Show();
            current.Dispose();
        }

        public static void ClearControls(this UserControl current)
        {
            var parent = current.Parent as Form;
            parent.Controls.Clear();
            parent.Controls.Add(new ManageUsersWindow());
        }

        public static void GoToNextView(this UserControl current, UserControl next)
        {
            var parent = current.Parent as Form;
            parent.Controls.Add(next);
            current.Hide();
        }
    }
}
