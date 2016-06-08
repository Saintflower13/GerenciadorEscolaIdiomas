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
                    cmd.CommandText = "SET DATEFORMAT DMY " +
                                      "INSERT INTO Aluno (nome_aluno, rg_aluno, cpf_aluno, " +
                                      "nasc_aluno, sexo_aluno, email_aluno, tel_aluno, tel_alternativo_aluno, " +
                                      "endereco_aluno, bairro_aluno, cidade_aluno, mae, tel_mae, " +
                                      "pai, tel_pai, foto_aluno, situacao_aluno) VALUES " +
                                      "(@nomeAluno, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                      "@endereco, @bairro, @cidade, @mae, @telMae, @pai, @telPai, CONVERT(VARBINARY(MAX), @foto), @situacao)";

                }
                else
                {
                    cmd.CommandText = "SET DATEFORMAT DMY " +
                                      "INSERT INTO Aluno (cod_responsavel, nome_aluno, rg_aluno, cpf_aluno, " +
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
                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "INSERT INTO Responsavel VALUES " +
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

        public static bool CadastrarProfessor(string nome, string rg, string cpf, string nasc, char sexo,
                                              string email, string telefone, string telefoneAlt,
                                              string endereco, string bairro, string cidade,
                                              string admissao, string foto)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                
                cmd.CommandText = "SET DATEFORMAT DMY " +
                                   "INSERT INTO Professor (nome_prof, rg_prof, cpf_prof, " +
                                   "nasc_prof, sexo_prof, email_prof, tel_prof, tel_alternativo_prof, " +
                                   "endereco_prof, bairro_prof, cidade_prof, admissao_prof, foto_prof) VALUES " +
                                   "(@nome, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                   "@endereco, @bairro, @cidade, @admissao, CONVERT(VARBINARY(MAX), @foto))";
                
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
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
                cmd.Parameters.Add(new SqlParameter("@admissao", admissao));
                cmd.Parameters.Add(new SqlParameter("@foto", "SELECT * FROM OPENROWSET(BULK '" + foto + "', SINGLE_BLOB) a"));

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

        public static bool CadastrarCurso(int codCurso, string nome, string duracaoMeses, string duracaoHoras,  int modulos, 
                                          string aulasSemanais, string matricula, float valorTotal,
                                          float multa, float rescisao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "INSERT INTO Curso (cod_curso, nome_curso, duracao_meses, duracao_horas, qtd_modulos, qtd_aulas_semanais, " +
                                  "valor_matricula, valor_total, valor_multa, valor_rescisao) " +
                                  "VALUES " +
                                  "(@cod, @nome, @meses, @horas, @modulos, @aSemanais, @vMatricula, @vTotal, @vMulta, @vRescisao)";

                cmd.Parameters.Add(new SqlParameter("@cod", codCurso));
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.Parameters.Add(new SqlParameter("@meses", duracaoMeses));
                cmd.Parameters.Add(new SqlParameter("@horas", duracaoHoras));
                cmd.Parameters.Add(new SqlParameter("@modulos", modulos));
                cmd.Parameters.Add(new SqlParameter("@aSemanais", aulasSemanais));
                cmd.Parameters.Add(new SqlParameter("@vMatricula", matricula));
                cmd.Parameters.Add(new SqlParameter("@vTotal", valorTotal));
                cmd.Parameters.Add(new SqlParameter("@vMulta", multa));
                cmd.Parameters.Add(new SqlParameter("@vRescisao", rescisao));

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

        public static bool CadastrarModulo(int codModulo,int codCurso, string descricao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Modulo (cod_modulo, cod_curso, descricao_modulo) VALUES " +
                                  "(@codModulo, @codCurso, @descricao)";

                cmd.Parameters.Add(new SqlParameter("@codModulo", codModulo));
                cmd.Parameters.Add(new SqlParameter("@codCurso", codCurso));
                cmd.Parameters.Add(new SqlParameter("@descricao", descricao));

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

        public static bool CadastrarTurma(int codTurma, int codCurso, int qtdMin, int qtdMax, string diasSemana, string horarioInicial, int codProf)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Turma(cod_turma, cod_curso, qtd_min_aluno,  qtd_max_aluno, dias_semana, horario_inicial, cod_prof) " +
                                  "VALUES (@codTurma, @codCurso, @qtdMin, @qtdMax, @diasSemana, @horarioInicial, codProf)";

                cmd.Parameters.Add(new SqlParameter("@codTurma", codTurma));
                cmd.Parameters.Add(new SqlParameter("@codCurso", codCurso));
                cmd.Parameters.Add(new SqlParameter("@qtdMin", qtdMin));
                cmd.Parameters.Add(new SqlParameter("@qtdMax", qtdMax));
                cmd.Parameters.Add(new SqlParameter("@diasSemana", diasSemana));
                cmd.Parameters.Add(new SqlParameter("@horarioInicial", horarioInicial));
                cmd.Parameters.Add(new SqlParameter("@codProf", codProf));

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

        public static int GetCodCurso()
        {
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_curso FROM Curso ORDER BY cod_curso DESC";
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

        public static int GetCodModulo(string CodCurso)
        {
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_modulo FROM Modulo WHERE cod_curso = @codCurso ORDER BY cod_modulo DESC";
                cmd.Parameters.Add(new SqlParameter("@codCurso", CodCurso));
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

        public static int GetCodTurma(int codCurso)
        {
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_turma FROM Turma INNER JOIN Curso ON Turma.cod_curso = Curso.cod_curso WHERE Curso.cod_curso = @codCurso ORDER BY cod_turma DESC";
                cmd.Parameters.Add(new SqlParameter("@codCurso", codCurso));
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

        public static List<string> getListaCursos(string parte_nome)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TOP 5 nome_curso FROM Curso WHERE nome_curso LIKE @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", parte_nome + "%"));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add(dr.GetString(0));

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public static List<string> getLista(string parte_nome)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TOP 5 nome_prof FROM Professor WHERE nome_prof LIKE @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", parte_nome + "%"));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add(dr.GetString(0));

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public static List<int> getCodsProfs(string nomeProf)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<int> lista = new List<int>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TOP 5 cod_prof FROM Professor WHERE nome_prof LIKE @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", nomeProf + "%"));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add((int)dr.GetSqlInt16(0));

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }
    }
}
