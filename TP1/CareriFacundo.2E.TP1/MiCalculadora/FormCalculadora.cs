using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor que no recibe parametros
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que wse genera al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo generado al cerrar el formulario del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento generado al estar cerrando el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Metodo que limpia los valores en pantalla
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.lblResultado.Text = "0";
            this.cmbOperador.SelectedIndex = -1;
        }

        /// <summary>
        /// Evento generado al apretar el boton limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Evento generado al apretar el boton operar, calcula el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            double num1;
            double num2;
            string cadena1;
            string cadena2;
            if (string.IsNullOrWhiteSpace((this.cmbOperador.Text).ToString()))
            {
                this.cmbOperador.SelectedIndex = 1;
            }
            else
            {
                if (char.TryParse(this.cmbOperador.SelectedItem.ToString(), out char operando))
                {
                    resultado = (Calculadora.Operar(new Operando(this.txtNumero1.Text), new Operando(this.txtNumero2.Text), operando));
                    if (resultado != double.MinValue)
                    {
                        this.lblResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        this.lblResultado.Text = "Operacion invalida";
                    }

                    cadena1 = this.txtNumero1.Text.Replace(".", ",");
                    if (!double.TryParse(cadena1, out num1))
                    {
                        num1 = 0;
                    }

                    cadena2 = this.txtNumero2.Text.Replace(".", ",");
                    if (!double.TryParse(cadena2, out num2))
                    {
                        num2 = 0;
                    }

                    this.lstOperaciones.Items.Add($"{num1} {operando} {num2} = {this.lblResultado.Text}");
                }
            }           
        }

        /// <summary>
        /// Evento generado al apretar el boton convertir a binario, convierte el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando calculos = new Operando();
            string strResultado;
            string cadena1;
            string cadena2;
            double resultado;
            double num1;
            double num2;
            if (string.IsNullOrWhiteSpace((this.cmbOperador.Text).ToString()))
            {
                this.cmbOperador.SelectedIndex = 1;
            }
            else
            {
                if (char.TryParse(this.cmbOperador.SelectedItem.ToString(), out char operando))
                {
                    resultado = (Calculadora.Operar(new Operando(this.txtNumero1.Text), new Operando(this.txtNumero2.Text), operando));
                    if (resultado != double.MinValue)
                    {
                        this.lblResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        this.lblResultado.Text = "Operacion invalida";
                    }

                    cadena1 = this.txtNumero1.Text.Replace(".", ",");
                    if (!double.TryParse(cadena1, out num1))
                    {
                        num1 = 0;
                    }

                    cadena2 = this.txtNumero2.Text.Replace(".", ",");
                    if (!double.TryParse(cadena2, out num2))
                    {
                        num2 = 0;
                    }

                    strResultado = calculos.DecimalBinario(resultado);
                    if (lblResultado.Text == "Operacion invalida")
                    {
                        this.lstOperaciones.Items.Add($"{lblResultado.Text}");
                    }
                    else
                    {
                        this.lstOperaciones.Items.Add($"{resultado} = {strResultado}");
                    }
                }
            }
        }

        /// <summary>
        /// Evento generado al apretar el boton convertir a decimal, convierte el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando calculos = new Operando();
            double resultado;
            double num1;
            double num2;
            string strResultado;
            string strNumero1;
            string strNumero2;
            string cadena1;
            string cadena2;


            strNumero1 = calculos.BinarioDecimal(this.txtNumero1.Text);
            strNumero2 = calculos.BinarioDecimal(this.txtNumero2.Text);

            cadena1 = this.txtNumero1.Text.Replace(".", ",");
            if (!double.TryParse(cadena1, out num1))
            {
                num1 = 0;
            }

            cadena2 = this.txtNumero2.Text.Replace(".", ",");
            if (!double.TryParse(cadena2, out num2))
            {
                num2 = 0;
            }

            if (string.IsNullOrWhiteSpace((this.cmbOperador.Text).ToString()))
            {
                this.cmbOperador.SelectedIndex = 1;
            }

            if (char.TryParse(this.cmbOperador.SelectedItem.ToString(), out char operando))
            {
                resultado = (Calculadora.Operar(new Operando(strNumero1), new Operando(strNumero2), operando));
                strResultado = calculos.DecimalBinario(resultado);

                this.lblResultado.Text = strResultado;
                if(strResultado == "Valor Invalido")
                {
                    this.lstOperaciones.Items.Add($"Operacion invalida");

                }
                else
                {
                    this.lstOperaciones.Items.Add($"{strResultado} = {resultado}");

                }
            }
        }
    }
}
