using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamendeRp
{
    public partial class FormularioDeDatos : Form
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parque_vehicular_primer_apellido_primer_nombre.mdf;Integrated Security=True";
        private DataTable DataTable = new DataTable();

        private int currentRowIndex = -1;
        private bool modoEdicion = false;
        public FormularioDeDatos()
        {
            InitializeComponent();
            LoadData();
        }

        private void UpdateDataGridView()
        {
            // Limpiar el DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Volver a configurar el DataGridView con el DataTable actualizado
            dataGridView1.DataSource = DataTable;


        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdVehiculo as IdVehiculo, marca as Marca, modelo as Modelo, year as Year, num_motor as Num_motor, num_chasis as Num_chasis FROM tbl_vehiculos", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].ReadOnly = true;

                // Configura el DataGridView para usar el DataTable
                dataGridView1.DataSource = DataTable;
            }
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int totalFilasAgregadas = 0;

            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string year = txtYear.Text;
            string num_motor = txtNumMotor.Text;
            string num_chasis = txtNumChasis.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand verificarExistencia = new SqlCommand("SELECT COUNT(*) FROM tbl_vehiculos WHERE CAST(marca AS NVARCHAR(MAX)) = @marca AND CAST(modelo AS NVARCHAR(MAX)) = @modelo AND CAST(year AS NVARCHAR(MAX)) = @year AND CAST(num_motor AS NVARCHAR(MAX)) = @num_motor AND CAST(num_chasis AS NVARCHAR(MAX)) = @num_chasis", conn);

                verificarExistencia.Parameters.AddWithValue("@marca", marca);
                verificarExistencia.Parameters.AddWithValue("@modelo", modelo);
                verificarExistencia.Parameters.AddWithValue("@year", year);
                verificarExistencia.Parameters.AddWithValue("@num_motor", num_motor);
                verificarExistencia.Parameters.AddWithValue("@num_chasis", num_chasis);

                int rowCount = Convert.ToInt32(verificarExistencia.ExecuteScalar());

                if (rowCount == 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_vehiculos (marca, modelo, year, num_motor, num_chasis) VALUES (@marca, @modelo, @year, @num_motor, @num_chasis)", conn);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@num_motor", num_motor);
                    cmd.Parameters.AddWithValue("@num_chasis", num_chasis);

                    int filasAgregadas = cmd.ExecuteNonQuery();
                    totalFilasAgregadas += filasAgregadas;
                }
                else
                {
                    MessageBox.Show($"La fila con los datos ingresados ya existe.", "Mensaje!!");
                }
            }

            MessageBox.Show($"Filas añadidas: {totalFilasAgregadas}", "Mensaje!!");
            totalFilasAgregadas = 0;
            LoadData(); // Recargar datos
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbMarca.Checked)
                BuscarPorCampo("marca", txtBusqueda.Text);
            else if (rdbModelo.Checked)
                BuscarPorCampo("modelo", txtBusqueda.Text);
            else if (rdbYear.Checked)
                BuscarPorCampo("year", txtBusqueda.Text);
            else if (rdbMotor.Checked)
                BuscarPorCampo("num_motor", txtBusqueda.Text);
            else if (rdbChasis.Checked)
                BuscarPorCampo("num_chasis", txtBusqueda.Text);
        }

        private void BuscarPorCampo(string campo, string valor)
        {
            string consulta = $"SELECT * FROM tbl_vehiculos WHERE {campo} LIKE '%' + @valor + '%'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@valor", valor);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarDatosEnTextBox(int rowIndex)
        {
            // Verificar si el índice es válido
            if (rowIndex >= 0 && rowIndex < DataTable.Rows.Count)
            {
                DataRow row = DataTable.Rows[rowIndex];

                // Mostrar los datos en TextBox
                txtMarca.Text = row["marca"].ToString();
                txtModelo.Text = row["modelo"].ToString();
                txtYear.Text = row["year"].ToString();
                txtNumMotor.Text = row["num_motor"].ToString();
                txtNumChasis.Text = row["num_chasis"].ToString();
            }
        }

            private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtYear.Clear();
            txtNumMotor.Clear();
            txtNumChasis.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila actual seleccionada
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el índice de la fila actual
                currentRowIndex = dataGridView1.CurrentRow.Index;

                // Mostrar los datos en TextBox para su edición
                MostrarDatosEnTextBox(currentRowIndex);
            }
            else
            {
                // No hay fila seleccionada, manejar según sea necesario
                MessageBox.Show("No hay fila seleccionada para editar.");
            }
        }

        private void MostrarDatosEnTextBoxEditar(int rowIndex)
        {
            Console.WriteLine($"MostrarDatosEnTextBox llamado con índice: {rowIndex}");

            if (rowIndex >= 0 && rowIndex < DataTable.Rows.Count)
            {
                DataRow row = DataTable.Rows[rowIndex];

                // Mostrar los datos en TextBox
                txtMarca.Text = row["marca"].ToString();
                txtModelo.Text = row["modelo"].ToString();
                txtYear.Text = row["year"].ToString();
                txtNumMotor.Text = row["num_motor"].ToString();
                txtNumChasis.Text = row["num_chasis"].ToString();
            }
            else
            {
                Console.WriteLine("Índice fuera de rango");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (currentRowIndex >= 0 && currentRowIndex < DataTable.Rows.Count)
            {
                // Actualizar los datos en la fila actual
                DataRow row = DataTable.Rows[currentRowIndex];
                row["marca"] = txtMarca.Text;
                row["modelo"] = txtModelo.Text;
                row["year"] = txtYear.Text;
                row["num_motor"] = txtNumMotor.Text;
                row["num_chasis"] = txtNumChasis.Text;

                // Guardar los cambios en el DataTable (si es necesario)
                // DataTable.AcceptChanges(); // Puedes necesitar aceptar los cambios dependiendo de tu configuración

                // Actualizar la vista del DataGridView
                UpdateDataGridView(); // Asume que ya tienes el método UpdateDataGridView implementado
            }


        }
    }
}