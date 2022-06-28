using Abonent;
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

          //  this.ИзменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
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
                RequestForm editform = new RequestForm(mongoDBConnect);
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


    }
}
