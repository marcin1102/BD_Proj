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
using BusinessLayer.Searchers;

namespace BD.Manager
{
	public partial class SelectWorker : UserControl
	{
		private readonly UserControl previousView;

		public SelectWorker(UserControl previousView)
		{
			InitializeComponent();
			this.previousView = previousView;
		}

		private async void searchButton_Click(object sender, EventArgs e)
		{
			var searcher = new WorkerSearcher();
			workerGridView.DataSource = await searcher.FullTextSearch(searchTextBox.Text);
		}
	}
}
