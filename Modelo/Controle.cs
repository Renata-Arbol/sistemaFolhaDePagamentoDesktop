using Adicionar_Funcionário.DAL;
using Adicionar_Funcionário.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicionar_Funcionario.Modelo
{
    public class Controle
    {
        public string mensagem;

        //Inserir no Banco de Dados -só chamar se for inserir no banco
        public bool adicionarFuncionario(Funcionario funcionario)
        {
            bool adicionado = true;
 
            //verificar se a ordem esta certa dos dados se o indice 0 realmente é o nome, etc ...
            funcionarioDAO funcionarioDAO = new funcionarioDAO();
            funcionarioDAO.adicionarFuncionarioBanco(funcionario);
            
            this.mensagem = funcionarioDAO.mensagem;
            if(String.IsNullOrEmpty(this.mensagem))
                adicionado = false;
            return adicionado;
        }

        public string adicionarDepen(Dependente dependente)
        {
            funcionarioDAO funcionarioDAO = new funcionarioDAO();
            string id = funcionarioDAO.adicionarDependenteBanco(dependente);

            return id;
        }
        public string adicionarEndereco(Endereco endereco)
        {
            funcionarioDAO funcionarioDAO = new funcionarioDAO();
            string id = funcionarioDAO.adicionarEndereco(endereco);

            return id;
        }
        public string cadastroCargo(Cargo cargo)
        {
            funcionarioDAO funcionarioDAO = new funcionarioDAO();
            string id = funcionarioDAO.cadastroCargoBanco(cargo);

            return id;
        }


        //Validar dados funcionário
        public bool ValidacaoFunc(Funcionario funcionario)
        {
            //se tiver validado retorna verdadeiro
            bool validado = true;

            Validacao validacao = new Validacao();

            if (!validacao.ValidarDadosFuncionario(funcionario))
            {
                this.mensagem = validacao.mensagem;
                validado = false;
            }
            return validado;

        }

        // validar dependentes
        public bool ValidarDadosDependentes(Dependente dependente)
        {
           
            bool validado = true;

            Validacao validacao = new Validacao();

            if (!validacao.ValidarDadosDependentes(dependente))
            {
                this.mensagem = validacao.mensagem;
                validado = false;
            }
            return validado;
        }


        //validar cargos
        public bool ValidarDadosCargo(Cargo cargo)
        {
            bool validado = true;

            Validacao validacao = new Validacao();

            if (!validacao.ValidarDadosCargo(cargo))
            {
                this.mensagem = validacao.mensagem;
                validado = false;
            }
            return validado;
        }
        public Endereco PesquisarEndereco(Funcionario funcionario)
        {
            Endereco returnEndereco= new Endereco();
            if (!funcionario.IdFuncionario.Equals(""))
            {
                funcionarioDAO funcionarioDAO = new funcionarioDAO();
                returnEndereco = funcionarioDAO.PesquisarEndereco(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = "Endereco inválido";
            }
            return returnEndereco;

        }
            public List<Funcionario> pesquisar(String nomeCompleto)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            if (!nomeCompleto.Equals(""))
            {
                funcionarioDAO funcionarioDAO = new funcionarioDAO();
                funcionario.NomeCompleto =nomeCompleto;
                listaFuncionarios = funcionarioDAO.pesquisar(funcionario);
                this.mensagem = funcionarioDAO.mensagem; 
               
                
             
            }
            else
            {
                this.mensagem = "Nome inválido";
            }
            return listaFuncionarios;
        }

        internal List<Funcionario> pesquisar(object text)
        {
            throw new NotImplementedException();
        }
        public void EditarFuncionario(Funcionario funcionario)
        {
            Validacao validacao = new Validacao();
           
            if (validacao.ValidarDadosFuncionario(funcionario))
            {
                funcionarioDAO funcionarioDAO = new funcionarioDAO();
                funcionarioDAO.editarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }

  

    }
}
