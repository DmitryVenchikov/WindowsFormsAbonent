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
    public partial class AddExecuter : Form
    {
        MongoDB_Class mongoDBConnect;
        public AddExecuter(MongoDB_Class mongoDBConnect)
        {
            InitializeComponent();
            this.mongoDBConnect = mongoDBConnect;
        }

        private void buttonAddExecuter_Click(object sender, EventArgs e)
        {
            mongoDBConnect.Insert_Executor_Information(new MongoDBConnect.Class_Executor
            {
                Fio = textBoxFIO.Text
            }
           ) ;
            MessageBox.Show("Данные успешно добавлены");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
