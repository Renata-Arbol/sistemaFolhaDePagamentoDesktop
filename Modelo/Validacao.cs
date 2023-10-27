using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Adicionar_Funcionário.Modelo
{

    public class Validacao
    {
        public string mensagem;
        private bool validado;

        //Validar dados funcionário -- se tiver alguma mensagem de "erro" retorna como verdadeiro para mostrar a mensagem e não ir para proxima pagina
        public bool ValidarDadosFuncionario(Funcionario funcionario)
        {
            frmAdicionarFuncionario frmAdicionarFuncionario = new frmAdicionarFuncionario();
            bool validado = false;

            if (funcionario.NomeCompleto.Length < 3)
                this.mensagem += "Nome deve ter mais que 3 caracteres\n";
            if (funcionario.NomeCompleto.Length > 50)
                this.mensagem += "Nome deve ter menos que 50 caracteres\n";
            if (funcionario.DataNascimento.Length > 10)
                this.mensagem += "Data de nascimento deve ter menos que 10 caracteres\n";    
            if (funcionario.Genero != "M" && funcionario.Genero != "F")
                this.mensagem += "Genero deve ter apenas uma caracter, sendo M para Masculino e F para Feminino\n";
            if (funcionario.EstadoCivil.Length < 5)
                this.mensagem += "Estado Civil deve ter mais que 5 carcter\n";
            if (funcionario.Nacionalidade.Length < 2)
                this.mensagem += "Nacionalidade deve ter mais que 2 carcteres\n";
            if (funcionario.Rg.Length > 11)
                this.mensagem += "RG listaDadosPessoadeve ter menos que 11 caracteres\n";
            if (funcionario.Pis.Length > 12)
                this.mensagem += "PIS deve ter menos 12 caracteres\n";
            if (funcionario.Cpf.Length > 13)
                this.mensagem += "CPF deve ter menos que 13 caracteres\n";
            if (funcionario.EnderecoFunc.Rua.Length < 5)
                this.mensagem += "Endereço deve ter mais que 5 caracteres\n";
            if (funcionario.Telefone.Length > 15)
                this.mensagem += "Telefone deve ter menos que 15 caracteres\n";
            if (funcionario.EnderecoFunc.Numero.Length > 15)
                this.mensagem += "Numero deve ter menos que 15 caracteres\n";
            if (funcionario.EnderecoFunc.Bairro.Length < 5)
                this.mensagem += "Bairro deve ter mais que 5 caracteres";
            if (funcionario.EnderecoFunc.Uf.Length < 2)
                this.mensagem += " UF deve ter mais que 2 caracteres\n";
            if (funcionario.EnderecoFunc.Cep.Length > 10)
                this.mensagem += "CEP deve ter menos que 10 caracteres\n";
            if (funcionario.EnderecoFunc.Logradouro.Length < 5)
                this.mensagem += "Logradouro deve ter mais que 5 caracteres\n";
            if (funcionario.Email.Length < 7)
                this.mensagem += "Email deve ter mais que 7 caracteres\n";

            //caso a string mensagem não for vazia quer dizer que tem alguma coisa errada
            //se tiver vazia é que ta tudo certo então coloca comoo validado
            if (String.IsNullOrEmpty(this.mensagem))
                validado = true;

            return validado;
        }

        //Validar Dados Dependentes
        public bool ValidarDadosDependentes(Dependente dependente)
        {

           
            bool validado = false;

            this.mensagem = "";

            if (dependente.NomeDependente.Length < 3)
                this.mensagem += "Nome deve ter mais que 3 caracteres\n";
            if (dependente.NomeDependente.Length > 50)
                this.mensagem += "Nome deve ter menos que 50 caracteres\n";
            if (dependente.EnderecoDep.Rua.Length < 5) 
            this.mensagem += "Endereço deve ter mais que 5 caracteres\n";
            if (dependente.EnderecoDep.Uf.Length < 2)
                this.mensagem += "Uf deve ter mais que 2 caracteres\n";
            if (dependente.Grauparentesco.Length < 3)
                this.mensagem += "Grau de parentesco deve ter mais que 5 caracteres\n";

            if (String.IsNullOrEmpty(this.mensagem))
                validado = true;

            return validado;
        }


                //Validar Dados Cargo
        public bool ValidarDadosCargo(Cargo cargo)
        {
            
            bool validado = false;
            
                    this.mensagem = "";

                   // if (idcargo.Length < 2)
                        //this.mensagem += "ID Cargo deve ter mais que 2 caracteres\n";
                    if (cargo.NomeCargo.Length < 5)
                        this.mensagem += "Cargo deve ter mais que 5 caracteres\n";
                    if (cargo.DataAdmissao.Length > 10)
                        this.mensagem += "Data de admissão deve ter menos que 10 caracteres\n";
                    if (cargo.JornadaTrabalho.Length < 2)
                        this.mensagem += "Jornada deve ter mais que 2 caracteres\n";
                    if (cargo.SalarioMensal.Length < 4)
                        this.mensagem += "Salário Mensal deve ter mais que 4 caracteres\n";
                    if (cargo.SalarioDia.Length < 2)
                        this.mensagem += "Salário Dia deve ter mais que 2 caracteres\n";
                    if (cargo.Banco.Length < 4)
                        this.mensagem += "Banco deve ter mais que 4 caracteres\n";
                    if (cargo.Agencia.Length < 5)
                        this.mensagem += "Agencia deve ter mais que 5 caracteres\n";
                    if (cargo.Conta.Length < 5)
                        this.mensagem += "Conta deve ter mais que 5 caracteres\n";

                 if (String.IsNullOrEmpty(this.mensagem))
                validado = true;

            return validado;
        }
                    //Validar Cadastrar senha
         public bool ValidarDadosSenha(List<String> listaDadosSenha)
                    {
          frmCadSenha frmCadSenha = new frmCadSenha();
          bool validado = false;


          //Validação frmCadastrodeSenha

            string senha = listaDadosSenha[1];
                        if (senha.Length < 8)
                            this.mensagem += "Criar senha deve ter mais que 8 caracteres\n";
            if (String.IsNullOrEmpty(this.mensagem))
                 
                validado = true;

            return validado;
        }
    }

}
        
    














