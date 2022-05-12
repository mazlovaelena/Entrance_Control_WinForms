using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Application_app
{
    public partial class Form_Title : Form
    {
        public static string connectString = "Provider=Microsoft.JET.OleDB.4.0;Data Source=kursovaya.mdb";
        private OleDbConnection myconn;
        
        public Form_Title()
        {
            InitializeComponent();
            myconn = new OleDbConnection(connectString);
            myconn.Open();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About form_About = new Form_About();
            form_About.Show();

        }

        private void просмотрДиаграмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Chart form_Chart = new Form_Chart();
            form_Chart.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Title_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form_Title_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Уровни_доступа_помещ". При необходимости она может быть перемещена или удалена.
            this.уровни_доступа_помещTableAdapter.Fill(this.kursovayaDataSet.Уровни_доступа_помещ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Помещения". При необходимости она может быть перемещена или удалена.
            this.помещенияTableAdapter.Fill(this.kursovayaDataSet.Помещения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Уровень_доступа_помещения". При необходимости она может быть перемещена или удалена.
            this.уровень_доступа_помещенияTableAdapter.Fill(this.kursovayaDataSet.Уровень_доступа_помещения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Уровни_доступа_сотр". При необходимости она может быть перемещена или удалена.
            this.уровни_доступа_сотрTableAdapter.Fill(this.kursovayaDataSet.Уровни_доступа_сотр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Уровень_доступа_сотрудники". При необходимости она может быть перемещена или удалена.
            this.уровень_доступа_сотрудникиTableAdapter.Fill(this.kursovayaDataSet.Уровень_доступа_сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.kursovayaDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.kursovayaDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Доступ". При необходимости она может быть перемещена или удалена.
            this.доступTableAdapter.Fill(this.kursovayaDataSet.Доступ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovayaDataSet.Уровни_доступа_помещ". При необходимости она может быть перемещена или удалена.
           
            this.Text = this.Text + " [версия " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]";
            
        }

        private void TB_e_Fname_TextChanged(object sender, EventArgs e)
        {
            доступBindingSource.Filter = "[Фамилия] LIKE'" + TB_e_Fname.Text + "%'";
        }

        private void TB_e_name_TextChanged(object sender, EventArgs e)
        {
            доступBindingSource.Filter = "[Имя] LIKE'" + TB_e_name.Text + "%'";

        }

        private void TB_e_Lname_TextChanged(object sender, EventArgs e)
        {
            доступBindingSource.Filter = "[Отчество] LIKE'" + TB_e_Lname.Text + "%'";

        }

        private void TB_e_Room_TextChanged(object sender, EventArgs e)
        {
            доступBindingSource.Filter = "[IDПомещение] LIKE'" + TB_e_Room.Text + "%'";

        }

        private void TB_s_Fname_TextChanged(object sender, EventArgs e)
        {
            сотрудникиBindingSource1.Filter = "[Фамилия] LIKE'" + TB_s_Fname.Text + "%'";

        }

        private void TB_s_name_TextChanged(object sender, EventArgs e)
        {
            сотрудникиBindingSource1.Filter = "[Имя] LIKE'" + TB_s_name.Text + "%'";
        }

        private void TB_s_Lname_TextChanged(object sender, EventArgs e)
        {
            сотрудникиBindingSource1.Filter = "[Отчество] LIKE'" + TB_s_Lname.Text + "%'";
        }
        
        
        private void checkBox_enterfalse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_enterfalse.Checked == true)
            {
                DataGridViewCellStyle RedcellStyle = null;
                RedcellStyle = new DataGridViewCellStyle();
                RedcellStyle.BackColor = Color.Red;
                int index = dataGridView_enter.Columns["статусДоступаDataGridViewTextBoxColumn"].Index;


                foreach (DataGridViewRow viewRow in dataGridView_enter.Rows)
                {
                    if (viewRow.IsNewRow)
                        break;
                    foreach (DataGridViewCell viewCell in viewRow.Cells)

                        if (viewRow.Cells[index].Value.ToString().Contains("Отказ доступа"))
                        {
                            viewRow.DefaultCellStyle = RedcellStyle;
                        }

                }
            }
            else if (checkBox_enterfalse.Checked == false)
            {
                DataGridViewCellStyle AzurecellStyle = null;
                AzurecellStyle = new DataGridViewCellStyle();
                AzurecellStyle.BackColor = Color.Azure;
                int index = dataGridView_enter.Columns["статусДоступаDataGridViewTextBoxColumn"].Index;

                foreach (DataGridViewRow Viewrow in dataGridView_enter.Rows)
                {
                    if (Viewrow.IsNewRow)
                        break;
                    foreach (DataGridViewCell viewCell in Viewrow.Cells)

                        if (Viewrow.Cells[index].Value.ToString().Contains("Отказ доступа"))
                        {
                            Viewrow.DefaultCellStyle = AzurecellStyle;
                        }

                }

            }

        }

        private void checkBox_entertrue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_entertrue.Checked == true)
            {
                DataGridViewCellStyle GreencellStyle = null;
                GreencellStyle = new DataGridViewCellStyle();
                GreencellStyle.BackColor = Color.LimeGreen;
                int index = dataGridView_enter.Columns["статусДоступаDataGridViewTextBoxColumn"].Index;

                foreach (DataGridViewRow Viewrow in dataGridView_enter.Rows)
                {
                    if (Viewrow.IsNewRow)
                        break;
                    foreach (DataGridViewCell viewCell in Viewrow.Cells)

                        if (Viewrow.Cells[index].Value.ToString().Contains("Доступ разрешен"))
                        {
                            Viewrow.DefaultCellStyle = GreencellStyle;
                        }

                }
            }
            else if (checkBox_entertrue.Checked == false)
            {
                DataGridViewCellStyle AzurecellStyle = null;
                AzurecellStyle = new DataGridViewCellStyle();
                AzurecellStyle.BackColor = Color.Azure;
                int index = dataGridView_enter.Columns["статусДоступаDataGridViewTextBoxColumn"].Index;

                foreach (DataGridViewRow Viewrow in dataGridView_enter.Rows)
                {
                    if (Viewrow.IsNewRow)
                        break;
                    foreach (DataGridViewCell viewCell in Viewrow.Cells)

                        if (Viewrow.Cells[index].Value.ToString().Contains("Доступ разрешен"))
                        {
                            Viewrow.DefaultCellStyle = AzurecellStyle;
                        }

                }

            }


        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(tabControl1.SelectedTab == tabPage_enter)
                {
                    this.доступTableAdapter.Update(this.kursovayaDataSet.Доступ);
                    this.доступTableAdapter.Fill(this.kursovayaDataSet.Доступ);
                    checkBox_enterfalse.Enabled = true;
                    checkBox_entertrue.Enabled = true;
                    доступBindingSource.Filter = null;

                }
                if(tabControl1.SelectedTab == tabPage_staff)
                {
                    this.сотрудникиTableAdapter.Update(this.kursovayaDataSet.Сотрудники);
                    this.сотрудникиTableAdapter.Fill(this.kursovayaDataSet.Сотрудники);
                    сотрудникиBindingSource.Filter = null;

                }
                if(tabControl1.SelectedTab == tabPage_post)
                {
                    this.должностиTableAdapter.Update(this.kursovayaDataSet.Должности);
                    this.должностиTableAdapter.Fill(this.kursovayaDataSet.Должности);
                    this.уровень_доступа_сотрудникиTableAdapter.Update(this.kursovayaDataSet.Уровень_доступа_сотрудники);
                    this.уровень_доступа_сотрудникиTableAdapter.Fill(this.kursovayaDataSet.Уровень_доступа_сотрудники);
                    this.уровни_доступа_сотрTableAdapter.Update(this.kursovayaDataSet.Уровни_доступа_сотр);
                    this.уровни_доступа_сотрTableAdapter.Fill(this.kursovayaDataSet.Уровни_доступа_сотр);
                }
                if(tabControl1.SelectedTab == tabPage_room)
                {
                    this.помещенияTableAdapter.Update(this.kursovayaDataSet.Помещения);
                    this.помещенияTableAdapter.Fill(this.kursovayaDataSet.Помещения);
                    this.уровень_доступа_помещенияTableAdapter.Update(this.kursovayaDataSet.Уровень_доступа_помещения);
                    this.уровень_доступа_помещенияTableAdapter.Fill(this.kursovayaDataSet.Уровень_доступа_помещения);
                    this.уровни_доступа_помещTableAdapter.Update(this.kursovayaDataSet.Уровни_доступа_помещ);
                    this.уровни_доступа_помещTableAdapter.Fill(this.kursovayaDataSet.Уровни_доступа_помещ);
                }
               
            }
            catch
            {
                MessageBox.Show("ОШИБКА СОХРАНЕНИЯ! Необходимо заполнить все поля!");
            }
            myconn.Close();
        }

        private void dataGridView_enter_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error happened" + anError.Context.ToString());
            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report();
            form_Report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = dataGridView_staff.SelectedCells[0].RowIndex;
            dataGridView_staff.Rows.RemoveAt(ind);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = dataGridView_post.SelectedCells[0].RowIndex;
            dataGridView_post.Rows.RemoveAt(ind);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView_room.SelectedCells[0].RowIndex;
            dataGridView_room.Rows.RemoveAt(ind);
        }
    }
}
