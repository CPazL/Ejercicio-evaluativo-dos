using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vista
{
    public partial class medicosForm : Form
    {
        public medicosForm()
        {
            InitializeComponent();
        }

        private void estadisticasbutton_Click(object sender, EventArgs e)
        {
            estadísticasForm estadisticas = new estadísticasForm();
            estadisticas.Show();
        }

        private void medicosForm_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            Program.form1.Close();
        }
    }
}
