using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flagoBrasil
{
    public partial class FormCombinacoes : Form
    {
        private void verifica()
        {
            if(!checkRetangulo.Checked && !checkLosango.Checked && !checkBoxCirculo.Checked)
            {
                labelTexto.Text = "Forma desconhecida";
                pictureBoxFormas.Image = Properties.Resources.duvida;
            }
            else if (checkRetangulo.Checked && !checkLosango.Checked && !checkBoxCirculo.Checked)
            {
                labelTexto.Text = "Retângulo";
                pictureBoxFormas.Image = Properties.Resources.retangulo;
            }
            else if (!checkRetangulo.Checked && checkLosango.Checked && !checkBoxCirculo.Checked)
            {
                labelTexto.Text = "Losango";
                pictureBoxFormas.Image = Properties.Resources.losango;
            }
            else if (!checkRetangulo.Checked && !checkLosango.Checked && checkBoxCirculo.Checked)
            {
                labelTexto.Text = "Circulo";
                pictureBoxFormas.Image = Properties.Resources.circulo;
            }
            else if (checkRetangulo.Checked && !checkLosango.Checked && checkBoxCirculo.Checked)
            {
                labelTexto.Text = "Retângulo e Circulo";
                pictureBoxFormas.Image = Properties.Resources.retangulo_circulo;
            }
            else if (!checkRetangulo.Checked && checkLosango.Checked && checkBoxCirculo.Checked)
            {
                labelTexto.Text = "Losango e Circulo";
                pictureBoxFormas.Image = Properties.Resources.losango_circulo;
            }
            else if (checkRetangulo.Checked && checkLosango.Checked && !checkBoxCirculo.Checked)
            {
                labelTexto.Text = "Retângulo e Losango";
                pictureBoxFormas.Image = Properties.Resources.retangulo_losango;
            }
            else
            {
                labelTexto.Text = "Bandeira";
                pictureBoxFormas.Image = Properties.Resources.bandeira;
            }

        }
        public FormCombinacoes()
        {
            InitializeComponent();
        }

        private void pictureBoxFormas_Click(object sender, EventArgs e)
        {

        }

        private void checkRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void checkLosango_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void checkBoxCirculo_CheckedChanged(object sender, EventArgs e)
        {
            verifica();
        }
    }
}
