using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente abrir = new Cliente();
            abrir.Show();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            Auto abrir = new Auto();
            abrir.Show();
        }
    }
}
