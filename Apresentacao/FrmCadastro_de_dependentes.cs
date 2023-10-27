﻿using Adicionar_Funcionario.Modelo;
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
    public partial class frmCadastroDependentes : Form
    {
        public frmAdicionarFuncionario Frm { get; set; }
        public frmCadastroDependentes()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // Verifica se o controle é um TextBox
                if (control is TextBox)
                {
                    // Limpa o texto do TextBox
                    ((TextBox)control).Clear();
                }
            }
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco()
            {
                Rua = txbEndereco.Text,
                Numero = txbNumero.Text,
                Bairro = txbBairro.Text,
                Uf = txbUF.Text
            };
            Dependente dependente = new Dependente()
            {
                Grauparentesco = txbGrauParentesco.Text,
                NomeDependente= txbNomeCompleto.Text,
                EnderecoDep = endereco
            };
            Controle controle = new Controle();

            FrmCadCargo frmCadCargo = new FrmCadCargo() { Frm = this };
            if (controle.ValidarDadosDependentes(dependente))
            {
                frmCadCargo.Show();
                this.Hide();
            }
            MessageBox.Show(controle.mensagem);
        }
    }
}