using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD.Helpers;
using BusinessLayer;
using BusinessLayer.DTO;
using BusinessLayer.Searchers;

namespace BD
{
    public partial class FinishOrCancelActivity : UserControl
    {
        private readonly UserControl previousControl;
        private readonly RequestData request;

        public FinishOrCancelActivity(UserControl previousControl)
        {
            this.previousControl = previousControl;
            InitializeComponent();
        }

        public void LoadObjectDataToLabels(ObjectData @object)
        {
            objectTypeLabel.Text = @object.ObjectTypeCode.ToString();
            objectNameLabel.Text = @object.Name.ToString();
        }

        public void LoadActivityDataToLabels(ActivityData activity)
        {
            activityIdLabel.Text = activity.Id.ToString();
            activityStatusLabel.Text = activity.Status.ToString();
        }

        public void LoadRequestDesc(ActivityData activity)
        {
            var requestSearcher = new RequestSearcher();
            try
            {
                requestDescrTextBox.Text = requestSearcher.GetRequest(activity.ReqId).Result.Descr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FinishOrCancelActivity(UserControl previousControl, FormOpenMode mode, ActivityData activity, ObjectData @object)
        {
            this.previousControl = previousControl;
            InitializeComponent();

            if (mode == FormOpenMode.FINISH)
                confirmBtn.Text = "Zakończ";
            else if (mode == FormOpenMode.CANCEL)
                confirmBtn.Text = "Anuluj";

            LoadObjectDataToLabels(@object);
            LoadActivityDataToLabels(activity);
            LoadRequestDesc(activity);
        }

        private void WorkerActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.GoToPreviousView(previousControl);
        }
    }
}
