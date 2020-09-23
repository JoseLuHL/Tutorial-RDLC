using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var categoria = new ObservableCollection<Class1>();
            categoria.Add(new Class1 { id = 1, descripcion = "Carne" });
            categoria.Add(new Class1 { id = 2, descripcion = "Leche" });
            categoria.Add(new Class1 { id = 3, descripcion = "Pan" });

            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet1", categoria);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

        }
    }
}
