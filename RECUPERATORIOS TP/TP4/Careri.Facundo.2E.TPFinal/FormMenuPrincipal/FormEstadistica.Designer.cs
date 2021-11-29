
namespace Formularios
{
    partial class FormEstadistica
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
            this.lstFiltroSimple = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstFiltroCombinado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFiltroSimple
            // 
            this.lstFiltroSimple.BackColor = System.Drawing.Color.White;
            this.lstFiltroSimple.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFiltroSimple.FormattingEnabled = true;
            this.lstFiltroSimple.ItemHeight = 29;
            this.lstFiltroSimple.Location = new System.Drawing.Point(12, 86);
            this.lstFiltroSimple.Name = "lstFiltroSimple";
            this.lstFiltroSimple.Size = new System.Drawing.Size(715, 584);
            this.lstFiltroSimple.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(622, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 58);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Estadisticas";
            // 
            // lstFiltroCombinado
            // 
            this.lstFiltroCombinado.BackColor = System.Drawing.Color.White;
            this.lstFiltroCombinado.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFiltroCombinado.FormattingEnabled = true;
            this.lstFiltroCombinado.ItemHeight = 29;
            this.lstFiltroCombinado.Location = new System.Drawing.Point(733, 86);
            this.lstFiltroCombinado.Name = "lstFiltroCombinado";
            this.lstFiltroCombinado.Size = new System.Drawing.Size(704, 584);
            this.lstFiltroCombinado.TabIndex = 4;
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1449, 788);
            this.Controls.Add(this.lstFiltroCombinado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstFiltroSimple);
            this.Name = "FormEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica";
            this.Load += new System.EventHandler(this.FormEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiltroSimple;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstFiltroCombinado;
    }
}