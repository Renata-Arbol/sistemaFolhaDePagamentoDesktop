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

namespace Adicionar_Funcionário
{
    public partial class frmCadSenha : Form
    {
        public FrmCadCargo Frm { get; set; }
        public Funcionario Funcionario { get; set; }
        public frmCadSenha()
        {
            InitializeComponent();
        }

        private void lblCadastrarSenha_Load(object sender, EventArgs e)
        {
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Senha senha = new Senha() { 
            
                Criarsenha=txbCriarSenha.Text,
                Confimarsenha=txbConfirmarSenha.Text
            };

            //chama a validação
            Controle controle = new Controle( );
            
            frmAdicionarFuncionario frmAdicionarFuncionario = Frm.Frm.Frm;


            //Endereço
            Endereco endereco = new Endereco()
            {
                Bairro = frmAdicionarFuncionario.txbBairro.Text,
                Uf = frmAdicionarFuncionario.txbUF.Text,
                Cep = frmAdicionarFuncionario.txbCEP.Text,
                Logradouro = frmAdicionarFuncionario.txbLogradouro.Text,
                Rua = frmAdicionarFuncionario.txbEndereco.Text,
                Numero = frmAdicionarFuncionario.txbNumero.Text

            };
           
            //endereco
            string idEndereco = controle.adicionarEndereco(endereco);
            endereco.IdEndereco= idEndereco;

            //depen
            frmCadastroDependentes frmCadastroDependentes = Frm.Frm;
            Endereco enderecoDep = new Endereco() { 
            Bairro= frmCadastroDependentes.txbBairro.Text,
            Cep= frmCadastroDependentes.txbCEP.Text,
            Numero = frmCadastroDependentes.txbNumero.Text,
            Rua= frmCadastroDependentes.txbEndereco.Text,
            Uf= frmCadastroDependentes.txbUF.Text
            };
            string idEnderecoDp = controle.adicionarEndereco(enderecoDep);
            enderecoDep.IdEndereco = idEnderecoDp;


            Dependente dependente = new Dependente()
            { 
             NomeDependente=frmCadastroDependentes.txbNomeCompleto.Text,
             Grauparentesco=frmCadastroDependentes.txbGrauParentesco.Text,
             EnderecoDep= enderecoDep
            };
            
            string idDependentes = controle.adicionarDepen(dependente);
            dependente.IdDependente = idDependentes;
            
            //cargo
            FrmCadCargo frmCadCargo = Frm;
            Cargo cargo = new Cargo() { 
            NomeCargo=frmCadCargo.txbCargo.Text,
            Agencia=frmCadCargo.txbAgencia.Text,
            DataAdmissao=frmCadCargo.txbAdmissao.Text,
            JornadaTrabalho=frmCadCargo.txbJornada.Text,
            SalarioMensal=frmCadCargo.txbSalarioMensal.Text,
            SalarioDia=frmCadCargo.txbSalarioDia.Text,
            Banco=frmCadCargo.txbBanco.Text,
            Conta=frmCadCargo.txbConta.Text,
            };
            
            string idCargo = controle.cadastroCargo(cargo);
            cargo.IdCargo = idCargo;

            //para inserir id dependente na tabela funcionario
            Funcionario funcionario = new Funcionario()
            {
                Cpf = frmAdicionarFuncionario.txbCPF.Text,
                Rg = frmAdicionarFuncionario.txbRG.Text,
                Nacionalidade = frmAdicionarFuncionario.txbNacionalidade.Text,
                Email = frmAdicionarFuncionario.txbEmail.Text,
                DataNascimento = frmAdicionarFuncionario.txbDataNascimento.Text,
                Pis = frmAdicionarFuncionario.txbPIS.Text,
                Sexo = frmAdicionarFuncionario.txbGenero.Text,
                EstadoCivil = frmAdicionarFuncionario.txbEstadoCivil.Text,
                NomeCompleto = frmAdicionarFuncionario.txbNomeCompleto.Text,
                EnderecoFunc = endereco,
                Cargo = cargo,
                Dependente = dependente,
                Senha = senha
            };
            // inserir todos os dados no banco de dados 
            controle.adicionarFuncionario(funcionario);
            MessageBox.Show(controle.mensagem);
        }
    }
}
