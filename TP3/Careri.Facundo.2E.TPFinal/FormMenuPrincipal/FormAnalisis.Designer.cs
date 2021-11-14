
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAnalisis = new FormMenuPrincipal.BotonPersonalizado();
            this.lstFiltrado = new System.Windows.Forms.ListBox();
            this.lblMayorA = new System.Windows.Forms.Label();
            this.txtMayorA = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lstOpciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(275, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 72);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Analisis De Datos";
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAnalisis.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnAnalisis.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnalisis.BorderRadius = 40;
            this.btnAnalisis.BorderSize = 0;
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalisis.ForeColor = System.Drawing.Color.White;
            this.btnAnalisis.Location = new System.Drawing.Point(289, 432);
            this.btnAnalisis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(335, 72);
            this.btnAnalisis.TabIndex = 4;
            this.btnAnalisis.Text = "Analizar";
            this.btnAnalisis.TextColor = System.Drawing.Color.White;
            this.btnAnalisis.UseVisualStyleBackColor = false;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
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
            "Activo"});
            this.lstFiltrado.Location = new System.Drawing.Point(37, 165);
            this.lstFiltrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstFiltrado.Name = "lstFiltrado";
            this.lstFiltrado.Size = new System.Drawing.Size(301, 184);
            this.lstFiltrado.TabIndex = 9;
            this.lstFiltrado.SelectedIndexChanged += new System.EventHandler(this.lstFiltrado_SelectedIndexChanged);
            // 
            // lblMayorA
            // 
            this.lblMayorA.AutoSize = true;
            this.lblMayorA.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblMayorA.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMayorA.ForeColor = System.Drawing.Color.White;
            this.lblMayorA.Location = new System.Drawing.Point(433, 226);
            this.lblMayorA.Name = "lblMayorA";
            this.lblMayorA.Size = new System.Drawing.Size(151, 52);
            this.lblMayorA.TabIndex = 10;
            this.lblMayorA.Text = "Mayor a :";
            this.lblMayorA.Visible = false;
            // 
            // txtMayorA
            // 
            this.txtMayorA.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMayorA.Location = new System.Drawing.Point(610, 231);
            this.txtMayorA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMayorA.Name = "txtMayorA";
            this.txtMayorA.Size = new System.Drawing.Size(166, 44);
            this.txtMayorA.TabIndex = 12;
            this.txtMayorA.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 551);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(876, 156);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "label1";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstOpciones
            // 
            this.lstOpciones.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOpciones.FormattingEnabled = true;
            this.lstOpciones.ItemHeight = 36;
            this.lstOpciones.Location = new System.Drawing.Point(541, 144);
            this.lstOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOpciones.Name = "lstOpciones";
            this.lstOpciones.Size = new System.Drawing.Size(301, 256);
            this.lstOpciones.TabIndex = 14;
            this.lstOpciones.Visible = false;
            // 
            // FormAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 710);
            this.Controls.Add(this.lstOpciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtMayorA);
            this.Controls.Add(this.lblMayorA);
            this.Controls.Add(this.lstFiltrado);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormAnalisis";
            this.Text = "FormAnalisis";
            this.Load += new System.EventHandler(this.FormAnalisis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private FormMenuPrincipal.BotonPersonalizado btnAnalisis;
        private System.Windows.Forms.ListBox lstFiltrado;
        private System.Windows.Forms.Label lblMayorA;
        private System.Windows.Forms.TextBox txtMayorA;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox lstOpciones;
    }
}