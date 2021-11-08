
namespace Formularios
{
    partial class FormAnalisis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridAnalisis = new System.Windows.Forms.DataGridView();
            this.nombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NacionalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivilCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnExportarJSON = new FormMenuPrincipal.BotonPersonalizado();
            this.btnExportarXML = new FormMenuPrincipal.BotonPersonalizado();
            this.btnExportarTxt = new FormMenuPrincipal.BotonPersonalizado();
            this.lblMayorA = new System.Windows.Forms.Label();
            this.txtMayorA = new System.Windows.Forms.TextBox();
            this.lstFiltrado = new System.Windows.Forms.ListBox();
            this.lstOpciones = new System.Windows.Forms.ListBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.btnFiltrar = new FormMenuPrincipal.BotonPersonalizado();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAnalisis
            // 
            this.dataGridAnalisis.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnalisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCol,
            this.ApellidoCol,
            this.EdadCol,
            this.SexoCol,
            this.NacionalidadCol,
            this.EstadoCivilCol,
            this.puestoCol,
            this.sueldoCol,
            this.activoCol});
            this.dataGridAnalisis.GridColor = System.Drawing.Color.Black;
            this.dataGridAnalisis.Location = new System.Drawing.Point(321, 31);
            this.dataGridAnalisis.Name = "dataGridAnalisis";
            this.dataGridAnalisis.RowTemplate.Height = 25;
            this.dataGridAnalisis.Size = new System.Drawing.Size(904, 520);
            this.dataGridAnalisis.TabIndex = 0;
            // 
            // nombreCol
            // 
            this.nombreCol.Frozen = true;
            this.nombreCol.HeaderText = "Nombre";
            this.nombreCol.Name = "nombreCol";
            this.nombreCol.ReadOnly = true;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.Frozen = true;
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            // 
            // EdadCol
            // 
            this.EdadCol.Frozen = true;
            this.EdadCol.HeaderText = "Edad";
            this.EdadCol.Name = "EdadCol";
            this.EdadCol.ReadOnly = true;
            // 
            // SexoCol
            // 
            this.SexoCol.Frozen = true;
            this.SexoCol.HeaderText = "Sexo";
            this.SexoCol.Name = "SexoCol";
            this.SexoCol.ReadOnly = true;
            // 
            // NacionalidadCol
            // 
            this.NacionalidadCol.Frozen = true;
            this.NacionalidadCol.HeaderText = "Nacionalidad";
            this.NacionalidadCol.Name = "NacionalidadCol";
            this.NacionalidadCol.ReadOnly = true;
            // 
            // EstadoCivilCol
            // 
            this.EstadoCivilCol.Frozen = true;
            this.EstadoCivilCol.HeaderText = "Estado Civil";
            this.EstadoCivilCol.Name = "EstadoCivilCol";
            this.EstadoCivilCol.ReadOnly = true;
            // 
            // puestoCol
            // 
            this.puestoCol.Frozen = true;
            this.puestoCol.HeaderText = "Puesto";
            this.puestoCol.Name = "puestoCol";
            this.puestoCol.ReadOnly = true;
            // 
            // sueldoCol
            // 
            this.sueldoCol.Frozen = true;
            this.sueldoCol.HeaderText = "Sueldo";
            this.sueldoCol.Name = "sueldoCol";
            this.sueldoCol.ReadOnly = true;
            // 
            // activoCol
            // 
            this.activoCol.Frozen = true;
            this.activoCol.HeaderText = "Activo";
            this.activoCol.Name = "activoCol";
            this.activoCol.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 58);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Analisis De Datos";
            // 
            // btnExportarJSON
            // 
            this.btnExportarJSON.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportarJSON.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnExportarJSON.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportarJSON.BorderRadius = 40;
            this.btnExportarJSON.BorderSize = 0;
            this.btnExportarJSON.FlatAppearance.BorderSize = 0;
            this.btnExportarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarJSON.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarJSON.ForeColor = System.Drawing.Color.White;
            this.btnExportarJSON.Location = new System.Drawing.Point(630, 597);
            this.btnExportarJSON.Name = "btnExportarJSON";
            this.btnExportarJSON.Size = new System.Drawing.Size(293, 54);
            this.btnExportarJSON.TabIndex = 2;
            this.btnExportarJSON.Text = "Exportar a JSON";
            this.btnExportarJSON.TextColor = System.Drawing.Color.White;
            this.btnExportarJSON.UseVisualStyleBackColor = false;
            this.btnExportarJSON.Click += new System.EventHandler(this.btnExportarJSON_Click);
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportarXML.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnExportarXML.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportarXML.BorderRadius = 40;
            this.btnExportarXML.BorderSize = 0;
            this.btnExportarXML.FlatAppearance.BorderSize = 0;
            this.btnExportarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarXML.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarXML.ForeColor = System.Drawing.Color.White;
            this.btnExportarXML.Location = new System.Drawing.Point(328, 597);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(293, 54);
            this.btnExportarXML.TabIndex = 3;
            this.btnExportarXML.Text = "Exportar a XML";
            this.btnExportarXML.TextColor = System.Drawing.Color.White;
            this.btnExportarXML.UseVisualStyleBackColor = false;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // btnExportarTxt
            // 
            this.btnExportarTxt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportarTxt.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnExportarTxt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportarTxt.BorderRadius = 40;
            this.btnExportarTxt.BorderSize = 0;
            this.btnExportarTxt.FlatAppearance.BorderSize = 0;
            this.btnExportarTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarTxt.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportarTxt.ForeColor = System.Drawing.Color.White;
            this.btnExportarTxt.Location = new System.Drawing.Point(932, 597);
            this.btnExportarTxt.Name = "btnExportarTxt";
            this.btnExportarTxt.Size = new System.Drawing.Size(293, 54);
            this.btnExportarTxt.TabIndex = 4;
            this.btnExportarTxt.Text = "Exportar a TXT";
            this.btnExportarTxt.TextColor = System.Drawing.Color.White;
            this.btnExportarTxt.UseVisualStyleBackColor = false;
            this.btnExportarTxt.Click += new System.EventHandler(this.btnExportarTxt_Click);
            // 
            // lblMayorA
            // 
            this.lblMayorA.AutoSize = true;
            this.lblMayorA.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblMayorA.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMayorA.ForeColor = System.Drawing.Color.White;
            this.lblMayorA.Location = new System.Drawing.Point(19, 281);
            this.lblMayorA.Name = "lblMayorA";
            this.lblMayorA.Size = new System.Drawing.Size(107, 39);
            this.lblMayorA.TabIndex = 6;
            this.lblMayorA.Text = "Mayor A:";
            this.lblMayorA.Visible = false;
            // 
            // txtMayorA
            // 
            this.txtMayorA.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMayorA.Location = new System.Drawing.Point(150, 285);
            this.txtMayorA.Name = "txtMayorA";
            this.txtMayorA.Size = new System.Drawing.Size(146, 36);
            this.txtMayorA.TabIndex = 7;
            this.txtMayorA.Visible = false;
            // 
            // lstFiltrado
            // 
            this.lstFiltrado.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFiltrado.FormattingEnabled = true;
            this.lstFiltrado.ItemHeight = 29;
            this.lstFiltrado.Items.AddRange(new object[] {
            "Edad",
            "Sexo",
            "Nacionalidad",
            "Estado Civil",
            "Puesto",
            "Sueldo",
            "Activo",
            "Todos"});
            this.lstFiltrado.Location = new System.Drawing.Point(30, 109);
            this.lstFiltrado.Name = "lstFiltrado";
            this.lstFiltrado.Size = new System.Drawing.Size(264, 149);
            this.lstFiltrado.TabIndex = 8;
            this.lstFiltrado.SelectedIndexChanged += new System.EventHandler(this.lstFiltrado_SelectedIndexChanged);
            // 
            // lstOpciones
            // 
            this.lstOpciones.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOpciones.FormattingEnabled = true;
            this.lstOpciones.ItemHeight = 29;
            this.lstOpciones.Location = new System.Drawing.Point(30, 338);
            this.lstOpciones.Name = "lstOpciones";
            this.lstOpciones.Size = new System.Drawing.Size(264, 207);
            this.lstOpciones.TabIndex = 9;
            this.lstOpciones.Visible = false;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblFiltrar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltrar.ForeColor = System.Drawing.Color.White;
            this.lblFiltrar.Location = new System.Drawing.Point(59, 270);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(208, 58);
            this.lblFiltrar.TabIndex = 10;
            this.lblFiltrar.Text = "Filtrar Por :";
            this.lblFiltrar.Visible = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFiltrar.BorderRadius = 40;
            this.btnFiltrar.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(70, 575);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(160, 54);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextColor = System.Drawing.Color.White;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(696, 552);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(101, 45);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "ERROR";
            this.lblError.Visible = false;
            // 
            // FormAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 692);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lstOpciones);
            this.Controls.Add(this.lstFiltrado);
            this.Controls.Add(this.txtMayorA);
            this.Controls.Add(this.lblMayorA);
            this.Controls.Add(this.btnExportarTxt);
            this.Controls.Add(this.btnExportarXML);
            this.Controls.Add(this.btnExportarJSON);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridAnalisis);
            this.Name = "FormAnalisis";
            this.Text = "Analisis";
            this.Load += new System.EventHandler(this.FormAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAnalisis;
        private System.Windows.Forms.Label lblTitulo;
        private FormMenuPrincipal.BotonPersonalizado btnExportarJSON;
        private FormMenuPrincipal.BotonPersonalizado btnExportarXML;
        private FormMenuPrincipal.BotonPersonalizado btnExportarTxt;
        private System.Windows.Forms.Label lblMayorA;
        private System.Windows.Forms.TextBox txtMayorA;
        private System.Windows.Forms.ListBox lstFiltrado;
        private System.Windows.Forms.ListBox lstOpciones;
        private System.Windows.Forms.Label lblFiltrar;
        private FormMenuPrincipal.BotonPersonalizado btnFiltrar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NacionalidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivilCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoCol;
    }
}