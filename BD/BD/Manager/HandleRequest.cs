using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer.DTO;

namespace BD.Manager.beta
{
    public partial class HandleRequest : UserControl
    {
		private readonly RequestData request;

        public HandleRequest(RequestData request)
        {
            InitializeComponent();
			this.request = request;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.GoToNextView(new CreateActivity(this, request));
		}
    }
}
