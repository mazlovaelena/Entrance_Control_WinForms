using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Application_app.kursovayaDataSetTableAdapters;


namespace Control_Application_app
{
    public partial class Form_Chart : Form
    {
        public static string connectString = "Provider=Microsoft.JET.OleDB.4.0;Data Source=kursovaya.mdb";
        private OleDbConnection myconn;
       
        public Form_Chart()
        {
            InitializeComponent();
           
        }
        private void Form_Chart_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.kursovayaDataSet.Должности);

            myconn = new OleDbConnection(connectString);
            myconn.Open();
            
            
        }

    }
}
