using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DesktopPim;

namespace Adicionar_Funcionário.Apresentacao
{
    public partial class frmRelatorioFolhadePagamento : Form
    {
        public frmRelatorioFolhadePagamento()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltaraoMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
