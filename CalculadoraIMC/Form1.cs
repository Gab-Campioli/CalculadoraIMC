using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txbAlt.Text, out double alt) && double.TryParse(txbPeso.Text, out double peso))
            {

                if (peso <= 0)
                {
                    MessageBox.Show("O peso deve ser maior que zero.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (alt <= 0)
                {
                    MessageBox.Show("A altura deve ser maior que zero.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    alt = double.Parse(txbAlt.Text);
                    peso = double.Parse(txbPeso.Text);

                    double imc = peso/(alt*alt);

                    txbResultado.Text = imc.ToString("F2");

                    txbAlt.Enabled = false;
                    txbPeso.Enabled = false;

                    if (imc < 18.5)
                    {
                        lblMostrarClass.Text = "Abaixo do peso";
                        lblMostrarClass.ForeColor = Color.Orange;
                        txbResultado.Enabled = false;
                    }
                    else if (imc < 25)
                    {
                        lblMostrarClass.Text = "Peso ideal";
                        lblMostrarClass.ForeColor = Color.Green;
                        txbResultado.Enabled = false;
                    }
                    else if (imc < 30)
                    {
                        lblMostrarClass.Text = "Sobrepeso";
                        lblMostrarClass.ForeColor = Color.Red;
                        txbResultado.Enabled = false;
                    }
                    else if (imc < 35)
                    {
                        lblMostrarClass.Text = "Obesidade grau I";
                        lblMostrarClass.ForeColor = Color.Red;
                        txbResultado.Enabled = false;
                    }
                    else if (imc < 40)
                    {
                        lblMostrarClass.Text = "Obesidade grau II";
                        lblMostrarClass.ForeColor = Color.Red;
                        txbResultado.Enabled = false;
                    }
                    else
                    {
                        lblMostrarClass.Text = "Obesidade grau III";
                        lblMostrarClass.ForeColor = Color.Red;
                        txbResultado.Enabled = false;
                    }
                }
            }
            else 
            {
                MessageBox.Show("Insira um valor válido.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                txbAlt.Focus();
            }
        }

        private void txbAlt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnCalcular.PerformClick();
            }
        }
    }
}
