using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = txtnombre.Text;
            string libro = txtlibro.Text;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = nombre;
            dataGridView1.Rows[n].Cells[1].Value = libro;
            var fecha = DateTime.Now;
            var date = fecha.Date.ToString("dd-MM-yyyy");
            var nuevafecha = Convert.ToDateTime(fecha);
            nuevafecha = nuevafecha.AddDays(30);
            string a = fecha.ToString("dd-MM-yyyy");
            string b = nuevafecha.ToString("dd-MM-yyyy");
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Rows[n].Cells[3].Value = a;
            dataGridView1.Rows[n].Cells[4].Value = b;


        }
    }
}
