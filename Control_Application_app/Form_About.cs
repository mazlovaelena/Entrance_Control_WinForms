using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Application_app
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
            label1.Text = $"Название: {Assembly.GetExecutingAssembly().GetName().Name.ToString()}  Версия: [{Assembly.GetExecutingAssembly().GetName().Version.ToString()}]";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/bulossssshhhhhka");
        }

        private void Form_About_Load(object sender, EventArgs e)
        {

        }
    }
}
