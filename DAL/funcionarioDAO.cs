using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adicionar_Funcionario.Modelo;
using Adicionar_Funcionário.Modelo;
using System.Drawing;

namespace Adicionar_Funcionário.DAL
{
    public class funcionarioDAO
    {
        SqlDataReader dr;
        public string mensagem;


        public void adicionarFuncionarioBanco(Funcionario funcionario)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            // editar conforme banco
            cmd.CommandText = @"insert into funcionarios (nomCompleto,dataNasc,sexo, estadoCivil, nacionalidade, rgFunc, pisFunc, cpfFunc, email, idDependente, idCargo,senha,  idEmpresa,dataAdmissao) 
                            values (@nomeCompleto,STR_TO_DATE(@dataNasc, ""%d/%m/%Y""), @sexo, @estadoCivil, @nacionalidade, @rg, @pis, @cpf, @email, @idDependente, @idCargo, @senha, @idEmpresa,STR_TO_DATE(@dataAdmissao, ""%d/%m/%Y""))";

            cmd.Parameters.AddWithValue("@nomeCompleto", funcionario.NomeCompleto);
            cmd.Parameters.AddWithValue("@dataNasc", funcionario.DataNascimento);
            cmd.Parameters.AddWithValue("@sexo", funcionario.Genero);
            cmd.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
            cmd.Parameters.AddWithValue("@nacionalidade", funcionario.Nacionalidade);
            cmd.Parameters.AddWithValue("@rg", funcionario.Rg);
            cmd.Parameters.AddWithValue("@pis", funcionario.Pis);
            cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            cmd.Parameters.AddWithValue("@idDependente", funcionario.Dependente.IdDependente);
            cmd.Parameters.AddWithValue("@idCargo", funcionario.Cargo.IdCargo);
            cmd.Parameters.AddWithValue("@senha", funcionario.Senha.Confimarsenha);
            cmd.Parameters.AddWithValue("@idEmpresa", 1);
            cmd.Parameters.AddWithValue("@dataAdmissao",funcionario.Cargo.DataAdmissao);

            try
            {
                Conexao conn = new Conexao();
                cmd.Connection = conn.conectar();

                cmd.ExecuteNonQuery();
                conn.desconectar();
                this.mensagem = "Funcionário adicionado com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

        }
      
        public string adicionarDependenteBanco(Dependente dependente)
        {
            this.mensagem = "";
            string id = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into dependentes (nomeDepen,parentesco,idEndereco2) 
            values (@nomeDepen,@parentesco, @idEndereco2)";
            cmd.Parameters.AddWithValue("@nomeDepen", dependente.NomeDependente);
            cmd.Parameters.AddWithValue("@parentesco", dependente.Grauparentesco);
            cmd.Parameters.AddWithValue("@idEndereco2", dependente.EnderecoDep.IdEndereco);          

            try
            {
                Conexao conn = new Conexao();
                cmd.Connection = conn.conectar();

                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId.ToString();
                conn.desconectar();
                this.mensagem = "Funcionário adicionado com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return id;

        }

        public string adicionarEndereco (Endereco endereco)
        {
            string id = "";
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into endereco_funcionario(cep, estado, bairro, nomeRua, numeroCasa ) 
            values (@cep, @estado, @bairro, @nomeRua, @numeroCasa)";

            cmd.Parameters.AddWithValue("@cep", endereco.Cep);
            cmd.Parameters.AddWithValue("@estado", endereco.Uf);
            cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
            cmd.Parameters.AddWithValue("@nomeRua", endereco.Rua);
            cmd.Parameters.AddWithValue("@numeroCasa", endereco.Numero);

            try
            {
                Conexao conn = new Conexao();
                cmd.Connection = conn.conectar();

                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId.ToString();
                conn.desconectar();
                this.mensagem = "Endereço adicionado com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
                Console.WriteLine(e.Message);
            }

            return id;

        }


        public string cadastroCargoBanco(Cargo cargo)
        {
            this.mensagem = "";
            string id = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into cargo ( nomeCargo, dataAdmissao, jornadaTrabalho, salarioMensal, salarioDia, agencia,
            conta, banco) 
            values (@nomeCargo, @dataAdmissao, @jornadaTrabalho, @salarioMensal,
            @salarioDia, @agencia, @conta, @banco)";
            
            cmd.Parameters.AddWithValue("@nomeCargo", cargo.NomeCargo);
            cmd.Parameters.AddWithValue("@dataAdmissao", cargo.DataAdmissao);
            cmd.Parameters.AddWithValue("@jornadaTrabalho", cargo.JornadaTrabalho);
            cmd.Parameters.AddWithValue("@salarioMensal", cargo.SalarioMensal);
            cmd.Parameters.AddWithValue("@salarioDia", cargo.SalarioDia);
            cmd.Parameters.AddWithValue("@agencia", cargo.Agencia);
            cmd.Parameters.AddWithValue("@conta", cargo.Conta);
            cmd.Parameters.AddWithValue("@banco", cargo.Banco);
            try
            {
                Conexao conn = new Conexao();
                cmd.Connection = conn.conectar();

                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId.ToString();
                conn.desconectar();
                this.mensagem = "Funcionário adicionado com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

            return id;

        }

        public Endereco PesquisarEndereco(Funcionario funcionario)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            Endereco returnEndereco = new Endereco();
            cmd.CommandText = @"select * from endereco_funcionario
             where idFuncionario = @idFuncionario";

            cmd.Parameters.AddWithValue("@idFuncionario", funcionario.IdFuncionario);
            try
            {

                Conexao conn = new Conexao();
                cmd.Connection = conn.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        returnEndereco.IdEndereco = dr["idEndereco"].ToString();
                        returnEndereco.Cep = dr["cep"].ToString();
                        returnEndereco.Uf = dr["estado"].ToString();
                        returnEndereco.Bairro = dr["bairro"].ToString();
                        returnEndereco.Rua = dr["nomeRua"].ToString();
                        returnEndereco.Numero = dr["numeroCasa"].ToString();
                    }
                    dr.Close();
                }
                else
                {
                    this.mensagem = "Não existe este Nome";
                }
                conn.desconectar();
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }

