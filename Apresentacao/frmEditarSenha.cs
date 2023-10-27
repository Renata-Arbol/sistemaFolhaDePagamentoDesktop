using Adicionar_Funcionario.Modelo;
using Adicionar_Funcionário.Modelo;
using DesktopPim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_Funcionário.Apresentacao
{
    public partial class frmEditarSenha : Form
    {
        public FrmEditarCargosadosBanc Frm { get; set; }
        public Funcionario Funcionario { get; set; }

        public frmEditarSenha()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btnEditarSenha_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();

            Senha senha = new Senha()
            {

                Criarsenha = txbCriarSenha.Text,
                Confimarsenha = txbConfirmarSenha.Text
            };

            FrmEditarFuncionario frmEditarFuncionario = Frm.Frm.Frm;
            Endereco endereco = new Endereco()
            {
                Bairro = frmEditarFuncionario.txbBairro.Text,
                Uf = frmEditarFuncionario.txbUF.Text,
                Cep = frmEditarFuncionario.txbCEP.Text,
                Rua = frmEditarFuncionario.txbEndereco.Text,
                Numero = frmEditarFuncionario.txbNumero.Text

            };
            
            frmEditarDependentes frmEditarDependentes = Frm.Frm;
            Endereco enderecoDep = new Endereco()
            {
                Bairro = frmEditarDependentes.txbBairro.Text,
                Cep = frmEditarDependentes.txbBairro.Text,
                Numero = frmEditarDependentes.txbNumero.Text,
                Rua = frmEditarDependentes.txbEndereco.Text,
                Uf = frmEditarDependentes.txbUF.Text
            };
            
            Dependente dependente = new Dependente()
            {
                NomeDependente = frmEditarDependentes.txbNomeCompleto.Text,
                Grauparentesco = frmEditarDependentes.txbGrauParentesco.Text,
                EnderecoDep = enderecoDep
            };

            FrmEditarCargosadosBanc frmEditarCargosadosBanc = Frm;
            Cargo cargo = new Cargo()
            {
                NomeCargo = frmEditarCargosadosBanc.txbCargo.Text,
                Agencia = frmEditarCargosadosBanc.txbAgencia.Text,
                DataAdmissao = frmEditarCargosadosBanc.txbAdmissao.Text,
                JornadaTrabalho = frmEditarCargosadosBanc.txbJornada.Text,
                SalarioMensal = frmEditarCargosadosBanc.txbSalarioMensal.Text,
                SalarioDia = frmEditarCargosadosBanc.txbSalarioDia.Text,
                Banco = frmEditarCargosadosBanc.txbBanco.Text,
                Conta = frmEditarCargosadosBanc.txbConta.Text,
            };
            
            Funcionario funcionario = new Funcionario()
            {
                Cpf = frmEditarFuncionario.txbCPF.Text,
                Rg = frmEditarFuncionario.txbRG.Text,
                Nacionalidade = frmEditarFuncionario.txbNacionalidade.Text,
                Email = frmEditarFuncionario.txbEmail.Text,
                DataNascimento = frmEditarFuncionario.txbDataNascimento.Text,
                Pis = frmEditarFuncionario.txbPIS.Text,
                Sexo = frmEditarFuncionario.txbGenero.Text,
                EstadoCivil = frmEditarFuncionario.txbEstadoCivil.Text,
                NomeCompleto = frmEditarFuncionario.txbNomeCompleto.Text,
                EnderecoFunc = endereco,
                Cargo = cargo,
                Dependente = dependente,
                Senha = senha,
                IdFuncionario=Int32.Parse(frmEditarFuncionario.txbID.Text)
            };
            controle.EditarFuncionario(funcionario);
            MessageBox.Show(controle.mensagem);

        }

        private void frmEditarSenha_Load(object sender, EventArgs e)
        {
           
        }
    }
}
