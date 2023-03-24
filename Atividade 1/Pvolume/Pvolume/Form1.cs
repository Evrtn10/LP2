using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        double raio, altura, volume; /*globais */
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if ((!double.TryParse(txtRaio.Text, out raio)) || 
                    (!double.TryParse(txtAltura.Text, out altura)))
                {
                MessageBox.Show("Valores Inválidos");
            }
            else
            {
                if ((altura<=0) || (raio<=0))
                {
                    MessageBox.Show("Valores não podem ser <=0");
                }
                else
                {
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtResultado.Text = volume.ToString("N2");
                }
            }
        }

        private void TxtRaio_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Raio Inválido");
            }
        }

        private void TxtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura Inválido");
            }
            else
                if (altura <=0)
            {
                MessageBox.Show("Altura deve ser maior que zero"); //textBox2.focus();
            }
        }
    }
}
