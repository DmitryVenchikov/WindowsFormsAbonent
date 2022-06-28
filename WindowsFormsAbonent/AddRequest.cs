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
    public partial class AddRequest : Form
    {
        MongoDB_Class mongoDBConnect;
        public AddRequest(MongoDB_Class mongoDBConnect)
        {
            InitializeComponent();
            this.mongoDBConnect = mongoDBConnect;
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            mongoDBConnect.Insert_Request_Information(new Class_Request
            {
                Id = mongoDBConnect.Load_DataRequest().OrderBy(t=>t.Id).Last().Id+1,
                AccountCD = textBoxAccountCD.Text,
                ExecutorCD = textBoxExecutorCD.Text,
                FailureCD = textBoxFailureCD.Text,
                ExecutionDate = dateTimePickerExecutionDate.Value,
                IncomingDate = dateTimePickerIncomingDate.Value,
                Executed = checkBoxExecuted.Checked
            }
            );
            MessageBox.Show("Данные успешно добавлены");
            this.Close();
        }

        private void AddExecuter_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxExecuted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerExecutionDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerIncomingDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFailureCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExecutorCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAccountCD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
