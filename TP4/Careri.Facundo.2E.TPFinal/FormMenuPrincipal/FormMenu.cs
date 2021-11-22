using Entidades;
using Entidades.Clases;
using Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormMenuPrincipal
{
    public partial class FormMenu : Form
    {
        Serializadora<List<Empleado>> serJson = new Serializadora<List<Empleado>>(ETipo.JSON);
        Serializadora<List<Empleado>> serXml = new Serializadora<List<Empleado>>(ETipo.XML);
        string pathXml = string.Empty;
        public FormMenu()
        {
            InitializeComponent();
        }

        private async void FormMenu_Load(object sender, EventArgs e)
        {
            this.lblError.Visible = true;
            this.lblError.Text = "Cargando Datos...";
            this.btnAnalisis.Enabled = false;
            this.btnFiltro.Enabled = false;
            await Task.Run(CargarDatos); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta frmAlta = new FormAlta();
            frmAlta.ShowDialog();
        }



        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            FormFiltros frmFiltros = new FormFiltros();
            frmFiltros.ShowDialog();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            FormAnalisis frmAnalisis = new FormAnalisis();
            frmAnalisis.ShowDialog();
        }

        private void CargarDatos()
        {
            Thread.Sleep(10000);
            try
            {
                List<Empleado> listAux = DB.RecuperarDatos();
                Datos.listaEmpleados.AddRange(listAux);
            }
            catch(Exception)
            {
                throw;
            }


            if (this.lblError.InvokeRequired) // DA TRUE CUANDO NO ES DEL HILO PRINCIPAL 
            {
                this.lblError.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = "Datos Cargados con exito";
                    this.lblError.ForeColor = Color.Green;
                    this.Refresh();
                    this.btnAnalisis.Enabled = true;
                    this.btnFiltro.Enabled = true;
                    Thread.Sleep(2000);
                    this.lblError.Visible = false;
                });

            }
        }
    }
}
