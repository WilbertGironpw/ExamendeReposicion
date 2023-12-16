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
        public FormularioDeDatos()
        {
            InitializeComponent();
            LoadData();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = DataTable;


        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdVehiculo as IdVehiculo, marca as Marca, modelo as Modelo, year as Year, num_motor as Num_motor, num_chasis as Num_chasis FROM tbl_vehiculos", conn);

                DataTable.Clear();  // Limpiar el DataTable existente antes de cargar datos nuevos
                da.Fill(DataTable);

                UpdateDataGridView();  // Actualizar el DataGridView con el nuevo DataTable
                dataGridView1.Columns[0].ReadOnly = true;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    Console.WriteLine(column.Name);
                }
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
            btnAgregar.Enabled = true
            ;
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

            btnAgregar.Enabled = false;
        }

        private void MostrarDatosEnTextBoxEditar(int rowIndex)
        {
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (currentRowIndex >= 0 && currentRowIndex < DataTable.Rows.Count)
            {
                DataRow row = DataTable.Rows[currentRowIndex];
                row["marca"] = txtMarca.Text;
                row["modelo"] = txtModelo.Text;

                if (int.TryParse(txtYear.Text, out int yearValue))
                {
                    row["year"] = yearValue;
                }
                else
                {
                    MessageBox.Show("El año debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                row["num_motor"] = txtNumMotor.Text;
                row["num_chasis"] = txtNumChasis.Text;

                // Aquí puedes aceptar los cambios en el DataTable si es necesario
                // DataTable.AcceptChanges();

                UpdateDataGridView();  // Actualizar el DataGridView después de la edición

                LimpiarTextBox();
            }

            btnAgregar.Enabled = true;
        }

        private void LimpiarTextBox()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtYear.Clear();
            txtNumMotor.Clear();
            txtNumChasis.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dataGridView1.CurrentRow.Index;

                // Obtener el valor de la columna que contiene el identificador único (por ejemplo, IdVehiculo)
                int IdVehiculo = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["IdVehiculo"].Value);
                // Confirmar con el usuario antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Eliminar la fila de la base de datos
                    EliminarFilaDeBaseDeDatos(IdVehiculo);

                    // Actualizar el DataGridView
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("No hay fila seleccionada para eliminar.", "Mensaje");
            }
        }

        private void EliminarFilaDeBaseDeDatos(int idVehiculo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Utiliza un comando SQL DELETE para eliminar la fila con el IdVehiculo específico
                string query = "DELETE FROM tbl_vehiculos WHERE IdVehiculo = @IdVehiculo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

                cmd.ExecuteNonQuery();
            }
        }
    }
}