namespace Control_Application_app
{
    partial class Form_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Report));
            this.доступBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursovayaDataSet1 = new Control_Application_app.kursovayaDataSet();
            this.ДоступBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.доступTableAdapter1 = new Control_Application_app.kursovayaDataSetTableAdapters.ДоступTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.доступBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДоступBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // доступBindingSource1
            // 
            this.доступBindingSource1.DataMember = "Доступ";
            this.доступBindingSource1.DataSource = this.kursovayaDataSet1;
            // 
            // kursovayaDataSet1
            // 
            this.kursovayaDataSet1.DataSetName = "kursovayaDataSet";
            this.kursovayaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ДоступBindingSource
            // 
            this.ДоступBindingSource.DataMember = "Доступ";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.доступBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Application_app.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1052, 587);
            this.reportViewer1.TabIndex = 0;
            // 
            // доступTableAdapter1
            // 
            this.доступTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1052, 587);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Просмотр отчета";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.доступBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДоступBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ДоступBindingSource;
        private kursovayaDataSet kursovayaDataSet;
        private kursovayaDataSetTableAdapters.ДоступTableAdapter ДоступTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private kursovayaDataSet kursovayaDataSet1;
        private System.Windows.Forms.BindingSource доступBindingSource1;
        private kursovayaDataSetTableAdapters.ДоступTableAdapter доступTableAdapter1;
    }
}