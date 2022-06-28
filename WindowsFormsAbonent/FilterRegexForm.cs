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
    public partial class FilterRegexForm: Form
    {
        public string Mask;
        public FilterRegexForm()
        {
            InitializeComponent();
        }
        //Activator.CreateInstance(type)
        private async void buttonFiltr_ClickAsync(object sender, EventArgs e)
        {
            Mask =  textBoxExpression.Text.Trim();
            this.Close();
        }
    }
}
