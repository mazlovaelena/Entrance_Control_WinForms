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

namespace Control_Application_app
{
    public partial class Form_Auth : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Auth.mdb";
        private OleDbConnection myConnection;
        public Form_Auth()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form_Auth_Load(object sender, EventArgs e)
        {
            label_error.Visible = false;
        }

        private void but_auth_Click(object sender, EventArgs e)
        {
            Form_Title form_Title = new Form_Title();

            string query = "SELECT Login, Password FROM Auth ORDER BY ID";
            OleDbCommand command_1 = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command_1.ExecuteReader();

            string auth_login = Convert.ToString(TB_login.Text);
            string auth_password = Convert.ToString(TB_password.Text);
            while(reader.Read())
            {
                if ((string)reader["Login"] != auth_login)
                {
                    label_error.Visible = true;                
                }
                if(auth_password != (string)reader["Password"])
                {
                    label_error.Visible = true;
                }

                else if (auth_login == (string)reader["Login"])
                {
                    if (auth_password ==(string)reader["Password"])
                    {
                        label_error.Visible = false;
                        form_Title.Show();
                        this.Hide();
                        break;
                    }
                }

            }
            reader.Close();


        }
    }
}
