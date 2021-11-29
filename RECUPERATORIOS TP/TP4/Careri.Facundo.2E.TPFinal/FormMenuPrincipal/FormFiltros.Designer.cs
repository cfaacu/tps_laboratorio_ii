
namespace Formularios
{
    partial class FormFiltros
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
            this.dataGridAnalisis.Location = new System.Drawing.Point(367, 41);
            this.dataGridAnalisis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridAnalisis.Name = "dataGridAnalisis";
            this.dataGridAnalisis.RowHeadersWidth = 51;
            this.dataGridAnalisis.RowTemplate.Height = 25;
            this.dataGridAnalisis.Size = new System.Drawing.Size(1033, 693);
            this.dataGridAnalisis.TabIndex = 0;
            // 
            // nombreCol
            // 
            this.nombreCol.Frozen = true;
            this.nombreCol.HeaderText = "Nombre";
            this.nombreCol.MinimumWidth = 6;
            this.nombreCol.Name = "nombreCol";
            this.nombreCol.ReadOnly = true;
            this.nombreCol.Width = 125;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.Frozen = true;
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.MinimumWidth = 6;
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            this.ApellidoCol.Width = 125;
            // 
            // EdadCol
            // 
            this.EdadCol.Frozen = true;
            this.EdadCol.HeaderText = "Edad";
            this.EdadCol.MinimumWidth = 6;
            this.EdadCol.Name = "EdadCol";
            this.EdadCol.ReadOnly = true;
            this.EdadCol.Width = 125;
            // 
            // SexoCol
            // 
            this.SexoCol.Frozen = true;
            this.SexoCol.HeaderText = "Sexo";
            this.SexoCol.MinimumWidth = 6;
            this.SexoCol.Name = "SexoCol";
            this.SexoCol.ReadOnly = true;
            this.SexoCol.Width = 125;
            // 
            // NacionalidadCol
            // 
            this.NacionalidadCol.Frozen = true;
            this.NacionalidadCol.HeaderText = "Nacionalidad";
            this.NacionalidadCol.MinimumWidth = 6;
            this.NacionalidadCol.Name = "NacionalidadCol";
            this.NacionalidadCol.ReadOnly = true;
            this.NacionalidadCol.Width = 125;
            // 
            // EstadoCivilCol
            // 
            this.EstadoCivilCol.Frozen = true;
            this.EstadoCivilCol.HeaderText = "Estado Civil";
            this.EstadoCivilCol.MinimumWidth = 6;
            this.EstadoCivilCol.Name = "EstadoCivilCol";
            this.EstadoCivilCol.ReadOnly = true;
            this.EstadoCivilCol.Width = 125;
            // 
            // puestoCol
            // 
            this.puestoCol.Frozen = true;
            this.puestoCol.HeaderText = "Puesto";
            this.puestoCol.MinimumWidth = 6;
            this.puestoCol.Name = "puestoCol";
            this.puestoCol.ReadOnly = true;
            this.puestoCol.Width = 125;
            // 
            // sueldoCol
            // 
            this.sueldoCol.Frozen = true;
            this.sueldoCol.HeaderText = "Sueldo";
            this.sueldoCol.MinimumWidth = 6;
            this.sueldoCol.Name = "sueldoCol";
            this.sueldoCol.ReadOnly = true;
            this.sueldoCol.Width = 125;
            // 
            // activoCol
            // 
            this.activoCol.Frozen = true;
            this.activoCol.HeaderText = "Activo";
            this.activoCol.MinimumWidth = 6;
            this.activoCol.Name = "activoCol";
            this.activoCol.ReadOnly = true;
            this.activoCol.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(34, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 72);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Filtrar Datos";
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
            this.btnExportarJSON.Location = new System.Drawing.Point(720, 796);
            this.btnExportarJSON.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportarJSON.Name = "btnExportarJSON";
            this.btnExportarJSON.Size = new System.Drawing.Size(335, 72);
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
            this.btnExportarXML.Location = new System.Drawing.Point(375, 796);
            this.btnExportarXML.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(335, 72);
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
            this.btnExportarTxt.Location = new System.Drawing.Point(1065, 796);
            this.btnExportarTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportarTxt.Name = "btnExportarTxt";
            this.btnExportarTxt.Size = new System.Drawing.Size(335, 72);
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
            this.lblMayorA.Location = new System.Drawing.Point(22, 375);
            this.lblMayorA.Name = "lblMayorA";
            this.lblMayorA.Size = new System.Drawing.Size(133, 48);
            this.lblMayorA.TabIndex = 6;
            this.lblMayorA.Text = "Mayor A:";
            this.lblMayorA.Visible = false;
            // 
            // txtMayorA
            // 
            this.txtMayorA.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMayorA.Location = new System.Drawing.Point(171, 380);
            this.txtMayorA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMayorA.Name = "txtMayorA";
            this.txtMayorA.Size = new System.Drawing.Size(166, 44);
            this.txtMayorA.TabIndex = 7;
            this.txtMayorA.Visible = false;
            // 
            // lstFiltrado
            // 
            this.lstFiltrado.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFiltrado.FormattingEnabled = true;
            this.lstFiltrado.ItemHeight = 36;
            this.lstFiltrado.Items.AddRange(new object[] {
            "Edad",
            "Sexo",
            "Nacionalidad",
            "Estado Civil",
            "Puesto",
            "Sueldo",
            "Activo",
            "Todos"});
            this.lstFiltrado.Location = new System.Drawing.Point(34, 145);
            this.lstFiltrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstFiltrado.Name = "lstFiltrado";
            this.lstFiltrado.Size = new System.Drawing.Size(301, 184);
            this.lstFiltrado.TabIndex = 8;
            this.lstFiltrado.SelectedIndexChanged += new System.EventHandler(this.lstFiltrado_SelectedIndexChanged);
            // 
            // lstOpciones
            // 
            this.lstOpciones.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOpciones.FormattingEnabled = true;
            this.lstOpciones.ItemHeight = 36;
            this.lstOpciones.Location = new System.Drawing.Point(34, 451);
            this.lstOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOpciones.Name = "lstOpciones";
            this.lstOpciones.Size = new System.Drawing.Size(301, 256);
            this.lstOpciones.TabIndex = 9;
            this.lstOpciones.Visible = false;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblFiltrar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltrar.ForeColor = System.Drawing.Color.White;
            this.lblFiltrar.Location = new System.Drawing.Point(67, 360);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(256, 72);
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
            this.btnFiltrar.Location = new System.Drawing.Point(80, 767);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(183, 72);
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
            this.lblError.Location = new System.Drawing.Point(795, 736);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(126, 57);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "ERROR";
            this.lblError.Visible = false;
            // 
            // FormFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 923);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFiltros";
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