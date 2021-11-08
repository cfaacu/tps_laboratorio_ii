
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
            this.botonPersonalizado1 = new FormMenuPrincipal.BotonPersonalizado();
            this.btnAgregar = new FormMenuPrincipal.BotonPersonalizado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // botonPersonalizado1
            // 
            this.botonPersonalizado1.BackColor = System.Drawing.Color.DodgerBlue;
            this.botonPersonalizado1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.botonPersonalizado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalizado1.BorderRadius = 40;
            this.botonPersonalizado1.BorderSize = 0;
            this.botonPersonalizado1.FlatAppearance.BorderSize = 0;
            this.botonPersonalizado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonPersonalizado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado1.Location = new System.Drawing.Point(32, 396);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(500, 86);
            this.botonPersonalizado1.TabIndex = 3;
            this.botonPersonalizado1.Text = "Analisis";
            this.botonPersonalizado1.TextColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(32, 234);
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
            this.panel1.Size = new System.Drawing.Size(563, 68);
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
            this.panel2.Size = new System.Drawing.Size(563, 51);
            this.panel2.TabIndex = 7;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTituloMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.botonPersonalizado1);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BotonPersonalizado botonPersonalizado1;
        private BotonPersonalizado btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Panel panel2;
    }
}

