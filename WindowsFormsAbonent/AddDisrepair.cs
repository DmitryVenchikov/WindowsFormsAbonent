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
    public partial class AddDisrepair : Form
    {
        MongoDB_Class mongoDBConnect;
        public AddDisrepair(MongoDB_Class mongoDBConnect)
        {
            InitializeComponent();
            this.mongoDBConnect = mongoDBConnect;
        }

        private void AddDisrepair_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddDisrepair_Click(object sender, EventArgs e)
        {
            mongoDBConnect.Insert_Disrepair_Information(new Class_Disrepair
            {
                Id = mongoDBConnect.Load_DataDisrepair().OrderBy(t => t.Id).Last().Id + 1,
                FAILURENM = textBoxFAILURENM.Text
            } );
            MessageBox.Show("Данные успешно добавлены");
            this.Close();
        }

    }
}
