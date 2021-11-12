using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace materias1
{
    public partial class ForMaterias : Form
    {
        lista listas { get; set; } = new lista();
        public ForMaterias()
        {
            InitializeComponent();
            dg.DataSource = listas.DT;

        }

        private void ForMaterias_Load(object sender, EventArgs e)
        {

        }

        private void txttp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttp4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnotafinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            listas.registrar(cmbnombre.SelectedItem.ToString(), Convert.ToInt32(txttp1.Text),
           Convert.ToInt32(txttp2.Text),
           Convert.ToInt32(txttp3.Text),
           Convert.ToInt32(txttp4.Text),
           Convert.ToInt32(txtnotafinal.Text));


             
        }
    }
}