            return returnEndereco;
        }

        public List<Funcionario> pesquisar(Funcionario funcionario)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            cmd.CommandText = @"select * from funcionarios
             where nomCompleto like @nomeCompleto";

            cmd.Parameters.AddWithValue("@nomeCompleto", funcionario.NomeCompleto + "%");
            try
            {

                Conexao conn = new Conexao();
                cmd.Connection = conn.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Funcionario f = new Funcionario();
                        Senha senha = new Senha();
                        Cargo cargo = new Cargo();
                        Dependente dependente = new Dependente();
                        f.IdFuncionario = Convert.ToInt32(dr["idFuncionario".ToString()]);
                        f.NomeCompleto = dr["nomCompleto"].ToString();
                        f.Rg = dr["rgFunc"].ToString();
                        f.Cpf = dr["cpfFunc"].ToString();
                        f.Sexo = dr["sexo"].ToString();
                        f.EstadoCivil = dr["estadoCivil"].ToString();
                        f.DataNasc= dr["dataNasc"].ToString();
                        f.Nacionalidade = dr["nacionalidade"].ToString();
                        senha.Confimarsenha = dr["senha"].ToString();
                        f.Senha = senha;
                        f.DataAdmissao = dr["dataAdmissao"].ToString();
                        f.Pis = dr["pisFunc"].ToString();
                        cargo.IdCargo= dr["idCargo"].ToString();
                        f.Cargo = cargo;
                        dependente.IdDependente = dr["idDependente"].ToString();
                        f.Dependente= dependente;
                        f.Email = dr["email"].ToString();

                        listaFuncionarios.Add(f);
                    }
                    dr.Close();
                }
                else
                {
                    this.mensagem = "Não existe este Nome";
                }
                conn.desconectar();
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
           
            return listaFuncionarios;
        }

             public void editarFuncionario (Funcionario funcionario)
        {
             this.mensagem = "";
             MySqlCommand cmd = new MySqlCommand();
             cmd.CommandText = @"update pessoas set nome = @nomeCompleto, 
                                rg = @rg, cpf = @cpf, data_nascimento = @data_nascimento, genero = @genero, estado_civil = @estadoCivil, 
                                where idFuncionario = @id";
            /*cmd.Parameters.AddWithValue("@nome", funcionario.nomeCompleto);
            cmd.Parameters.AddWithValue("@data_nascimento", funcionario.data_nascimento);
            cmd.Parameters.AddWithValue("@genero", funcionario.genero);
            cmd.Parameters.AddWithValue("@estado_civil", funcionario.estadoCivil);
            cmd.Parameters.AddWithValue("@nacionalidade", funcionario.nacionalidade);
            cmd.Parameters.AddWithValue("@rg", funcionario.rg);
            cmd.Parameters.AddWithValue("@pis", funcionario.pis);
            cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
            cmd.Parameters.AddWithValue("@endereco", funcionario.endereco);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@bairro", funcionario.bairro);
            cmd.Parameters.AddWithValue("@uf", funcionario.uf);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@logradouro", funcionario.logradouro);
            cmd.Parameters.AddWithValue("@email", funcionario.email);
            cmd.Parameters.AddWithValue("@id_dependente", funcionario.idDependente);
            cmd.Parameters.AddWithValue("@grauparentesco", funcionario.grauparentesco);
            cmd.Parameters.AddWithValue("@id_cargo", funcionario.idCargo);
            cmd.Parameters.AddWithValue("@cargo", funcionario.nomeCargo);
            cmd.Parameters.AddWithValue("@data_admissao", funcionario.dataAdmissao);
            cmd.Parameters.AddWithValue("@jornada_trabalho", funcionario.jornadaTrabalho);
            cmd.Parameters.AddWithValue("@salario_mensal", funcionario.salarioMensal);
            cmd.Parameters.AddWithValue("@salario_dia", funcionario.salarioDia);
            cmd.Parameters.AddWithValue("@agencia", funcionario.agencia);
            cmd.Parameters.AddWithValue("@conta", funcionario.conta);
            cmd.Parameters.AddWithValue("@banco", funcionario.banco);
            cmd.Parameters.AddWithValue("@criarsenha", funcionario.criarsenha);
            cmd.Parameters.AddWithValue("@confirmarsenha", funcionario.senha);*/

            try
            {
                Conexao con = new Conexao();
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Funcionario editado com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
        }
    }
}
