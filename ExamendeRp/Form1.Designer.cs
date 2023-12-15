
namespace ExamendeRp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblvehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummotorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numchasisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasetAdmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetAdm = new ExamendeRp.DatasetAdm();
            this.tbl_vehiculosTableAdapter = new ExamendeRp.DatasetAdmTableAdapters.tbl_vehiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.nummotorDataGridViewTextBoxColumn,
            this.numchasisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblvehiculosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(737, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblvehiculosBindingSource
            // 
            this.tblvehiculosBindingSource.DataMember = "tbl_vehiculos";
            this.tblvehiculosBindingSource.DataSource = this.datasetAdmBindingSource;
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            this.idVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nummotorDataGridViewTextBoxColumn
            // 
            this.nummotorDataGridViewTextBoxColumn.DataPropertyName = "num_motor";
            this.nummotorDataGridViewTextBoxColumn.HeaderText = "num_motor";
            this.nummotorDataGridViewTextBoxColumn.Name = "nummotorDataGridViewTextBoxColumn";
            this.nummotorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numchasisDataGridViewTextBoxColumn
            // 
            this.numchasisDataGridViewTextBoxColumn.DataPropertyName = "num_chasis";
            this.numchasisDataGridViewTextBoxColumn.HeaderText = "num_chasis";
            this.numchasisDataGridViewTextBoxColumn.Name = "numchasisDataGridViewTextBoxColumn";
            this.numchasisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datasetAdmBindingSource
            // 
            this.datasetAdmBindingSource.DataSource = this.datasetAdm;
            this.datasetAdmBindingSource.Position = 0;
            // 
            // datasetAdm
            // 
            this.datasetAdm.DataSetName = "DatasetAdm";
            this.datasetAdm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_vehiculosTableAdapter
            // 
            this.tbl_vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1125, 546);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource datasetAdmBindingSource;
        private DatasetAdm datasetAdm;
        private System.Windows.Forms.BindingSource tblvehiculosBindingSource;
        private DatasetAdmTableAdapters.tbl_vehiculosTableAdapter tbl_vehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummotorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numchasisDataGridViewTextBoxColumn;
    }
}

