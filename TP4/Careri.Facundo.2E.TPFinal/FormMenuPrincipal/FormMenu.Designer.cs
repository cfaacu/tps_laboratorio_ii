﻿
namespace FormMenuPrincipal
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFiltro = new FormMenuPrincipal.BotonPersonalizado();
            this.btnAgregar = new FormMenuPrincipal.BotonPersonalizado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnalisis = new FormMenuPrincipal.BotonPersonalizado();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltro.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFiltro.BorderRadius = 40;
            this.btnFiltro.BorderSize = 0;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Location = new System.Drawing.Point(32, 320);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(500, 86);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.TextColor = System.Drawing.Color.White;
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(32, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(500, 86);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Datos";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 68);
            this.panel1.TabIndex = 5;
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloMenu.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloMenu.ForeColor = System.Drawing.Color.White;
            this.lblTituloMenu.Location = new System.Drawing.Point(32, 100);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(500, 77);
            this.lblTituloMenu.TabIndex = 6;
            this.lblTituloMenu.Text = "Bienvenido Al Analisis";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 51);
            this.panel2.TabIndex = 7;
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
            this.btnAnalisis.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnalisis.ForeColor = System.Drawing.Color.White;
            this.btnAnalisis.Location = new System.Drawing.Point(32, 428);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(500, 86);
            this.btnAnalisis.TabIndex = 8;
            this.btnAnalisis.Text = "Analisis";
            this.btnAnalisis.TextColor = System.Drawing.Color.White;
            this.btnAnalisis.UseVisualStyleBackColor = false;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(32, 180);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(500, 29);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "ERROR";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 585);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTituloMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFiltro);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BotonPersonalizado btnFiltro;
        private BotonPersonalizado btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Panel panel2;
        private BotonPersonalizado btnAnalisis;
        private System.Windows.Forms.Label lblError;
    }
}

