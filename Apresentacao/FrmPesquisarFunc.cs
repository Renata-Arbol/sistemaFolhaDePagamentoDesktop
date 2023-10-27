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
using Adicionar_Funcionario.Modelo;
using Adicionar_Funcionário.Modelo;

namespace Adicionar_Funcionário
{
    public partial class FrmPesquisarFunc : Form
    {
        public FrmPesquisarFunc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void FrmListadeFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            frmDadosFuncionario frmDadosFuncionario = new frmDadosFuncionario();
            frmDadosFuncionario.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
               
                if (control is TextBox)
                {
                    
                    ((TextBox)control).Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

