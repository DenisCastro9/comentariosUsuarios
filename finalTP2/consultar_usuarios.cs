using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalTP2
{
    public partial class consultar_usuarios : Form
    {
        public consultar_usuarios()
        {
            InitializeComponent();
        }

        private void consultar_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalTP2DataSet4.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.finalTP2DataSet4.usuarios);

        }
    }
}
