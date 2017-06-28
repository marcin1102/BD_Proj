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
    }
}
