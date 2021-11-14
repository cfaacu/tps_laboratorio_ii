using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<Empleado> listAux;
            if (lstFiltrado.SelectedIndex == 0)
            {
                if (int.TryParse(this.txtMayorA.Text, out int edad))
                {
                    listAux = Datos.CalcularEdadMayorA(edad);
                    cantidadFiltrado = listAux.Count;

                    resultado = cantidadFiltrado / cantidadTotal;
                    resultado = resultado * 100;

                    lblResultado.Visible = true;
                    lblResultado.Text = $"El porcentaje de empleados mayores a {edad} años es del {resultado}% ";
                }
            }
            else if (lstFiltrado.SelectedIndex == 1)
            {
                listAux = Datos.CalcularSexo((ESexo)this.lstOpciones.SelectedIndex);
                cantidadFiltrado = listAux.Count;

                resultado = cantidadFiltrado / cantidadTotal;
                resultado = resultado * 100;

                lblResultado.Visible = true;
                lblResultado.Text = $"El porcentaje de empleados cuyo sexo es {(ESexo)this.lstOpciones.SelectedIndex} es del {resultado}% ";
            }
            else if (lstFiltrado.SelectedIndex == 2)
            {
                listAux = Datos.CalcularNacionalidad((ENacionalidad)this.lstOpciones.SelectedIndex);
                cantidadFiltrado = listAux.Count;

                resultado = cantidadFiltrado / cantidadTotal;
                resultado = resultado * 100;

                lblResultado.Visible = true;
                lblResultado.Text = $"El porcentaje de empleados cuya nacionalidad es {(ENacionalidad)this.lstOpciones.SelectedIndex} es del {resultado}% ";
            }
            else if (lstFiltrado.SelectedIndex == 3)
            {
                listAux = Datos.CalcularEstadoCivil((EEstadoCivil)this.lstOpciones.SelectedIndex);
                cantidadFiltrado = listAux.Count;

                resultado = cantidadFiltrado / cantidadTotal;
                resultado = resultado * 100;

                lblResultado.Visible = true;
                lblResultado.Text = $"El porcentaje de empleados cuyo estado civil es {(EEstadoCivil)this.lstOpciones.SelectedIndex} es del {resultado}% ";
            }
            else if (lstFiltrado.SelectedIndex == 4)
            {
                listAux = Datos.CalcularPuesto((EPuesto)this.lstOpciones.SelectedIndex);
                cantidadFiltrado = listAux.Count;

                resultado = cantidadFiltrado / cantidadTotal;
                resultado = resultado * 100;

                lblResultado.Visible = true;
                lblResultado.Text = $"El porcentaje de empleados cuyo puesto de {(EPuesto)this.lstOpciones.SelectedIndex} es del {resultado}% ";
            }
            else if (lstFiltrado.SelectedIndex == 5)
            {
                if (int.TryParse(this.txtMayorA.Text, out int sueldo))
                {
                    listAux = Datos.CalcularSueldoMayorA(sueldo);
                    cantidadFiltrado = listAux.Count;

                    resultado = cantidadFiltrado / cantidadTotal;
                    resultado = resultado * 100;

                    lblResultado.Visible = true;
                    lblResultado.Text = $"El porcentaje de empleados cuyo sueldo es mayor a {sueldo} es del {resultado}% ";
                }
            }
            else if (lstFiltrado.SelectedIndex == 6)
            {
                listAux = Datos.CalcularPuestosActivos();
                cantidadFiltrado = listAux.Count;

                resultado = cantidadFiltrado / cantidadTotal;
                resultado = resultado * 100;

                lblResultado.Visible = true;
                lblResultado.Text = $"El porcentaje de empleados cuyo puesto esta activo es del {resultado}% ";
            }
        }
    }
}
