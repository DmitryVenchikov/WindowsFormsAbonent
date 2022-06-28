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
    public partial class EditDisrepairForm : Form
    {
        private readonly MongoDB_Class mongo;
        private readonly int Id;
        private  Class_Disrepair disrepair;
        public EditDisrepairForm(MongoDB_Class mongo, int id)
        {
            this.mongo = mongo;
            Id = id;
            InitializeComponent();

        }
        private void buttonEditDisrepair_Click(object sender, EventArgs e)
        {
            
            disrepair.FAILURENM = textBoxFAILURENM.Text;
            mongo.Update_Disrepair_Information(disrepair);
            MessageBox.Show("Данные успешно обновлены");
            this.Close();
        }

        private void EditDisrepairForm_Load(object sender, EventArgs e)
        {
            disrepair = mongo.Load_DataDisrepair().Where(t => t.Id == Id).First();
            textBoxFAILURENM.Text = disrepair.FAILURENM;
        }
    }
}
