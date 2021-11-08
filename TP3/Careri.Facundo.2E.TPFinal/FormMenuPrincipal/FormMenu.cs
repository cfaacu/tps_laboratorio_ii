using Entidades;
using Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                pathXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivo.xml");
                Datos.listaEmpleados = serXml.Leer(pathXml);
            }
            catch(Exception)
            {
                List<Empleado> listAux = new List<Empleado>() {
            new Empleado("Pepe","Alonzo",25,ESexo.Hombre,ENacionalidad.Chile,EEstadoCivil.Casado,EPuesto.Atencion,15000,true),
            new Empleado("Rodolfo", "Benitez", 32, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
            new Empleado("Facundo", "Careri", 21, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            new Empleado("Patricio", "Gomez", 45, ESexo.Hombre, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.CM, 28000, false),
            new Empleado("Roberto", "Carlos", 65, ESexo.Hombre, ENacionalidad.Colombia, EEstadoCivil.Casado, EPuesto.Repositor, 45000, false),
            new Empleado("Carla", "Sport", 48, ESexo.Mujer, ENacionalidad.EEUU, EEstadoCivil.Viudo, EPuesto.RRHH, 65000, true),
            new Empleado("Lazaro", "Vizcaino", 37, ESexo.Hombre, ENacionalidad.EEUU, EEstadoCivil.Divorciado, EPuesto.Administrativo, 89000, true),
            new Empleado("Lourdes", "Antolin", 31, ESexo.Mujer, ENacionalidad.Francia, EEstadoCivil.Viudo, EPuesto.Administrativo, 76500, false),
            new Empleado("Maria", "Santos", 19, ESexo.Mujer, ENacionalidad.Mexico, EEstadoCivil.Divorciado, EPuesto.Repositor, 19800, true),
             new Empleado("Camila", "Amor", 53, ESexo.Mujer, ENacionalidad.Colombia, EEstadoCivil.Soltero, EPuesto.RRHH, 42300, true),
             new Empleado("Elisa", "Rodriguez", 34, ESexo.Mujer, ENacionalidad.Francia, EEstadoCivil.Viudo, EPuesto.Atencion, 32200, true),
             new Empleado("Marwa", "Manrique", 69, ESexo.Mujer, ENacionalidad.Mexico, EEstadoCivil.Casado, EPuesto.Atencion, 29600, false),
             new Empleado("Amanda", "Ribera", 37, ESexo.Mujer, ENacionalidad.EEUU, EEstadoCivil.Divorciado, EPuesto.CM, 32100, false),
             new Empleado("Rodolfo", "Aguado", 67, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Soltero, EPuesto.Administrativo, 23450, true),
             new Empleado("Uxuea", "Mesa", 51, ESexo.Otros, ENacionalidad.Argentina, EEstadoCivil.Divorciado, EPuesto.Atencion, 34560, true),
             new Empleado("Leyre", "Prados", 33, ESexo.Otros, ENacionalidad.Colombia, EEstadoCivil.Casado, EPuesto.CM, 44560, false),
             new Empleado("Fermina", "Sierra", 22, ESexo.Otros, ENacionalidad.EEUU, EEstadoCivil.Soltero, EPuesto.Repositor, 57800, false),
             new Empleado("Arnau", "Betancor", 55, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Viudo, EPuesto.RRHH, 87800, true),
             new Empleado("Arantxa", "Aroca", 18, ESexo.Otros, ENacionalidad.Colombia, EEstadoCivil.Divorciado, EPuesto.CM, 26500, true),
             new Empleado("Nina", "Elvira", 48, ESexo.Mujer, ENacionalidad.Argentina, EEstadoCivil.Casado, EPuesto.Repositor, 21600, true),
             new Empleado("Marcela", "Calero", 30, ESexo.Mujer, ENacionalidad.Mexico, EEstadoCivil.Viudo, EPuesto.Atencion, 22460, false),
            new Empleado("Florin", "Canas", 41, ESexo.Hombre, ENacionalidad.Francia, EEstadoCivil.Casado, EPuesto.Atencion, 27940, true),
            new Empleado("Jordi", "Cabello", 39, ESexo.Hombre, ENacionalidad.Mexico, EEstadoCivil.Soltero, EPuesto.Administrativo, 65900, true)

        };
                Datos.listaEmpleados.AddRange(listAux);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta frmAlta = new FormAlta();
            frmAlta.ShowDialog();
        }



        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            FormAnalisis frmAnalisis = new FormAnalisis();
            frmAnalisis.ShowDialog();
        }
    }
}
