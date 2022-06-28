using Abonent;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsAbonent.MongoDBConnect;

namespace WindowsFormsAbonent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MongoDB_Class mongoDBConnect;
        private void Form1_Load(object sender, EventArgs e)
        {
            mongoDBConnect = new MongoDB_Class();
            updateRequests();
            updateExecutors();
            updateDisrepairs();

            dataGridViewRequest.ContextMenuStrip = contextMenuStrip2;
            dataGridViewExecutor.ContextMenuStrip = contextMenuStrip2;
            dataGridViewDisrepair.ContextMenuStrip = contextMenuStrip2;
        }

        private void dataGridViewRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabPageRequest.CanFocus)
            {
                AddRequest addRequest = new AddRequest(mongoDBConnect);
                addRequest.ShowDialog();
                updateRequests();
            }
            else if (tabPageExecutor.CanFocus)
            {
                AddExecuter addRequest = new AddExecuter(mongoDBConnect);
                addRequest.ShowDialog();
                updateExecutors();
            }
            else if (tabPageDisrepair.CanFocus)
            {
                AddDisrepair addRequest = new AddDisrepair(mongoDBConnect);
                addRequest.ShowDialog();
                updateDisrepairs();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabPageRequest.CanFocus)
            {
                var i = dataGridViewRequest.SelectedCells[0].OwningRow.Index;
                var id = (int)dataGridViewRequest[1, i].Value;
                EditRequestForm editform = new EditRequestForm(mongoDBConnect, id);
                editform.ShowDialog();
                updateRequests();
            }
            else if (tabPageExecutor.CanFocus)
            {
                var i = dataGridViewExecutor.SelectedCells[0].OwningRow.Index;
                var id = (int)dataGridViewExecutor[1, i].Value;
                EditExecutorForm editform = new EditExecutorForm(mongoDBConnect, id);
                editform.ShowDialog();
                updateExecutors();
            }
            else if (tabPageDisrepair.CanFocus)
            {

                var i = dataGridViewDisrepair.SelectedCells[0].OwningRow.Index;
                var id = (int)dataGridViewDisrepair[1, i].Value;
                EditDisrepairForm editform = new EditDisrepairForm(mongoDBConnect, id);
                editform.ShowDialog();
                updateDisrepairs();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (tabPageRequest.CanFocus)
            {
                var i = dataGridViewRequest.SelectedCells[0].OwningRow.Index;
                var id = (int)dataGridViewRequest[1, i].Value;
                mongoDBConnect.Delete_Request_Infromation(mongoDBConnect.Load_DataRequest().Where(t =>
                t.Id == id).First());
                updateRequests();
            }
            else if (tabPageExecutor.CanFocus)
            {
                var i = dataGridViewExecutor.SelectedCells[0].OwningRow.Index;
                var id = (int)dataGridViewExecutor[1, i].Value;
                mongoDBConnect.Delete_Executor_Infromation(mongoDBConnect.Load_DataExecutor().Where(t =>
                 t.Id == id).First());
                updateExecutors();
            }
            else if (tabPageDisrepair.CanFocus)
            {
                var i = dataGridViewDisrepair.SelectedCells[0].OwningRow.Index;
                var id = (int)dataGridViewDisrepair[1, i].Value;
                mongoDBConnect.Delete_Disrepair_Infromation(mongoDBConnect.Load_DataDisrepair().Where(t =>
                t.Id == id).First());
                updateDisrepairs();
            }
        }
        void updateRequests()
        {
            dataGridViewRequest.DataSource = mongoDBConnect.Load_DataRequest();
        }
        void updateExecutors()
        {
            dataGridViewExecutor.DataSource = mongoDBConnect.Load_DataExecutor();
        }
        void updateDisrepairs()
        {
            dataGridViewDisrepair.DataSource = mongoDBConnect.Load_DataDisrepair();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
        private async void Filter<T>(DataGridView dataGridView, string nameOfTable)
        {
            int column = dataGridView.SelectedCells[0].OwningColumn.Index;
            string nameOfColumn = dataGridView.Columns[column].Name;
            var filterForm = new FilterRegexForm();
            filterForm.ShowDialog();
            dataGridView.DataSource = await mongoDBConnect.FilterData<T>(nameOfColumn, filterForm.Mask, nameOfTable);
        }
        private async void фильтроватьToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            if (tabPageRequest.CanFocus)
            {
                if(dataGridViewRequest.Rows.Count!=0)
                {
                    //int column = dataGridViewRequest.SelectedCells[0].OwningColumn.Index;
                    //string nameOfColumn = dataGridViewRequest.Columns[column].Name;
                    //var filterForm = new FilterRegexForm();
                    //filterForm.ShowDialog();
                    //dataGridViewRequest.DataSource = await mongoDBConnect.FilterData<Class_Request>(nameOfColumn, filterForm.Mask);
                    Filter<Class_Request>(dataGridViewRequest, "Request");
                }
            }
            else if (tabPageExecutor.CanFocus)
            {
                if (dataGridViewExecutor.Rows.Count != 0)
                {
                    Filter<Class_Executor>(dataGridViewExecutor, "Executor");
                }
            }
            else if (tabPageDisrepair.CanFocus)
            {
                if (dataGridViewDisrepair.Rows.Count != 0)
                {
                    Filter<Class_Disrepair>(dataGridViewDisrepair, "Disrepair");
                }
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabPageRequest.CanFocus)
            {
                updateRequests();
            }
            else if (tabPageExecutor.CanFocus)
            {
                updateExecutors();
            }
            else if (tabPageDisrepair.CanFocus)
            {
                updateDisrepairs();
            }
        }
    }
}
