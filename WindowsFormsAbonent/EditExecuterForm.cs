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
    public partial class EditExecutorForm : Form
    {
        private readonly MongoDB_Class mongo;
        private readonly int executorId;
        private Class_Executor executor;
        public EditExecutorForm(MongoDB_Class mongo, int id)
        {
            this.mongo = mongo;
            executorId = id;
            InitializeComponent();
        }

        private void buttonAddExecuter_Click(object sender, EventArgs e)
        {
            executor.Fio = textBoxFIO.Text;
            mongo.Update_Executor_Information(executor);
            MessageBox.Show("Данные успешно обновлены");
            this.Close();
        }

        private void EditExecutorForm_Load(object sender, EventArgs e)
        {
            executor = mongo.Load_DataExecutor().Where(t => t.Id == executorId).First();
            textBoxFIO.Text = executor.Fio;
        }
    }
}
