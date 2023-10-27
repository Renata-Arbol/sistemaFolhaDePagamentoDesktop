using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities;

namespace Adicionar_Funcionário.Modelo
{
    public class Funcionario
    {

        public int IdFuncionario { get; set; }
        public string NomeCompleto { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Nacionalidade { get; set; }
        public string Email { get; set; }
        public string DataNasc { get; set; }
        public string DataAdmissao { get; set; }
        public string IdEmpresa { get; set; }
        public string IdDocumento { get; set; }
        public string Pis { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Genero { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public Endereco EnderecoFunc { get; set; }
        public Cargo Cargo {  get; set; }
        public Dependente Dependente { get; set; }
        public Senha Senha { get; set; }
    }
}


