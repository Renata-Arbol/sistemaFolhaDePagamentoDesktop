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
using DesktopPim;

namespace Adicionar_Funcionário.Apresentacao
{
    public partial class FrmEditarFuncionario : Form
    {
        public FrmEditarFuncionario()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            frmEditarDependentes frmEditarDependentes = new frmEditarDependentes() { Frm = this };
            frmEditarDependentes.Show();
            this.Hide();
        }

        private void FrmEditarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

         
            List<Funcionario> listaFuncionarios = controle.pesquisar(txbNomeCompleto.Text);
            Endereco endereco = controle.PesquisarEndereco(listaFuncionarios[0]);
            if (listaFuncionarios == null || listaFuncionarios.Count() == 0)
            {
                MessageBox.Show(controle.mensagem);
            }
            if (listaFuncionarios.Count() == 1)
            {
                txbID.Text = listaFuncionarios[0].IdFuncionario.ToString();
                txbNomeCompleto.Text = listaFuncionarios[0].NomeCompleto;
                txbRG.Text = listaFuncionarios[0].Rg;
                txbCPF.Text = listaFuncionarios[0].Cpf;
                txbGenero.Text = listaFuncionarios[0].Sexo;
                txbEstadoCivil.Text = listaFuncionarios[0].EstadoCivil;
                txbDataNascimento.Text = listaFuncionarios[0].DataNasc;
                txbNacionalidade.Text = listaFuncionarios[0].Nacionalidade;
                txbEmail.Text= listaFuncionarios[0].Email;
                txbEndereco.Text = endereco.Rua;
                txbNumero.Text = endereco.Numero;
                txbBairro.Text= endereco.Bairro;
                txbUF.Text = endereco.Uf;
                txbTelefone.Text = listaFuncionarios[0].Telefone;
                txbPIS.Text = listaFuncionarios[0].Pis;
                txbCEP.Text = endereco.Cep;
            }
            if (listaFuncionarios.Count() > 1)
            {
                Estaticos.listaFuncionario = listaFuncionarios;
                txbID.Text = Estaticos.funcionario.IdFuncionario.ToString();
                txbNomeCompleto.Text = Estaticos.funcionario.NomeCompleto;
                txbRG.Text = Estaticos.funcionario.Rg;
                txbCPF.Text = Estaticos.funcionario.Cpf;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
            this.Hide();
        }
    }
    
}
