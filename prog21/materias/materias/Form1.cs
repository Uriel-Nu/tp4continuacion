using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace materias
{
    
    public partial class Form1 : Form
    {
        Ingles Lista { get; set; } = new Ingles();

        public Form1()
        {
            InitializeComponent();
            dg1.DataSource = Nin.DT;
            Nin.LeerDeArchivo();
            
                
            
           

        }

        public Ingles Nin { get; set; } = new Ingles();

        private void btcargar_Click(object sender, System.EventArgs e)
        {
            Lista.Registrar(txtcontenido.SelectedItem.ToString());


        }
    }
}

