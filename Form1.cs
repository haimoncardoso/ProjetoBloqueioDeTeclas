using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Bloqueio_De_Letras
{
    public partial class Frmbloqueio : Form
    {
        public Frmbloqueio()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar))) //Não é permitido Letras
            {
                e.Handled = true;
                MessageBox.Show("Não é permitido digitar letras!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtLetras1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) //Somente letras E ativando o BackSpace
            {
                e.Handled = true;
                MessageBox.Show("Somente Letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Somente Letras!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtNumeros2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Somente Numeros!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCaracteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Não é Permitido Caracteres Especiais!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtEspeciais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente caracteres Especiais!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtEspecificas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bloqueando a tecla ESC
            if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                MessageBox.Show("Não é Permitido A Tecla  ESC!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtEspecificas2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Desbloqueando a tecla Esc
            if (!(e.KeyChar == (char)Keys.Escape))
                e.Handled = true;
            MessageBox.Show("Somente a Tecla Esc", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Frmbloqueio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja sair do Programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) // Programando os Botões Yes/No
                e.Cancel = true;
        }

        private void Frmbloqueio_Load(object sender, EventArgs e)
        {

        }
    }
}
