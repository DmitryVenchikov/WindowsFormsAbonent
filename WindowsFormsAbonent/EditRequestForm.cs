using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAbonent;
using static WindowsFormsAbonent.MongoDBConnect;

namespace Abonent
{
    public partial class EditRequestForm : Form
    {
        private readonly MongoDB_Class mongo;
        private readonly int requestId;
        Class_Request request;
        public EditRequestForm(MongoDB_Class mongo, int id)
        {
            requestId = id;
            this.mongo = mongo;
            InitializeComponent();
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            request.AccountCD = AccountCDtb.Text;
            request.ExecutorCD = executorCDtb.Text;
            request.IncomingDate = incomingDatedp.Value;
            request.ExecutionDate = executionDatedp.Value;
            request.FailureCD = failrueCDtb.Text;
            request.Executed = check.Checked;
            mongo.Update_Request_Information(request);
            MessageBox.Show("Данные успешно обновлены");
            this.Close();
        }

        private void EditRequestForm_Load(object sender, EventArgs e)
        {
            request = mongo.Load_DataRequest().Where(t => t.Id == requestId).First();
            AccountCDtb.Text = request.AccountCD;
            executorCDtb.Text = request.ExecutorCD;
            incomingDatedp.Value = request.IncomingDate;
            executionDatedp.Value = request.ExecutionDate;
            failrueCDtb.Text = request.FailureCD;
            check.Checked = request.Executed;
        }
    }
}
