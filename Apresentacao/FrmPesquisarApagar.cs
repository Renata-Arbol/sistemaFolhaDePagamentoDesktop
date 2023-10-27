using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adicionar_Funcionario.Modelo;
using Adicionar_Funcionário.Modelo;
using Adicionar_Funcionário.Apresentacao;
using DesktopPim;

namespace Adicionar_Funcionário.Apresentacao
{
    public partial class FrmPesquisarApagar : Form
    {
        public FrmPesquisarApagar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            frmApagarFuncionario frmApagarFuncionario = new frmApagarFuncionario();
            frmApagarFuncionario.ShowDialog();
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            frmApagarFuncionario frmApagarFuncionario = new frmApagarFuncionario();
            frmApagarFuncionario.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
            this.Hide();
        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            frmDadosFuncionario frmDadosFuncionario = new frmDadosFuncionario();


            List<Funcionario> listaFuncionarios = controle.pesquisar(frmDadosFuncionario.txbNomeCompleto.Text);
            if (listaFuncionarios == null || listaFuncionarios.Count() == 0)
            {
                MessageBox.Show(controle.mensagem);
            }
            if (listaFuncionarios.Count() == 1)
            {
                frmDadosFuncionario.txbidFuncionario.Text = listaFuncionarios[0].IdFuncionario.ToString();
                frmDadosFuncionario.txbNomeCompleto.Text = listaFuncionarios[0].NomeCompleto;
                frmDadosFuncionario.txbRG.Text = listaFuncionarios[0].Rg;
                frmDadosFuncionario.txbCPF.Text = listaFuncionarios[0].Cpf;
            }
            if (listaFuncionarios.Count() > 1)
            {
                Estaticos.listaFuncionario = listaFuncionarios;
                frmDadosFuncionario.txbidFuncionario.Text = Estaticos.funcionario.IdFuncionario.ToString();
                frmDadosFuncionario.txbNomeCompleto.Text = Estaticos.funcionario.NomeCompleto;
                frmDadosFuncionario.txbRG.Text = Estaticos.funcionario.Rg;
                frmDadosFuncionario.txbCPF.Text = Estaticos.funcionario.Cpf;
            }

        }
    }
}
