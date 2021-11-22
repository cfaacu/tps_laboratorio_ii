using Entidades;
using Entidades.Clases;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public delegate void AgregarEmpleado(Empleado emp);
    public partial class FormAlta : Form
    {

        public AgregarEmpleado agregarEmpleado;
        public FormAlta()
        {
            InitializeComponent();
            InitializeComboBox();
            agregarEmpleado = Datos.listaEmpleados.Add;
            agregarEmpleado += DB.AgregarDatos;
        }
        

        /// <summary>
        /// Carga todos los comboBox con los enumerados segun el tipo
        /// </summary>
        private void InitializeComboBox()
        {
            this.cmbEstadoCivil.Items.AddRange(Enum.GetNames(typeof(EEstadoCivil)));
            this.cmbNacionalidad.Items.AddRange(Enum.GetNames(typeof(ENacionalidad)));
            this.cmbPuesto.Items.AddRange(Enum.GetNames(typeof(EPuesto)));
            this.cmbSexo.Items.AddRange(Enum.GetNames(typeof(ESexo)));
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(this.txtSueldo.Text, out double sueldo))
                {
                    if (Validacion.ValidarCampos(this.txtNombre.Text, this.txtApellido.Text, (int)this.numEdad.Value, (ESexo)this.cmbSexo.SelectedIndex,
                       (ENacionalidad)this.cmbNacionalidad.SelectedIndex, (EEstadoCivil)this.cmbEstadoCivil.SelectedIndex, (EPuesto)this.cmbPuesto.SelectedIndex, sueldo, this.chkActivo.Checked))
                    {
                        Empleado empleadoAux = new Empleado(this.txtNombre.Text, this.txtApellido.Text, (int)this.numEdad.Value, (ESexo)this.cmbSexo.SelectedIndex,
                       (ENacionalidad)this.cmbNacionalidad.SelectedIndex, (EEstadoCivil)this.cmbEstadoCivil.SelectedIndex, (EPuesto)this.cmbPuesto.SelectedIndex, sueldo, this.chkActivo.Checked);

                        if (!(empleadoAux is null))
                        {
                            agregarEmpleado(empleadoAux);
                            this.Close();
                        }
                    }
                }
                else
                {
                    throw new DatosInvalidosException("Error al cargar los datos");
                }
            }
            catch (DatosInvalidosException datosInvalidos)
            {
                this.lblError.Visible = true;
                this.lblError.Text = datosInvalidos.Message;
            }
        }
    }
}
