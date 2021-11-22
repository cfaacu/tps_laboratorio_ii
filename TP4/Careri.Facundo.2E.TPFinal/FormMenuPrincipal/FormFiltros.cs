using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormFiltros : Form
    {
        List<Empleado> listAux= new List<Empleado>();
        Serializadora<List<Empleado>> serJson = new Serializadora<List<Empleado>>(ETipo.JSON);
        Serializadora<List<Empleado>> serXml = new Serializadora<List<Empleado>>(ETipo.XML);
        ArchivoTexto txt = new ArchivoTexto();
        string pathXml = string.Empty;
        string pathJson = string.Empty;
        string pathTxt = string.Empty;
        public FormFiltros()
        {
            InitializeComponent();

        }

        private void FormAnalisis_Load(object sender, EventArgs e)
        {
            try
            {
                listAux.AddRange(Datos.listaEmpleados);
                LlenarDataGridView(Datos.listaEmpleados);
            }
            catch (ListVaciaException ex)
            {
                this.lblError.Visible = true;
                this.lblError.Text = ex.Message;
            }
        }

        private void lstFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiltrado.SelectedIndex == 0)
            {
                this.lblFiltrar.Visible = false;
                this.lstOpciones.Visible = false;
                this.lblMayorA.Visible = true;
                this.txtMayorA.Visible = true;
            }
            else if (lstFiltrado.SelectedIndex == 1)
            {
                this.lblFiltrar.Visible = true;
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(ESexo)));
            }
            else if (lstFiltrado.SelectedIndex == 2)
            {
                this.lblFiltrar.Visible = true;
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(ENacionalidad)));
            }
            else if (lstFiltrado.SelectedIndex == 3)
            {
                this.lblFiltrar.Visible = true;
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(EEstadoCivil)));
            }
            else if (lstFiltrado.SelectedIndex == 4)
            {
                this.lblFiltrar.Visible = true;
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
                this.lstOpciones.Visible = true;
                this.lstOpciones.Items.Clear();
                this.lstOpciones.Items.AddRange(Enum.GetNames(typeof(EPuesto)));
            }
            else if (lstFiltrado.SelectedIndex == 5)
            {
                this.lblFiltrar.Visible = false;
                this.lstOpciones.Visible = false;
                this.lblMayorA.Visible = true;
                this.txtMayorA.Visible = true;
            }
            else if (lstFiltrado.SelectedIndex == 6)
            {
                this.lblFiltrar.Visible = false;
                this.lstOpciones.Visible = false;
                this.lblMayorA.Visible = false;
                this.txtMayorA.Visible = false;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (lstFiltrado.SelectedIndex == 0)
            {
                if (int.TryParse(this.txtMayorA.Text, out int edad))
                {
                    listAux = Datos.CalcularEdadMayorA(edad);
                    try
                    {
                        this.dataGridAnalisis.Rows.Clear();
                        LlenarDataGridView(listAux);
                    }
                    catch (ListVaciaException ex)
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = ex.Message;
                    }
                }
                else
                {
                    this.lblError.Text = "Edad incorrecta";
                }
            }
            else if (lstFiltrado.SelectedIndex == 1)
            {
                listAux = Datos.CalcularSexo((ESexo)this.lstOpciones.SelectedIndex);
                try
                {
                    this.dataGridAnalisis.Rows.Clear();
                    LlenarDataGridView(listAux);
                }
                catch (ListVaciaException ex)
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = ex.Message;
                }
            }
            else if (lstFiltrado.SelectedIndex == 2)
            {
                listAux = Datos.CalcularNacionalidad((ENacionalidad)this.lstOpciones.SelectedIndex);
                try
                {
                    this.dataGridAnalisis.Rows.Clear();
                    LlenarDataGridView(listAux);
                }
                catch (ListVaciaException ex)
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = ex.Message;
                }
            }
            else if (lstFiltrado.SelectedIndex == 3)
            {
                listAux = Datos.CalcularEstadoCivil((EEstadoCivil)this.lstOpciones.SelectedIndex);
                try
                {
                    this.dataGridAnalisis.Rows.Clear();
                    LlenarDataGridView(listAux);
                }
                catch (ListVaciaException ex)
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = ex.Message;
                }
            }
            else if (lstFiltrado.SelectedIndex == 4)
            {
                listAux = Datos.CalcularPuesto((EPuesto)this.lstOpciones.SelectedIndex);
                try
                {
                    this.dataGridAnalisis.Rows.Clear();
                    LlenarDataGridView(listAux);
                }
                catch (ListVaciaException ex)
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = ex.Message;
                }
            }
            else if (lstFiltrado.SelectedIndex == 5)
            {
                if (double.TryParse(this.txtMayorA.Text, out double sueldo))
                {
                    listAux = Datos.CalcularSueldoMayorA(sueldo);
                    try
                    {
                        this.dataGridAnalisis.Rows.Clear();
                        LlenarDataGridView(listAux);
                    }
                    catch (ListVaciaException ex)
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = ex.Message;
                    }
                }
                else
                {
                    this.lblError.Text = "Edad incorrecta";
                }
            }
            else if (lstFiltrado.SelectedIndex == 6)
            {
                listAux = Datos.CalcularPuestosActivos();
                try
                {
                    this.dataGridAnalisis.Rows.Clear();
                    LlenarDataGridView(listAux);
                }
                catch (ListVaciaException ex)
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = ex.Message;
                }
            }
            else if (lstFiltrado.SelectedIndex == 7)
            {
                try
                {
                    this.dataGridAnalisis.Rows.Clear();
                    LlenarDataGridView(Datos.listaEmpleados);
                }
                catch (ListVaciaException ex)
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = ex.Message;
                }
            }
        }

        /// <summary>
        /// Carga el DataGridView con los parametros de la lista recibida
        /// </summary>
        /// <param name="listEmp"></param>
        private void LlenarDataGridView(List<Empleado> listEmp)
        {
            string activo = string.Empty;
            if (listEmp.Count != 0)
            {
                foreach (Empleado item in listEmp)
                {
                    if (item.Activo == true)
                    {
                        activo = "Si";
                    }
                    else
                    {
                        activo = "No";
                    }
                    dataGridAnalisis.Rows.Add(item.Nombre, item.Apellido, item.Edad.ToString(), item.Sexo.ToString(), item.Nacionalidad.ToString(), item.EstadoCivil.ToString(), item.Puesto.ToString(), item.Sueldo.ToString(), activo);
                }
            }
            else
            {
                throw new ListVaciaException("La lista no contiene datos.");
            }
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            try
            {
                pathXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Filter.xml");
                serXml.Escribir(listAux, pathXml);
                MessageBox.Show("Archivo XML generado con exito");
            }
            catch (Exception ex)
            {
                this.lblError.Visible = true;
                this.lblError.Text = ex.Message;
            }
        }

        private void btnExportarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                pathJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Filter.json");
                serJson.Escribir(listAux, pathJson);
                MessageBox.Show("Archivo JSON generado con exito");
            }
            catch (Exception ex)
            {
                this.lblError.Visible = true;
                this.lblError.Text = ex.Message;
            }
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder();
            try
            {
                pathTxt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Filter.txt");
                if (listAux is null)
                {
                    listAux.AddRange(Datos.listaEmpleados);
                }

                foreach (Empleado item in listAux)
                {
                    strBuilder.AppendLine($"{item.Nombre}");
                    strBuilder.AppendLine($"{item.Apellido}");
                    strBuilder.AppendLine($"{item.Edad}");
                    strBuilder.AppendLine($"{item.Sexo}");
                    strBuilder.AppendLine($"{item.Nacionalidad}");
                    strBuilder.AppendLine($"{item.EstadoCivil}");
                    strBuilder.AppendLine($"{item.Puesto}");
                    strBuilder.AppendLine($"{item.Sueldo}");
                    strBuilder.AppendLine($"{item.Activo}");
                    strBuilder.AppendLine($"");
                }
                txt.Escribir(strBuilder.ToString(), pathTxt);
                MessageBox.Show("Archivo TXT generado con exito");
            }
            catch (Exception ex)
            {
                this.lblError.Visible = true;
                this.lblError.Text = ex.Message;
            }
        }
    }
}
