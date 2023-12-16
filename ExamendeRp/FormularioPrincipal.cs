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
using System.IO;

namespace ExamendeRp
{
    public partial class FormularioDeDatos : Form
    {
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        private Conexion conexion;

        public FormularioDeDatos()
        {
            InitializeComponent();
            conexion = new Conexion();
            {
                miTabla = new DataTable();
                miTabla.Columns.Add("marca", typeof(string));
                miTabla.Columns.Add("modelo", typeof(string));
                miTabla.Columns.Add("year", typeof(string));
                miTabla.Columns.Add("num_motor", typeof(string));
                miTabla.Columns.Add("num_chasis", typeof(string));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_vehiculosTableAdapter.Fill(this.datasetAdm.tbl_vehiculos);
        }
        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string num_motor = txtNumMotor.Text;
            string num_chasis = txtNumChasis.Text;
            if (int.TryParse(txtYear.Text, out int year))
            {
                if (marca.Length == 1)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }
                if (modelo.Length == 1)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtYear.Text))
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }

                if (num_motor.Length == 2)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }
                if (num_chasis.Length == 2)
                {
                    MessageBox.Show("Datos invalidos.");
                    return;
                }
            }
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parque_vehicular_primer_apellido_primer_nombre.mdf;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO tbl_vehiculos (marca, modelo, year, num_motor, num_chasis,) VALUES (@marca, @modelo, @year, @num_motor, @num_chasis,)", conexion);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@year", year);
            comando.Parameters.AddWithValue("@num_motor", num_motor);
            comando.Parameters.AddWithValue("@num_chasis", num_chasis);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos se ingresaron correctamente");

            DataRow nuevaFila = miTabla.NewRow();
            nuevaFila["marca"] = marca;
            nuevaFila["modelo"] = modelo;
            nuevaFila["year"] = year;
            nuevaFila["num_motor"] = num_motor;
            nuevaFila["num_chasis"] =num_chasis;
            miTabla.Rows.Add(nuevaFila);

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
