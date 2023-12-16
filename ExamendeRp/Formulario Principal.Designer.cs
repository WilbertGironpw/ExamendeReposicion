
namespace ExamendeRp
{
    partial class FormularioDeDatos
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
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummotorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numchasisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblvehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetAdmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetAdm = new ExamendeRp.DatasetAdm();
            this.tbl_vehiculosTableAdapter = new ExamendeRp.DatasetAdmTableAdapters.tbl_vehiculosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblnumchasis = new System.Windows.Forms.Label();
            this.lblnummotor = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNumChasis = new System.Windows.Forms.TextBox();
            this.txtNumMotor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(875, 494);
            this.dataGridView1.TabIndex = 0;
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
            // tblvehiculosBindingSource
            // 
            this.tblvehiculosBindingSource.DataMember = "tbl_vehiculos";
            this.tblvehiculosBindingSource.DataSource = this.datasetAdmBindingSource;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtNumMotor);
            this.groupBox1.Controls.Add(this.txtNumChasis);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.lblnummotor);
            this.groupBox1.Controls.Add(this.lblnumchasis);
            this.groupBox1.Controls.Add(this.lblyear);
            this.groupBox1.Controls.Add(this.lblmodelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.lblmarca);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(911, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 576);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredar o Editar Datos";
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.Controls.Add(this.btnEditar);
            this.PanelPrincipal.Controls.Add(this.btnEliminar);
            this.PanelPrincipal.Controls.Add(this.button7);
            this.PanelPrincipal.Controls.Add(this.button8);
            this.PanelPrincipal.Controls.Add(this.button6);
            this.PanelPrincipal.Controls.Add(this.button5);
            this.PanelPrincipal.Controls.Add(this.groupBox1);
            this.PanelPrincipal.Location = new System.Drawing.Point(-1, -2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1347, 702);
            this.PanelPrincipal.TabIndex = 0;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmarca.Location = new System.Drawing.Point(88, 87);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(52, 15);
            this.lblmarca.TabIndex = 0;
            this.lblmarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(146, 82);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(220, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmodelo.Location = new System.Drawing.Point(82, 147);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(58, 15);
            this.lblmodelo.TabIndex = 2;
            this.lblmodelo.Text = "Modelo:";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblyear.Location = new System.Drawing.Point(104, 212);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(36, 15);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Año:";
            // 
            // lblnumchasis
            // 
            this.lblnumchasis.AutoSize = true;
            this.lblnumchasis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumchasis.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnumchasis.Location = new System.Drawing.Point(11, 331);
            this.lblnumchasis.Name = "lblnumchasis";
            this.lblnumchasis.Size = new System.Drawing.Size(129, 15);
            this.lblnumchasis.TabIndex = 4;
            this.lblnumchasis.Text = "Numero de Chasis:";
            // 
            // lblnummotor
            // 
            this.lblnummotor.AutoSize = true;
            this.lblnummotor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnummotor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnummotor.Location = new System.Drawing.Point(17, 271);
            this.lblnummotor.Name = "lblnummotor";
            this.lblnummotor.Size = new System.Drawing.Size(123, 15);
            this.lblnummotor.TabIndex = 5;
            this.lblnummotor.Text = "Numero de Motor:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(146, 142);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(220, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // txtNumChasis
            // 
            this.txtNumChasis.Location = new System.Drawing.Point(146, 326);
            this.txtNumChasis.Name = "txtNumChasis";
            this.txtNumChasis.Size = new System.Drawing.Size(220, 20);
            this.txtNumChasis.TabIndex = 7;
            // 
            // txtNumMotor
            // 
            this.txtNumMotor.Location = new System.Drawing.Point(146, 266);
            this.txtNumMotor.Name = "txtNumMotor";
            this.txtNumMotor.Size = new System.Drawing.Size(220, 20);
            this.txtNumMotor.TabIndex = 8;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(146, 207);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(220, 20);
            this.txtYear.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(155, 411);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(267, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(306, 605);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(572, 605);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(453, 596);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 39);
            this.button5.TabIndex = 2;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(481, 596);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 39);
            this.button6.TabIndex = 3;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(407, 604);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 21);
            this.button8.TabIndex = 5;
            this.button8.Text = "<<";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(509, 605);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 21);
            this.button7.TabIndex = 6;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // FormularioDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1346, 697);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "FormularioDeDatos";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetAdm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNumMotor;
        private System.Windows.Forms.TextBox txtNumChasis;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblnummotor;
        private System.Windows.Forms.Label lblnumchasis;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

