using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form1.Hide();
            PacientesForm pacientes = new PacientesForm();
            pacientes.Show();

        }

        private void MedicosButton_Click(object sender, EventArgs e)
        {
            Program.form1.Hide();
            medicosForm medicos = new medicosForm();
            medicos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form1.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
