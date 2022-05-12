using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Application_app
{
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet1.Доступ". При необходимости она может быть перемещена или удалена.
            this.доступTableAdapter1.Fill(this.kursovayaDataSet1.Доступ);

            this.reportViewer1.RefreshReport();
        }
    }
}
