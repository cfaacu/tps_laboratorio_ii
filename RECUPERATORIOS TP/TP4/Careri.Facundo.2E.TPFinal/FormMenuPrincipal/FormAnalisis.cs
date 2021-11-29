using Entidades;
using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;

namespace Formularios
{
    public partial class FormAnalisis : Form
    {
        public FormAnalisis()
        {
            InitializeComponent();
        }

        private void FormAnalisis_Load(object sender, EventArgs e)
        {
            this.lblResultado.Visible = false;
        }
        private void lstFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiltrado.SelectedIndex == 0)
            {
                this.lstOpciones.Visible = false;
                this.lblMayorA.Visible = true;
                this.txtMayorA.Visible = true;
            }
            else if (lstFiltrado.SelectedIndex == 1)
            {
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(ESexo)));
            }
            else if (lstFiltrado.SelectedIndex == 2)
            {
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(ENacionalidad)));
            }
            else if (lstFiltrado.SelectedIndex == 3)
            {
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(EEstadoCivil)));
            }
            else if (lstFiltrado.SelectedIndex == 4)
            {
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(EPuesto)));
            }
            else if (lstFiltrado.SelectedIndex == 5)
            {
                this.lstOpciones.Visible = false;
                this.lblMayorA.Visible = true;
                this.txtMayorA.Visible = true;
            }
            else if (lstFiltrado.SelectedIndex == 6)
            {
                this.lstOpciones.Visible = false;
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
            }
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            float cantidadTotal = Datos.listaEmpleados.Count;
            float cantidadFiltrado;
            float resultado;
            Analisis.IndicarMayorA25 += () => this.lblResultado.ForeColor = Color.Red;
            Analisis.IndicarMayorA50 += () => this.lblResultado.ForeColor = Color.Orange;
            Analisis.IndicarMayorA80 += () => this.lblResultado.ForeColor = Color.Green;
            Analisis.IndicarMayorA0 += () => this.lblResultado.ForeColor = Color.Black;
            List<Empleado> listAux;
            if (lstFiltrado.SelectedIndex == 0)
            {
                if (int.TryParse(this.txtMayorA.Text, out int edad))
                {
                    listAux = Datos.CalcularEdadMayorA(edad,Datos.listaEmpleados);
                    cantidadFiltrado = listAux.Count;

                    resultado = Analisis.CalcularPorcentajeConEvento(cantidadFiltrado, cantidadTotal);

                    lblResultado.Visible = true;
                    this.lblResultado.Text = lblResultado.Text.Porcentaje(edad, resultado);
                }
            }
            else if (lstFiltrado.SelectedIndex == 1)
            {
                listAux = Datos.CalcularSexo((ESexo)this.lstOpciones.SelectedIndex, Datos.listaEmpleados);
                cantidadFiltrado = listAux.Count;

                resultado = Analisis.CalcularPorcentajeConEvento(cantidadFiltrado, cantidadTotal);

                lblResultado.Visible = true;
                this.lblResultado.Text = lblResultado.Text.Porcentaje((ESexo)this.lstOpciones.SelectedIndex, resultado);
            }
            else if (lstFiltrado.SelectedIndex == 2)
            {
                listAux = Datos.CalcularNacionalidad((ENacionalidad)this.lstOpciones.SelectedIndex, Datos.listaEmpleados);
                cantidadFiltrado = listAux.Count;

                resultado = Analisis.CalcularPorcentajeConEvento(cantidadFiltrado, cantidadTotal);

                lblResultado.Visible = true;
                lblResultado.Text = lblResultado.Text.Porcentaje((ENacionalidad)this.lstOpciones.SelectedIndex, resultado);
            }
            else if (lstFiltrado.SelectedIndex == 3)
            {
                listAux = Datos.CalcularEstadoCivil((EEstadoCivil)this.lstOpciones.SelectedIndex, Datos.listaEmpleados);
                cantidadFiltrado = listAux.Count;

                resultado = Analisis.CalcularPorcentajeConEvento(cantidadFiltrado, cantidadTotal);

                lblResultado.Visible = true;
                lblResultado.Text = lblResultado.Text.Porcentaje((EEstadoCivil)this.lstOpciones.SelectedIndex,resultado);
            }
            else if (lstFiltrado.SelectedIndex == 4)
            {
                listAux = Datos.CalcularPuesto((EPuesto)this.lstOpciones.SelectedIndex, Datos.listaEmpleados);
                cantidadFiltrado = listAux.Count;

                resultado = Analisis.CalcularPorcentajeConEvento(cantidadFiltrado, cantidadTotal);

                lblResultado.Visible = true;
                lblResultado.Text = lblResultado.Text.Porcentaje((EPuesto)this.lstOpciones.SelectedIndex, resultado);
            }
            else if (lstFiltrado.SelectedIndex == 5)
            {
                if (double.TryParse(this.txtMayorA.Text, out double sueldo))
                {
                    listAux = Datos.CalcularSueldoMayorA(sueldo, Datos.listaEmpleados);
                    cantidadFiltrado = listAux.Count;

                    resultado = Analisis.CalcularPorcentajeConEvento(cantidadFiltrado, cantidadTotal);

                    lblResultado.Visible = true;
                    lblResultado.Text = lblResultado.Text.Porcentaje(sueldo, resultado);
                }
            }
            else if (lstFiltrado.SelectedIndex == 6)
            {
                listAux = Datos.CalcularPuestosActivos(Datos.listaEmpleados);
                cantidadFiltrado = listAux.Count;

                resultado = Analisis.CalcularPorcentajeConEvento(cantidadFiltrado, cantidadTotal);

                lblResultado.Visible = true;
                lblResultado.Text = $"El porcentaje de empleados cuyo puesto esta activo es del {resultado}% ";
            }
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            FormEstadistica frmEstadistica = new FormEstadistica();
            frmEstadistica.Show();
        }
    }
}
