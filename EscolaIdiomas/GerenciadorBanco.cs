using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace EscolaIdiomas
{
    class GerenciadorBanco
    {
        static string strConexao = "Data Source=.\\SQLEXPRESS; Initial Catalog=MADRELINGUA; Integrated Security=SSPI;";

        public static bool CadastrarAluno(int codResp, string nomeAluno, string rg, 
                                          string cpf, string nasc, char sexo,
                                          string email, string telefone, string telefoneAlt,
                                          string endereco, string bairro, string cidade,
                                          string nomeMae, string nomePai, string telMae,
                                          string telPai, string foto)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                if (codResp == 0)
                {
                    cmd.CommandText = "INSERT INTO Aluno " +
                                      "(nome_aluno, rg_aluno, cpf_aluno, " +
                                      "nasc_aluno, sexo_aluno, email_aluno, tel_aluno, tel_alternativo_aluno, " +
                                      "endereco_aluno, bairro_aluno, cidade_aluno, mae, tel_mae, " +
                                      "pai, tel_pai, foto_aluno, situacao_aluno) VALUES " +
                                      "(@nomeAluno, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                      "@endereco, @bairro, @cidade, @mae, @telMae, @pai, @telPai, CONVERT(VARBINARY(MAX), @foto), @situacao)";

                }
                else
                {
                    cmd.CommandText = "INSERT INTO Aluno " +
                                      "(cod_responsavel, nome_aluno, rg_aluno, cpf_aluno, " +
                                      "nasc_aluno, sexo_aluno, email_aluno, tel_aluno, tel_alternativo_aluno, " +
                                      "endereco_aluno, bairro_aluno, cidade_aluno, mae, tel_mae, " +
                                      "pai, tel_pai, foto_aluno, situacao_aluno) VALUES " +
                                      "(@codResp, @nomeAluno, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                      "@endereco, @bairro, @cidade, @mae, @telMae, @pai, @telPai, CONVERT(VARBINARY(MAX), @foto), @situacao)";

                    cmd.Parameters.Add(new SqlParameter("@codResp", codResp));
                }

                cmd.Parameters.Add(new SqlParameter("@nomeAluno", nomeAluno));
                cmd.Parameters.Add(new SqlParameter("@rg", rg));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
                cmd.Parameters.Add(new SqlParameter("@nasc", nasc));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@tel", telefone));
                cmd.Parameters.Add(new SqlParameter("@telAlt", telefoneAlt));
                cmd.Parameters.Add(new SqlParameter("@endereco", endereco));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairro));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidade));
                cmd.Parameters.Add(new SqlParameter("@mae", nomeMae));
                cmd.Parameters.Add(new SqlParameter("@telMae", telMae));
                cmd.Parameters.Add(new SqlParameter("@pai", nomePai));
                cmd.Parameters.Add(new SqlParameter("@telPai", telPai));
                cmd.Parameters.Add(new SqlParameter("@foto", "SELECT * FROM OPENROWSET(BULK '"+foto+"', SINGLE_BLOB) a"));
                cmd.Parameters.Add(new SqlParameter("@situacao", 'i'));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarResponsavel(string nome, string rg,
                                                string cpf, string nasc, char sexo,
                                                string telefone, string telefoneAlt,
                                                string endereco, string bairro, string cidade)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Responsavel VALUES " +
                                  "(@nome, @rg, @cpf, @nasc, @sexo, @tel, @telAlt, " +
                                  "@endereco, @bairro, @cidade, @situacao)";

                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.Parameters.Add(new SqlParameter("@rg", rg));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
                cmd.Parameters.Add(new SqlParameter("@nasc", nasc));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@tel", telefone));
                cmd.Parameters.Add(new SqlParameter("@telAlt", telefoneAlt));
                cmd.Parameters.Add(new SqlParameter("@endereco", endereco));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairro));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidade));
                cmd.Parameters.Add(new SqlParameter("@situacao", 'a'));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static int GetCodResp()
        {
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_responsavel FROM Responsavel ORDER BY cod_responsavel DESC";
                cmd.CommandType = CommandType.Text;
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return id;
        }

        public static void AdicionarImagem(string caminhoImagem)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Aluno(foto_aluno) SELECT * FROM OPENROWSET (BULK '" + caminhoImagem + "', SINGLE_BLOB) a";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
