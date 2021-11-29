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

namespace Formularios
{
    public partial class FormEstadistica : Form
    {
        public FormEstadistica()
        {
            InitializeComponent();

        }

        private void FormEstadistica_Load(object sender, EventArgs e)
        {
            this.CargarListBoxSimple();
            this.CargarListBoxCombinado();
        }

        /// <summary>
        /// Carga la listBoxSimple con los porcentajes generales de todos los datos del sistema.
        /// </summary>
        private void CargarListBoxSimple()
        {
            List<Empleado> listAux;
            float resultado;

            #region Sexo
            listAux = Datos.CalcularSexo(ESexo.Mujer, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de MUJERES en la empresa es del {resultado}%");
            listAux = Datos.CalcularSexo(ESexo.Hombre, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de HOMBRES en la empresa es del {resultado}%");
            listAux = Datos.CalcularSexo(ESexo.Otros, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de OTROS en la empresa es del {resultado}%");
            this.lstFiltroSimple.Items.Add("");
            #endregion
            #region Nacionalidad
            listAux = Datos.CalcularNacionalidad(ENacionalidad.Argentina, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de ARGENTINOS en la empresa es del {resultado}%");
            listAux = Datos.CalcularNacionalidad(ENacionalidad.Chile, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de CHILENOS en la empresa es del {resultado}%");
            listAux = Datos.CalcularNacionalidad(ENacionalidad.Colombia, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de COLOMBIANOS en la empresa es del {resultado}%");
            listAux = Datos.CalcularNacionalidad(ENacionalidad.EEUU, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de ESTADOUNIDENSES en la empresa es del {resultado}%");
            listAux = Datos.CalcularNacionalidad(ENacionalidad.Francia, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de FRANCESES en la empresa es del {resultado}%");
            listAux = Datos.CalcularNacionalidad(ENacionalidad.Mexico, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de MEXICANOS en la empresa es del {resultado}%");
            this.lstFiltroSimple.Items.Add("");
            #endregion
            #region Estado Civil
            listAux = Datos.CalcularEstadoCivil(EEstadoCivil.Casado, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de empleados CASADOS en la empresa es del {resultado}%");
            listAux = Datos.CalcularEstadoCivil(EEstadoCivil.Divorciado, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de empleados DIVORCIADOS en la empresa es del {resultado}%");
            listAux = Datos.CalcularEstadoCivil(EEstadoCivil.Soltero, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de empleados SOLTEROS en la empresa es del {resultado}%");
            listAux = Datos.CalcularEstadoCivil(EEstadoCivil.Viudo, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de empleados VIUDOS en la empresa es del {resultado}%");
            this.lstFiltroSimple.Items.Add("");
            #endregion
            #region Puesto
            listAux = Datos.CalcularPuesto(EPuesto.Atencion, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de empleados de ATENCION AL PUBLICO en la empresa es del {resultado}%");
            listAux = Datos.CalcularPuesto(EPuesto.Administrativo, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de ADMINISTRATIVOS en la empresa es del {resultado}%");
            listAux = Datos.CalcularPuesto(EPuesto.CM, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje de COMMUNITY MANAGER en la empresa es del {resultado}%");
            listAux = Datos.CalcularPuesto(EPuesto.Repositor, Datos.listaEmpleados);
            resultado = Analisis.CalcularPorcentaje(listAux.Count, Datos.listaEmpleados.Count);
            this.lstFiltroSimple.Items.Add($"El porcentaje REPOSITORES en la empresa es del {resultado}%");
            this.lstFiltroSimple.Items.Add("");
            #endregion
        }

        /// <summary>
        /// Carga la ListBoxCombinado con los porcentajes del puesto y el porcentaje que coincide con ese puesto
        /// </summary>
        private void CargarListBoxCombinado()
        {
            List<Empleado> listAuxUno;
            List<Empleado> listAuxDos;
            float resultadoUno;
            float resultadoDos;

            listAuxUno = Datos.CalcularPuesto(EPuesto.Atencion, Datos.listaEmpleados);
            resultadoUno = Analisis.CalcularPorcentaje(listAuxUno.Count, Datos.listaEmpleados.Count);
            this.lstFiltroCombinado.Items.Add($"El porcentaje de empleados de ATENCION AL PUBLICO es de {resultadoUno}% de los cuales:");
            listAuxDos = Datos.CalcularEdadMayorA(45, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son mayores a 45 AÑIOS");
            listAuxDos = Datos.CalcularSexo(ESexo.Hombre, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son HOMBRES");
            listAuxDos = Datos.CalcularSexo(ESexo.Mujer, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MUJERES");
            listAuxDos = Datos.CalcularSexo(ESexo.Otros, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son OTROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Casado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CASADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Divorciado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son DIVORSIADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Soltero, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son SOLTEROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Viudo, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son VIUDOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Argentina, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ARGENTINOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Chile, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CHILENOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Colombia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son COLOMBIANOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.EEUU, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ESTADOUNIDENSES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Francia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son FRANCESES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Mexico, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MEXICANOS");
            this.lstFiltroCombinado.Items.Add($"");

            listAuxUno = Datos.CalcularPuesto(EPuesto.Administrativo, Datos.listaEmpleados);
            resultadoUno = Analisis.CalcularPorcentaje(listAuxUno.Count, Datos.listaEmpleados.Count);
            this.lstFiltroCombinado.Items.Add($"El porcentaje de empleados ADMINISTRATIVOS es de {resultadoUno}% de los cuales:");
            listAuxDos = Datos.CalcularEdadMayorA(45, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son mayores a 45 AÑIOS");
            listAuxDos = Datos.CalcularSexo(ESexo.Hombre, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son HOMBRES");
            listAuxDos = Datos.CalcularSexo(ESexo.Mujer, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MUJERES");
            listAuxDos = Datos.CalcularSexo(ESexo.Otros, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son OTROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Casado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CASADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Divorciado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son DIVORSIADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Soltero, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son SOLTEROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Viudo, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son VIUDOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Argentina, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ARGENTINOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Chile, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CHILENOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Colombia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son COLOMBIANOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.EEUU, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ESTADOUNIDENSES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Francia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son FRANCESES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Mexico, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MEXICANOS");
            this.lstFiltroCombinado.Items.Add($"");

            listAuxUno = Datos.CalcularPuesto(EPuesto.CM, Datos.listaEmpleados);
            resultadoUno = Analisis.CalcularPorcentaje(listAuxUno.Count, Datos.listaEmpleados.Count);
            this.lstFiltroCombinado.Items.Add($"El porcentaje de COMMUNITY MANAGER es de {resultadoUno}% de los cuales:");
            listAuxDos = Datos.CalcularEdadMayorA(45, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son mayores a 45 AÑIOS");
            listAuxDos = Datos.CalcularSexo(ESexo.Hombre, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son HOMBRES");
            listAuxDos = Datos.CalcularSexo(ESexo.Mujer, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MUJERES");
            listAuxDos = Datos.CalcularSexo(ESexo.Otros, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son OTROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Casado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CASADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Divorciado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son DIVORSIADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Soltero, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son SOLTEROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Viudo, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son VIUDOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Argentina, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ARGENTINOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Chile, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CHILENOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Colombia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son COLOMBIANOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.EEUU, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ESTADOUNIDENSES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Francia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son FRANCESES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Mexico, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MEXICANOS");
            this.lstFiltroCombinado.Items.Add($"");

            listAuxUno = Datos.CalcularPuesto(EPuesto.Repositor, Datos.listaEmpleados);
            resultadoUno = Analisis.CalcularPorcentaje(listAuxUno.Count, Datos.listaEmpleados.Count);
            this.lstFiltroCombinado.Items.Add($"El porcentaje de REPOSITORES es de {resultadoUno}% de los cuales:");
            listAuxDos = Datos.CalcularEdadMayorA(45, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son mayores a 45 AÑIOS");
            listAuxDos = Datos.CalcularSexo(ESexo.Hombre, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son HOMBRES");
            listAuxDos = Datos.CalcularSexo(ESexo.Mujer, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MUJERES");
            listAuxDos = Datos.CalcularSexo(ESexo.Otros, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son OTROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Casado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CASADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Divorciado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son DIVORSIADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Soltero, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son SOLTEROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Viudo, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son VIUDOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Argentina, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ARGENTINOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Chile, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CHILENOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Colombia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son COLOMBIANOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.EEUU, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ESTADOUNIDENSES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Francia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son FRANCESES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Mexico, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MEXICANOS");
            this.lstFiltroCombinado.Items.Add($"");

            listAuxUno = Datos.CalcularPuesto(EPuesto.RRHH, Datos.listaEmpleados);
            resultadoUno = Analisis.CalcularPorcentaje(listAuxUno.Count, Datos.listaEmpleados.Count);
            this.lstFiltroCombinado.Items.Add($"El porcentaje de empleados de RECURSOS HUMANOS es de {resultadoUno}% de los cuales:");
            listAuxDos = Datos.CalcularEdadMayorA(45, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son mayores a 45 AÑIOS");
            listAuxDos = Datos.CalcularSexo(ESexo.Hombre, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son HOMBRES");
            listAuxDos = Datos.CalcularSexo(ESexo.Mujer, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MUJERES");
            listAuxDos = Datos.CalcularSexo(ESexo.Otros, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son OTROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Casado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CASADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Divorciado, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son DIVORSIADOS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Soltero, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son SOLTEROS");
            listAuxDos = Datos.CalcularEstadoCivil(EEstadoCivil.Viudo, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son VIUDOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Argentina, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ARGENTINOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Chile, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son CHILENOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Colombia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son COLOMBIANOS");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.EEUU, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son ESTADOUNIDENSES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Francia, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son FRANCESES");
            listAuxDos = Datos.CalcularNacionalidad(ENacionalidad.Mexico, listAuxUno);
            resultadoDos = Analisis.CalcularPorcentaje(listAuxDos.Count, listAuxUno.Count);
            this.lstFiltroCombinado.Items.Add($"     {resultadoDos}% son MEXICANOS");
            this.lstFiltroCombinado.Items.Add($"");
        }
    }
}
