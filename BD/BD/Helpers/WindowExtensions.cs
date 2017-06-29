using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD.Helpers
{
    public static class WindowExtensions
    {
        public static void OpenNextWindow(this Form current, Form nextWindow)
        {
            current.Hide();
            nextWindow.Closed += (s, args) => current.Close();
            nextWindow.Show();
        }

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
            //parent.Controls.Add(new ManageUsersWindow());
        }

        public static void GoToNextView(this UserControl current, UserControl next)
        {
            var parent = current.Parent as Form;
            parent.Controls.Add(next);
            current.Hide();
        }
    }
}
