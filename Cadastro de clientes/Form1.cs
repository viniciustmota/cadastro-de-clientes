using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCidade.Text = " ";
            txtCod.Text = " ";
            txtEndereco.Text = " ";
            txtNome.Text = " ";
            lblResultado.Text = " ";
            rbtnSim.Checked = false;
            rbtnNao.Checked = false;
            cbEstado.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Codigo do cliente: " + txtCod.Text + "\n" + "Nome: " + txtNome.Text + "\n" + "Endereço: " + txtEndereco.Text + "\n" + "Cidade: " + txtCidade.Text + "\n" + "Estado: " + cbEstado.Text;
        }
    }
}
