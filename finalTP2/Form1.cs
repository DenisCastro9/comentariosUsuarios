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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void altaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alta_usuario a = new alta_usuario();
            a.MdiParent = this;
            a.Show();
        }

        private void bajaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baja_usuario b = new baja_usuario();
            b.MdiParent = this;
            b.Show();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar_usuario m = new modificar_usuario();
            m.MdiParent = this;
            m.Show();
        }

        private void cargarUnComentarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alta_comentario ac = new alta_comentario();
            ac.MdiParent = this;
            ac.Show();
        }

        private void consultarComentariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultar_comentarios cc = new consultar_comentarios();
            cc.MdiParent = this;
            cc.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultar_usuarios cu = new consultar_usuarios();
            cu.MdiParent = this;
            cu.Show();
        }

        private void altaDeRedSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaRedSocial ars = new altaRedSocial();
            ars.MdiParent = this;
            ars.Show();
        }

        private void bajaDeRedSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bajaRedSocial brs = new bajaRedSocial();
            brs.MdiParent = this;
            brs.Show();
        }

        private void modificarRedSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarRedSocial mrs = new modificarRedSocial();
            mrs.MdiParent = this;
            mrs.Show();
        }
    }
}
