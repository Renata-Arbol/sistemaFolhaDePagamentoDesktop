using Adicionar_Funcionário.Modelo;
using Adicionar_Funcionario.Modelo;
using DesktopPim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Adicionar_Funcionário
{
    public partial class frmAdicionarFuncionario : Form
    {
        //public FrmCadCargo Frm { get; set; }
        public Funcionario Funcionario { get; set; }

        private string mensagem;

        public frmAdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        public void btnProximo_Click(object sender, EventArgs e)
        {
            Modelo.Endereco endereco = new Modelo.Endereco()
            {
                Bairro= txbBairro.Text,
                Uf= txbUF.Text,
                Cep= txbCEP.Text,
                Logradouro= txbLogradouro.Text,
                Rua = txbEndereco.Text,
                Numero = txbNumero.Text
                
            };
            Modelo.Funcionario funcionario = new Funcionario() {
                Cpf = txbCPF.Text,
                Rg = txbRG.Text,
                Nacionalidade= txbNacionalidade.Text,
                Email = txbEmail.Text,
                DataNascimento = txbDataNascimento.Text,
                Pis = txbPIS.Text,
                Sexo = txbGenero.Text,
                EstadoCivil = txbEstadoCivil.Text,
                NomeCompleto = txbNomeCompleto.Text,
                EnderecoFunc = endereco,
                Telefone = txbTelefone.Text,
                Genero = txbGenero.Text,
                
            };

            Controle controle = new Controle();
            FrmCadCargo Frm = new FrmCadCargo();
            frmAdicionarFuncionario frmAdicionarFuncionario = new frmAdicionarFuncionario();
            
            frmCadastroDependentes frmCadastroDependentes = new frmCadastroDependentes() { Frm = this };
            //chamar o metodo de validação, caso esteja tudo certo mostra a proxima pagina
            if (controle.ValidacaoFunc(funcionario))
            {
                frmCadastroDependentes.Show();
                this.Hide();

            }
            MessageBox.Show(controle.mensagem);




        }



    }
        
           


    }


