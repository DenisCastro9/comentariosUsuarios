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
    public partial class modificar_usuario : Form
    {
        public modificar_usuario()
        {
            InitializeComponent();
        }

        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;

        private void modificar_usuario_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source = DESKTOP-TDSHAI5\\SQLEXPRESS; Initial Catalog = finalTP2; Integrated Security = true");
            adaptador = new SqlDataAdapter();
            datos = new DataSet();

            SqlCommand consultar = new SqlCommand("SELECT * FROM usuarios where id_usuario = @id_usuario", conexion);
            adaptador.SelectCommand = consultar;
            adaptador.SelectCommand.Parameters.Add(new SqlParameter("@id_usuario", SqlDbType.Int));

            SqlCommand modificar = new SqlCommand("UPDATE usuarios SET nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fecha_nacimiento, numero_celular = @numero_celular, mail = @mail", conexion);
            adaptador.UpdateCommand = modificar;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fecha_nacimiento", SqlDbType.Date));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero_celular", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(id_txt.Text))
            {
                MessageBox.Show("Es necesario ingresar un ID de un usuario cargado");
            }
            else
            {
                try
                {
                    conexion.Open();
                    adaptador.SelectCommand.Parameters["@id_usuario"].Value = int.Parse(id_txt.Text);
                    adaptador.Fill(datos, "usuarios");
                    int registro = int.Parse(datos.Tables["usuarios"].Rows.Count.ToString());
                    if(registro == 1)
                    {
                        foreach(DataRow fila in datos.Tables["usuarios"].Rows)
                        {
                            nombre_txt.Text = fila["nombre"].ToString();
                            apellido_txt.Text = fila["apellido"].ToString();
                            fecha_dtp.Value = (DateTime)fila["fecha_nacimiento"];
                            celular_txt.Text = fila["numero_celular"].ToString();
                            mail_txt.Text = fila["mail"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID ingresado no existe");
                    }
                }
                catch(SqlException excepcion)
                {
                    MessageBox.Show(excepcion.ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adaptador.UpdateCommand.Parameters["@nombre"].Value = nombre_txt.Text;
            adaptador.UpdateCommand.Parameters["@apellido"].Value = apellido_txt.Text;
            adaptador.UpdateCommand.Parameters["@fecha_nacimiento"].Value = fecha_dtp.Value;
            adaptador.UpdateCommand.Parameters["@numero_celular"].Value = celular_txt.Text;
            adaptador.UpdateCommand.Parameters["@mail"].Value = mail_txt.Text;
        }
    }
}
