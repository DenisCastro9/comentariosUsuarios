using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace finalTP2
{
    public partial class consultar_comentarios : Form
    {
        public consultar_comentarios()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");


        private void consultar_comentarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalTP2DataSet3.redSocial' Puede moverla o quitarla según sea necesario.
            this.redSocialTableAdapter.Fill(this.finalTP2DataSet3.redSocial);
            // TODO: esta línea de código carga datos en la tabla 'finalTP2DataSet2.comentarios' Puede moverla o quitarla según sea necesario.
            this.comentariosTableAdapter.Fill(this.finalTP2DataSet2.comentarios);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM comentarios where id_usuario like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Close();
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM comentarios where redSocial like('" + comboBox1.SelectedValue + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Close();
        }
    }
}
